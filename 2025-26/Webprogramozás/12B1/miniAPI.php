<?php
$a = (int)$_GET["a"] ?? 0;
$b = (int)$_GET["b"] ?? 0;
$muvelet = $_GET["muvelet"] ?? "Hát ilyen művelet nincs";
switch ($muvelet) {
    case "osszeadas":
        echo $a + $b;
        break;
    case "kivonas":
        echo $a - $b;
        break;
    case "szorzas":
        echo $a * $b;
        break;
    case "osztas":
        echo $b != 0 ? $a / $b : "0-val való osztás?!? Jaj...";
        break;
}

//echo $a + $b;
// mini Bootstrapes űrlap ( 2 szám -> JQueryvel küldés az APInak, a visszaérkező válasz nagy piros négyzet közepén jelenjen meg)
?>