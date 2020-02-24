using System;

namespace Problems
{
    public class Program
    {
         public String Prefix(String input){
        String leninput = Convert.ToString(input.Length);
        String [] words = input.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
        String wlen = Convert.ToString(words.Length);
        return leninput+","+wlen+":"+input;

        }
        static void Main(string[] args)
        {
            String input = Console.ReadLine();
            Program p = new Program();
            String result = p.Prefix(input);
            Console.WriteLine(result);
        }
    }
}
