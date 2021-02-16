using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstingCsharpapp
{
    class Program
    {
        public void osta_piletid(int[] nums)
        {
            for (int i = 0; i < nums.GetLength(0); i++)
            {
                Console.Write(nums[i]);
            }
        }
        public void vabad_piletid(int[,] nums)
        {
            for (int i = 0; i < nums.GetLength(0); i++)
            {
                for (int j = 0; j < nums.GetLength(1); j++)
                {
                    nums[i, j] = 0;
                    Console.Write(nums[i, j]);
                }
                Console.WriteLine();
            }

        }
        static void Main(string[] args)
        {
            int[,] nums = new int[4, 7];
            ConsoleKeyInfo nupp = new ConsoleKeyInfo();
            Program prog = new Program();
            prog.vabad_piletid(nums);

            do
            {
                Console.Write("Vali rida: ");
                int rida = Convert.ToInt32(Console.ReadLine()) - 1;
                Console.Write("Vali koht: ");
                int koht = Convert.ToInt32(Console.ReadLine()) - 1;
                if (nums[rida, koht] == 0)
                {
                    Console.WriteLine("Koht on vaba!");
                    nums[rida, koht] = 1;
                    for (int i = 0; i < nums.GetLength(0); i++)
                    {
                        for (int j = 0; j < nums.GetLength(1); j++)
                        {
                            nums[i, j] = 0;
                            Console.Write(nums[i, j]);
                        }
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("Koht on kinni! Vali teine koht");
                }
                nupp = Console.ReadKey();
            } while (nupp.Key != ConsoleKey.Escape);

            string[] texts = new string[4];
            for (int i = 0; i < texts.GetLength(0); i++)
            {
                Console.WriteLine("{0}-text", (i + 1).ToString());
                texts[i] = Console.ReadLine();
            }
            foreach (int item in texts)
            {
                Console.WriteLine(item + ' ');
            }

            int[] numbers = new int[5] { 1, 2, 3, 4, 5 };
            Console.WriteLine(numbers[1]);
            foreach (int item in numbers)
            {
                Console.Write(item + ' ');
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + '_');
            }
            int a_ = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int z = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("a={0}, b={1}, z={2}", a_, b, z);
            double c = (a_ * a_ + z) / (11 * a_ - 13 * b);
            Console.WriteLine("c={0}", c.ToString());

            Random rnd = new Random();
            int hinne = rnd.Next(1, 7);
            Console.WriteLine("Hinne: {0}", hinne);
            Console.ReadLine();
            string tekst = "???";
            switch (hinne)
            {
                case 1: tekst = " Õpi veel! "; break;
                case 2: tekst = " Õpi natuke veel! "; break;
                case 3: tekst = " Rahuldav! "; break;
                case 4: tekst = " Heal! "; break;
                case 5: tekst = " Väga Heal! "; break;
                default:
                    tekst = " Viga! ";
                    break;
            }
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();
            Console.WriteLine(tekst);
            do
            {
                Console.WriteLine("Vajuta Backspace");
                nupp = Console.ReadKey();

            } while (nupp.Key != ConsoleKey.Backspace);

            Console.ReadLine();
            Console.WriteLine("Töö failidega: ");
            string a;
            Console.WriteLine("Y-on vaja salvestada failisse");
            Console.WriteLine("N-on vaja lugeda failist");
            nupp = Console.ReadKey();
            if (nupp.Key == ConsoleKey.Y)
            {
                StreamWriter file = new StreamWriter(@"..\..\texts.txt", true);
                file.WriteLine(hinne + " ", tekst);
                file.Close();
                a = hinne + "" + tekst;
                Console.WriteLine("Failisse oli salvestatud: {0} ", a);
            }
            else if (nupp.Key == ConsoleKey.N)
            {
                Console.WriteLine("Failis on järgmine informatsion: ");
                StreamReader filist = new StreamReader(@"..\..\texts.txt");
                a = filist.ReadToEnd();
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine("Puhkame");
            }

            Console.ReadLine();
        }
    }
}
