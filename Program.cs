using System;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Solution();
            // var e136 = s.SingleNumber(new int[] { 4, 2, 1, 3, 2, 3, 1 });

            var e125 = s.IsPalindrome("A man, a plan, a canal: Panama");
            Console.WriteLine(e125);
        }
    }
}