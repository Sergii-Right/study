                                                                                                                                         <?php

$str = trim(fgets(STDIN));
$length = strlen($str);

$iter = 0;
for($i = 0, $j = $length - 1; $i < $length / 2; $i++, $j--)
{
    if(strcmp($str[$i],$str[$j]) == 0)
    {
        $iter++;
    }
}
echo $iter;