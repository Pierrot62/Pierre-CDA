const PREFIX = 'V9';
const CACHES_FILES = [
    "https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css",
    "style.css"
]

self.addEventListener('install', (event) => {
    //Permet de ne pas attendre l'actualisation du serviceWorker
    self.skipWaiting();
    //Ajoute des infos en cache
    event.waitUntil(
        (async () => {
            const cache = await caches.open(PREFIX);
            await Promise.all([...CACHES_FILES, '/offline.html'].map((path) => {
                return cache.add(new Request(path));
            }));
        })()
    );
    console.log(`${PREFIX} Install`);
})
self.addEventListener('activate', (event) => {
    //Permet d'activer automatiquement le Worker a l'arriver sur l'application (sans attendre le 2eme appel)
    clients.claim();
    //Supprime le caches des anciens workers
    event.waitUntil(
        (async () => {
            const keys = await caches.keys();
            await Promise.all(
                keys.map((key) => {
                    if (!key.includes(PREFIX)) {
                        return caches.delete(key);
                    }
                })
            );
        })()
    );
    console.log(`${PREFIX} Active`);
});

self.addEventListener("fetch", (event) => {
    console.log(`${PREFIX} Fetching : ${event.request.url}, Mode : ${event.request.mode}`);
    if (event.request.mode === 'navigate') {
        event.respondWith(
            (async () => {
                try {
                    const preloadResponse = await event.preloadResponse;
                    if (preloadResponse) {
                        return preloadResponse;
                    }
                    return await fetch(event.request);
                } catch (e) {
                    const cache = await caches.open(PREFIX);
                    return await cache.match('/offline.html');
                }
            })()
        );
    } else if(CACHES_FILES.includes(event.request.url)){
        event.respondWith(caches.match(event.request));
    }
});