using System;
using System.IO;

namespace CursoCSharp.API
{
    class ExemploDirectoryInfo
    {
        public static void Executar()
        {
            var dir_projeto = @"~/source/repos/CursoCSharp/CursoCSharp".ParseHome();
            var dirInfo = new DirectoryInfo(dir_projeto);

            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }

            Console.WriteLine(" ========== ARQUIVOS ========== ");
            var arquivos = dirInfo.GetFiles();
            foreach(var arq in arquivos)
            {
                Console.WriteLine(arq);
            }

            Console.WriteLine("\n\n ========== DIRETÓRIOS ========== ");
            var pastas = dirInfo.GetDirectories();
            foreach (var pasta in pastas)
            {
                Console.WriteLine(pasta);
            }

            Console.WriteLine(" \n"+  dirInfo.CreationTime);
            Console.WriteLine(dirInfo.FullName);
            Console.WriteLine(dirInfo.Root);
            Console.WriteLine(dirInfo.Parent);
            Console.WriteLine(dirInfo.Parent.Parent);

        }
    }
}
