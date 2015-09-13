<?php
include "ILexer.php";
include "Token.php";
/**
 * Created by PhpStorm.
 * User: SRigh
 * Date: 11.09.2015
 * Time: 13:02
 */

class Lexer implements ILexer
{
    private $operators = ["$","+", "-", "*", "/", "^", "(", ")"];
    public static $TokenList = array();

    public function Lex($str)
    {
        $iter = 0;
        while(true)
        {
            while($iter < strlen($str) && $str[$iter] == " ")
                $iter++;
            $token = new Token();
            if($iter >= strlen($str))
            {
                $TokenList[] = $token;
                break;
            }
            elseif(is_numeric($str[$iter]))
            {
                while($iter < strlen($str) && is_numeric($str[$iter]))
                {
                    $token->text .= $str[$iter++];
                    $token->id = $token->tokenId['number'];
                }
            }
            else
            {
                $token->text = $str[$iter++];
                if(array_search($token->text,$this->operators))
                    $token->id = $token->tokenId['operator'];
                else
                    $token->id = $token->tokenId['unknown'];
            }
            self::$TokenList[] = $token;
        }
//        print_r($TokenList);
        return self::$TokenList;
    }
}
