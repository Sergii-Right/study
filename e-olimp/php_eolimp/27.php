<?php

$b_str = decbin(intval(trim(fgets(STDIN))));
echo $b_str;
$length = strlen($b_str);
$b_arr = str_split($b_str);
$str_arr = [];
for($i = 0, $j = $length - 1; $i < $length - 1; $i++, $j--)
{
    if($str[$j] == 1)
    {
        array_pop($b_arr);
        array_unshift($b_str,1);
    }
}
