
using System;
using System.Collections.Generic;



namespace Permutations
{
    public class Program
    {

        static IList<string> Permute(int num)
        {
            string numsChar = "";
            for (int i = 0; i < num; i++)
                numsChar += i + 1;

            var list = new List<string>();
            return DoPermute(numsChar, "", list);

        }



        static IList<string> DoPermute(String s, String answer, IList<string> list)
        {

            if (s.Length == 0)
            {

                list.Add(answer);

            }

            else
            {

                for (int i = 0; i < s.Length; i++)
                {

                    char ch = s[i];

                    String left_substr = s.Substring(0, i);

                    String right_substr = s.Substring(i + 1);

                    String rest = left_substr + right_substr;

                    DoPermute(rest, answer + ch, list);

                }

            }

            return list;

        }

        static string ResultInPosition(IList<string> list, int position)
        {

            //for test print all list

            //Console.WriteLine("[");

            //foreach (var item in list)

            //{

            //    Console.WriteLine($"    [{string.Join(',', item)}]");

            //}

            //Console.WriteLine("]");



            //Console.WriteLine($" position {position}  [{string.Join(',', list[position - 1])}]");

            return list[position - 1];

        }

        public static void Main(String[] args)
        {
            //var result = ResultInPosition(Permute(4), 24);
            var result = ResultInPosition(Permute(3), 2);

            Console.WriteLine(result);

        }

    }



}

