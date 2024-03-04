using System;

namespace Problem1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a few words seperated by a space");
            var UserInput = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(UserInput))
            {
                Console.WriteLine("You have not entered any text");
                return;
            }
            var PascalString = ConvertToPascalCase(UserInput);
            Console.WriteLine("Pascal String is: {0}", PascalString);

        }

        //Returns Pascal String
        public static string ConvertToPascalCase(string sentence)
        {
            string result = "";

            foreach (var word in sentence.Split(' ')) //split the input string into array of string based on whitespace
            {
                string UpperFirstChar = char.ToUpper(word[0]) + word.ToLower().Substring(1); //Converting the first letter of the word to Upper case and rest to lower case

                result += UpperFirstChar; 
            }

            return result;
        }
    }
}
