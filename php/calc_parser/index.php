<?php
/**
 * Created by PhpStorm.
 * User: SRigh
 * Date: 11.09.2015
 * Time: 13:01
 */

$obj = new stdClass();
$obj->text = "text";
$obj->id = 1;

$ar[] = $obj;

$obj = new stdClass();
$obj->text = "text_2";
$obj->id = 2;

$ar[] = $obj;


print_r($ar);