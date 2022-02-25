using System;
using System.IO;

namespace Sentencias
{
    class SentenciaUsing
    {
        public static void Main (string[] args)
        {
            string s;

            using (TextWriter w = File.CreateText("log.txt"))
            {
                w.WriteLine("linea uno");
                w.WriteLine("linea dos");
            }

            using (TextReader reader=File.OpenText("lon.txt"))
            {
                while((s=reader.ReadLine()) !=null)
                {
                    Console.WriteLine(s);
                }
            }
        }
    }
}

