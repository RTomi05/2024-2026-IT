<?php
$a = (int)$_GET["a"] ?? 0;
$b = (int)$_GET["b"] ?? 0;

echo $a + $b;
// mini Bootstrapes űrlap ( 2 szám -> JQueryvel küldés az APInak, a visszaérkező válasz nagy piros négyzet közepén jelenjen meg)
?>