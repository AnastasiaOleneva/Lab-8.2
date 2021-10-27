using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab_8._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "Log/Log.txt";

            if (Directory.Exists(path))
            {

                File.Create(path);
            }
            using (StreamWriter sw = new StreamWriter(path))
            {
                Random rnd = new Random();
                for (int i = 1; i <= 10; i++)
                {
                    sw.WriteLine(rnd.Next(100));

                }


            }
            using (StreamReader sr = new StreamReader(path))
            {
                int sum = 0;
                
                while (sr.Peek()>-1)
                {
                    int number = Convert.ToInt32(sr.ReadLine());

                    sum += number;
                }


                Console.WriteLine("сумма чисел равна {0}",sum);
         
            }

            Console.ReadKey();



        }
    }
}
