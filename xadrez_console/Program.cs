﻿using System;
using tabuleiro;
using xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            
            PartidaDeXadrez partida = new PartidaDeXadrez();

                while (!partida.terminada)
                {
                    try
                    {

                    Console.Clear();
                    Tela.imprimirPartida(partida);
                    Console.Write("Origem: ");
                    Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
                    partida.validarPosOrigem(origem);
                    Console.Clear();
                    bool[,] posicoesPossiveis = partida.tab.peca(origem).movimentosPossiveis();

                    Tela.imprimirTabuleiro(partida.tab, posicoesPossiveis);

                    Console.WriteLine();

                    Console.Write("Destino: ");
                    Posicao destino = Tela.lerPosicaoXadrez().toPosicao();
                    partida.validarPosDestino(origem, destino);

                    partida.realizaJogada(origem, destino);
                    }
                    catch(TabuleiroException e)
                    {
                        Console.WriteLine(e.Message);
                        Console.ReadLine();
                    }
                Console.Clear();
                Tela.imprimirPartida(partida);
                }


            Console.WriteLine();
        }
    }
}

