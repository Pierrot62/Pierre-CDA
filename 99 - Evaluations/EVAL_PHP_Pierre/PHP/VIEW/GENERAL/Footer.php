<div class="footer2"></div>
<footer class="footerFantome"></footer>
<footer>
   <div class="double center">
      <p><strong>Services et Garanties</strong>
         <br>
         Garanties et assurances
         <br>
         Mon espace Client
         <br>
         Nos magasins
      </p>
   </div>
   <div class="double center">
      <p><strong>Livraison et paiement</strong>
         <br>
         Les modes et frais de livraisons
         <br>
         Livraison en europe
         <br>
         Livraison à l'international
      </p>
   </div>
   <div class="double center">
      <p><strong>
            Contactez nous
         </strong>
         <br>
         Contact Service Client
         <br>
         Contact publicité
         <br>
         Recrutement
      </p>
   </div>
</footer>
<?php
if (substr($page[1], 0, 4) == "Form") {
   echo ' <script src="./JS/VerifForm.js"></script>';
}
echo ' <script src="./JS/script.js"></script>';
echo '</body>
</html>';
