<?php
/**
 * Created by PhpStorm.
 * User: SRigh
 * Date: 11.09.2015
 * Time: 13:18
 */
class Token
{
    public $tokenId = ["number"=>'number', 'operator'=>'operator','unknown'=>'unknown','end'=>'end'];
    public $text = " ";
    public $id = ['end'=>'end'];

    public function __constructor()
    {
        $this->text = "";
        $this->id = $this->tokenId['end'];
    }
}