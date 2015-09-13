<?php
/**
 * Created by PhpStorm.
 * User: SRigh
 * Date: 13.09.2015
 * Time: 13:29
 */
include "Lexer.php";


$l = new Lexer();
$i = $l->Lex("1111+2-3/4* 5");
//print_r($i);

