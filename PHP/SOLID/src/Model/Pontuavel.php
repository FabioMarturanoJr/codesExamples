<?php

namespace Alura\Solid\Model;

interface Pontuavel
{
    public function recuperarPonturacao(): int;
    public function assistir(): void;
}