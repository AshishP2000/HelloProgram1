using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestHelloWorldProject.Basic_Programs
{
    public class ReverseWord
    {
        public static void ReadInput()
        {
            Console.WriteLine("Provide some word to make Reverse: ");
            String Word = Console.ReadLine();
            FindReverseword(Word);
        }
        public static void FindReverseword(String word)
        {
            String reverse = "";
            int n = 0;
            char[] chars = word.ToCharArray();
            n = chars.Length;
            //Console.WriteLine(chars);
            for (int i = 0; i < chars.Length; i++)
            {
                Console.Write(chars[i]); 
                
            }
            Console.WriteLine();
            for (int i = n-1; i >= 0; i--)
            {
                Console.Write(chars[i]);
                reverse = reverse + chars[i];
            }
            Console.WriteLine();
            Console.WriteLine(reverse);
        }
    }
}
