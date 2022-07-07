using System;
using System.IO;

namespace blocoFinally
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = null;
            try
            {
                fs = new FileStream(@"C:\temp\data.txt", FileMode.Open);
                StreamReader sr = new StreamReader(fs);
                string line = sr.ReadLine();
                Console.WriteLine(line);
            }
            catch(FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            finally//o bloco finally executa, independe do resultado do trycatch
            {
                if(fs != null)
                {
                    fs.Close();// a função do finally aqui é finalizar o FileStream
                }
            }
        }
    }
}
