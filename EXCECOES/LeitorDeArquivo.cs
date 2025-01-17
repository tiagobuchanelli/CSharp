﻿using System;
using System.IO;

namespace EXCECOES
{
    public class LeitorDeArquivo : IDisposable
    {
        public string Arquivo { get; }

        public LeitorDeArquivo(string arquivo)
        {
            Arquivo = arquivo;

            //throw new FileNotFoundException();

            Console.WriteLine("Abrindo arquivo: " + arquivo);
        }

        public string LerProximaLinha()
        {
            Console.WriteLine("lendo linha...");


            throw new IOException();

            return "Linha do arquivo";
        }

        public void Fechar()
        {
            Console.WriteLine("Fechando Arquivo");
        }

        public void Dispose()
        {
            Console.WriteLine("Fechando Arquivo - Dispose");
        }
    }
}
