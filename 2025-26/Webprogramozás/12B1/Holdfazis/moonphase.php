<?php
      header("Content-type: image/gif") ;
      $kep = imagecreate( 180, 180 ) ;

	$fekete = imagecolorallocate( $kep,  16,  16,  16 ) ;   if( isset($_GET['bg']) && $_GET['bg']==0 )  { imagecolortransparent( $kep, $fekete ) ;  $korr=1 ; }  else { $korr=0 ; }
	$szurke = imagecolorallocate( $kep,  32,  32,  16 ) ;   if( isset($_GET['bg']) && $_GET['bg']==0 )    $szurke = imagecolorallocate( $kep,  255,  255,  220 ) ;
	$sarga  = imagecolorallocate( $kep, 255, 255,   0 ) ; 

	    if( isset($_GET['ph']) )   $ph = $_GET['ph'] ;   else $ph = rand(-100,100) ;
	    if( abs(  $ph>100    ) )   $ph = 100         ;

	                         imagefilledellipse( $kep, 90,90 , 144-$korr,144-$korr ,           $szurke              ) ;		// szürke alapkör

	    if( $ph>0 )          imagefilledarc(     $kep, 90,90 , 144+$korr,144+$korr , 270, 90 , $sarga , IMG_ARC_PIE ) ;		// sárga  félkör  - növekvő  hold (jobb oldal)
	    else                 imagefilledarc(     $kep, 90,90 , 144+$korr,144+$korr ,  90,270 , $sarga , IMG_ARC_PIE ) ;		//                - csökkenő hold (bal  oldal) 

				 $sz = abs(50-abs($ph)) / 50 * 144 ;
	    if( abs($ph)>50 )    imagefilledellipse( $kep, 90,90 ,       $sz,144       ,           $sarga               ) ;		// belső ellipszis - sárga
	    else                 imagefilledellipse( $kep, 90,90 ,       $sz,144       ,           $szurke              ) ;		//                 - szükre


      imagegif( $kep ) ;
      imagedestroy( $kep ) ;
?>