<?php

$age = 27;
$name = 'Fabio';

// && = and, or = ||
if ($age > 18 or $name == 'fabio') echo 'texto' . PHP_EOL;

$messagem = $name == 'Fabio' ? 'é o fabio' : 'não é o fabio';

echo $messagem . PHP_EOL;