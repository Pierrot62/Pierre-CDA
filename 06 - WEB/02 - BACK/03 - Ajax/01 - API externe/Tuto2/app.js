function main() {
    if (Notification.permission == "default") {
        return;
    }
    document.getElementById('push').addEventListener('click', askPermission);
}



async function askPermission() {
    const permissionn = await Notification.requestPermission();
    if (permissionn == "granted") {
        registerServiceWorker();
    }
}

async function registerServiceWorker() {
        const registration = await navigator.serviceWorker.register("sw.js");
        let subscription = await registration.pushManager.getSubscription();
        console.log(subscription);
        if (subscription) {
            return;
        }

        subscription = await registration.pushManager.subscribe({
            userVisibleOnly: true,
            applicationServerKey: "BCc4xDsGvJLAaKOkYNzYhLC3jryL8jNxJ8PjlsCUzKgD-8pB6Bn_kp8sHwfwfdlmiW-8tpGdoi0J_LTEg40gwtM"
        })
        saveSubscription(subscription);
}

async function saveSubscription(subscription) {
    
}

main();