using System;

namespace Prevpriser
{
    internal class Program
    {
        //           2-50    51-100     101-250  250+
        // indland    11       22         44      66
        //udland      33       33         66      99

        //quick       29       29         58      87
        static void Main(string[] args)
        {
            for (; ; )
            {
                int parse_check = 0;
                int replay = 0;
                Console.WriteLine("Indtast en vægt på pakken");
                String vægt_string = Console.ReadLine();
                bool vægt = int.TryParse((vægt_string),out parse_check);
                if (parse_check > 0 && vægt == true)
                {
                    for (; replay < 1; replay++)
                    {
                        Console.WriteLine("Er pakken til udlandet? Indtast (ja) eller (nej)");
                        String ind_eller_ud = Console.ReadLine();
                        if (ind_eller_ud == "ja")
                        {
                            if (parse_check <= 100)
                                Console.WriteLine("33.kr\r\n");
                            else if (parse_check <= 250)
                                Console.WriteLine("66.kr\r\n");
                            else if (parse_check > 250)
                                Console.WriteLine("99.kr\r\n");
                        }
                        else if (ind_eller_ud == "nej")
                        {
                            Console.WriteLine("Ved pakker over 100kg bruges der Quickpakker");
                            if (parse_check <= 50)
                                Console.WriteLine("11.kr\r\n");
                            else if (parse_check <= 100)
                                Console.WriteLine("22.kr\r\n");
                            else if (parse_check <= 250)
                                Console.WriteLine("58.kr ved brug af Quickpakker\r\n");
                            else if (parse_check > 250)
                                Console.WriteLine("87.kr ved brug af Quickpakker\r\n");
                        }
                        else
                        {
                            Console.WriteLine("(Ugyldigt input)");
                            replay--;
                        }
                    }
                    
                }
                else
                    Console.WriteLine("(Ugyldigt input)");
            }
                
            
        }
    }
}