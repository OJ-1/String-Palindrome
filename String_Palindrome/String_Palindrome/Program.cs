using System;

namespace String_Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string input_string = "";
            Console.WriteLine("Enter string: ");
            input_string = Console.ReadLine();

            Program obj = new Program();
            Console.WriteLine("result is: " + obj.isPalindrome(input_string));
        }

        public bool isPalindrome(string input_string)
        {
            //convert string to array of characters
            char[] inverse_char = input_string.ToCharArray();

            //reverse the string
            Array.Reverse(inverse_char);

            //place into temp string - convert into a string
            string temp_string = new string(inverse_char);

            //check condition
            bool palindrome_check = input_string.Equals(temp_string, StringComparison.OrdinalIgnoreCase);// returns true or false

            return palindrome_check;
        }

    }
}
