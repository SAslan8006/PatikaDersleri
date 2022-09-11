using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main()
        {
            // keep this function call here
            Console.WriteLine(StringReduction(Console.ReadLine()));
        }

        public static int StringReduction(string str)
        {
            if (str.Length == 1)
                return 1;
            else
            {
                int prevAns = str.Length;
                int newAns = 0;

                while (prevAns != newAns)
                {
                    prevAns = newAns;
                    string ansStr = string.Empty;
                    int i = 1;
                    int j = 0;
                    while (i < str.Length)
                    {
                        if (str[i] != str[j])
                        {
                            if (str[i] != 'a' && str[j] != 'a')
                            {
                                ansStr += 'a';
                            }
                            else if (str[i] != 'b' && str[j] != 'b')
                            {
                                ansStr += 'b';
                            }
                            else if (str[i] != 'c' && str[j] != 'c')
                            {
                                ansStr += 'c';
                            }

                            i += 2;
                            j += 2;
                        }
                        else
                        {
                            ansStr += str[j];
                            i++;
                            j++;
                        }
                    }

                    if (j < str.Length)
                    {
                        ansStr += str[j];
                    }

                    str = ansStr;
                    newAns = ansStr.Length;
                }
 
                return newAns;
            }
        }
    }
}
