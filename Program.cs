
using System;
using System.Collections.Generic;



namespace Permutations
{
    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        var result = ResultInPosition(
    //            //Permute(4), 24);
    //            //Permute(3), 2);
    //           Permute(5), 2);

    //        Console.WriteLine(string.Join(',', result));
    //    }

    //    static IList<IList<int>> Permute(int num)
    //    {
    //        int[] nums = new int[num];
    //        for (int i = 0; i < nums.Length; i++)
    //            nums[i] = i + 1;

    //        var list = new List<IList<int>>();
    //        return DoPermute(nums, 0, nums.Length - 1, list);

    //    }



    //    static IList<IList<int>> DoPermute(int[] nums, int start, int end, IList<IList<int>> list)
    //    {
    //        if (start == end)
    //        {
    //            // We have one of our possible n! solutions,

    //            // add it to the list.
    //            list.Add(new List<int>(nums));

    //        }

    //        else
    //        {

    //            for (var i = start; i <= end; i++)
    //            {
    //                Swap(ref nums[start], ref nums[i]);
    //                DoPermute(nums, start + 1, end, list);
    //                Swap(ref nums[start], ref nums[i]);

    //            }

    //        }

    //        return list;

    //    }



    //    static void Swap(ref int a, ref int b)
    //    {
    //        var temp = a;
    //        a = b;
    //        b = temp;
    //    }



    //    static IList<int> ResultInPosition(IList<IList<int>> lists, int position)
    //    {

    //        //for test print all list
    //        Console.WriteLine("[");
    //        foreach (var list in lists)
    //        {
    //            Console.WriteLine($"    [{string.Join(',', list)}]");
    //        }

    //        Console.WriteLine("]");
    //        Console.WriteLine($" position {position}  [{string.Join(',', lists[position - 1])}]");

    //        return lists[position - 1];

    //    }

    //}


    // C# program to implement

    // the above approach

    using System;

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


        // Driver code
        public static void Main(String[] args)
        {

            //var result = ResultInPosition(Permute(4), 24);
            var result = ResultInPosition(Permute(3), 2);

            Console.WriteLine(result);

        }

    }



}

