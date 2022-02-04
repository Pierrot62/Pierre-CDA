<?php
$id = $_POST["id"];
echo json_encode(ProduitsManager::findByIdCategorie($id,true));
