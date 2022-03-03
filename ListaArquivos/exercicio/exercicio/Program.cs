using System;
using System.IO;
using System.Collections.Generic;

namespace exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourceFile = @"c:\temp\CursoC#\ListaArquivos";
            try
            {
                var files = Directory.EnumerateFiles(sourceFile, "*.*", SearchOption.AllDirectories);

                Directory.CreateDirectory(sourceFile + @"\out");
            }
            catch(IOException e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
