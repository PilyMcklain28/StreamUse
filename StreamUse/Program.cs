using System;

namespace program 
{
    public class program
    {
        public static void Main(string[] args) 
        {           
                using (Stream fs = new FileStream("./archivo.txt", FileMode.Append, FileAccess.Write))
                {
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        sw.WriteLine("Hola, es mi primera vez manejando ficheros...");

                    }
                                        
                }
         Console.ReadKey();
        }
    }
}