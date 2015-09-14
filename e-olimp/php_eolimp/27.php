<?php
$b_str = decbin(intval(trim(fgets(STDIN))));
$length = strlen($b_str);
$b_arr = str_split($b_str);
for($i = 0; $i < $length - 1; $i++)
{
    if($b_arr[$length - 1] == 1)
    {
        array_pop($b_arr);
        array_unshift($b_arr,1);
    }
    else
    {
        break;
    }
}

echo bindec(implode($b_arr));