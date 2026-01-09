<?php

    header('Content-Type: application/json; charset=utf-8');

    if( isset( $_GET['nap'] ))   $nap = $_GET['nap']    ;    else $nap = date("Y-m-d") ;
    if( isset( $_GET['ido'] ))   $ido = $_GET['ido']    ;    else $ido = date("H:i:s")   ;

    if( isset( $_GET['bg']  ))   $pbg ="&bg=$_GET[bg]"  ;    else $pbg = ""  ;

    $idopont = strtotime( $nap . " " . $ido ) ;

    if( $idopont==false )
    {
	$tomb = array( 'hiba' => "Hibás bemeneti dátumformátum!" ) ;
	$json = json_encode( $tomb , JSON_UNESCAPED_UNICODE ) ;
	die( $json ) ;
    }

    $alapdatum = mktime( 20,40,0 , 6,24,2021 ) ;
    $period    =  29.53058867 * 24*60*60 ;

    $elteres = $idopont-$alapdatum ;
    if($elteres>0)  { while( $elteres > $period )  $elteres -= $period ; }
    else            { while( $elteres < 0       )  $elteres += $period ; }

    $fazis = round( ($elteres*2-$period)/$period*100 ) ;						//  -1..1 között  :  -1 telihold(fogyó)   -0.5 utolsó negyed   0 újhold   0.5 első negyed   +1 telihold(növekvő)

    $fazis = round( (-cos( abs($fazis/100)*pi() )/2 + .5) * ( ($fazis>0)-($fazis<0) ) *100 ) ;		//  ($fazis>0)-($fazis<0) -> ez az sgn() fv. megvalósítása

    if( $fazis< 0  )  $valtozas = "fogyó"    ;
    if( $fazis> 0  )  $valtozas = "növekvő"  ;
    if( $fazis==0  )  $valtozas = "újhold"   ;
    if( $fazis==100)  $valtozas = "telihold" ;

    $kep = "https://api.infojegyzet.hu/holdfazis/moonphase.php?ph=$fazis" . $pbg ;

    $tomb = array( 'idopont' => date("Y-m-d H:i",$idopont) , 'holdfazis' => abs($fazis) , 'valtozas' => $valtozas , 'kep' => $kep ) ;

    $json = json_encode( $tomb , JSON_UNESCAPED_UNICODE ) ;

    print $json ;

?>