using System;
using System.IO;

namespace CursoCSharp.API
{
    class Diretorios
    {
        public static void Executar()
        {
            var novoDir = @"~/PastaTesteCSharp".ParseHome();
            var novoDirDestino = @"~/PastaTesteCSharp_Destino".ParseHome();
            var dir_projeto = @"~/source/repos/CursoCSharp/CursoCSharp".ParseHome();

            if (Directory.Exists(novoDir))
            {
                Directory.Delete(novoDir, true);
            }

            if (Directory.Exists(novoDirDestino))
            {
                Directory.Delete(novoDirDestino, true);
            }

            Directory.CreateDirectory(novoDir);
            Console.WriteLine(Directory.GetCreationTime(novoDir));

            Console.WriteLine(" ========= PASTAS ========= ");
            var pastas = Directory.GetDirectories(dir_projeto);
            foreach (var dir in pastas)
            {
                Console.WriteLine(dir);
            }

            Console.WriteLine("\n\n ========= ARQUIVOS =========");
            var arquivos = Directory.GetFiles(dir_projeto);
            foreach(var arq in arquivos)
            {
                Console.WriteLine(arq);
            }
            
            Console.WriteLine("\n\n ========= RAIZ =========");
            Console.WriteLine(Directory.GetDirectoryRoot(novoDir));

            Directory.Move(novoDir, novoDirDestino);
        }
    }
}
