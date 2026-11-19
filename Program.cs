using System.Text.RegularExpressions;

namespace תרגיל_6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string str = "0548517233";
            string str1 = "abc5";
            string str2 = "color";
            string str3 = "aaa";
            string str4 = "123mkj";
            string str5 = "dog";
            string str6 = "dog@.com";
            string str7 = "jjj             jjj   kkk";
            string str8 = "hhuAS67789GRF5D";
            if (string.IsNullOrWhiteSpace(str))
            {
                Console.WriteLine("Please enter a valid phone number");
                return;
            }
            Regex rgx = new Regex(@"^05\d{8}$");
            if (rgx.IsMatch(str))
            {
                Console.WriteLine("Valid phone number");
            }
            else
            {
                Console.WriteLine("Invalid phone number");
            }
            if (string.IsNullOrWhiteSpace(str1))
            {
                Console.WriteLine("Please enter a string");
                return;
            }
            Regex rgx1 = new Regex(@"^abc[a-zA-Z]*\d+$");
            if (rgx1.IsMatch(str1))
            {
                Console.WriteLine("Valid string");
            }
            else
            {
                Console.WriteLine("Invalid string");
            }
            if (string.IsNullOrWhiteSpace(str2))
            {
                Console.WriteLine("Please enter a string");
                return;
            }
            Regex rgx2 = new Regex(@"^(color|calar$)");
            if (rgx2.IsMatch(str2))
            {
                Console.WriteLine("Valid string");
            }
            else
            {
                Console.WriteLine("Invalid string");
            }
            if (string.IsNullOrWhiteSpace(str3))
            {
                Console.WriteLine("Please enter a string");
                return;
            }
            Regex rgx3 = new Regex(@"^[aeiou]*$");
            if (rgx3.IsMatch(str3))
            {
                Console.WriteLine("Valid string");
            }
            else
            {
                Console.WriteLine("Invalid string");
            }
            if (string.IsNullOrWhiteSpace(str4))
            {
                Console.WriteLine("Please enter a string");
                return;
            }
            Regex rgx4 = new Regex(@"^\w{6,10}$");
            if (rgx4.IsMatch(str4))
            {
                Console.WriteLine("Valid string");
            }
            else
            {
                Console.WriteLine("Invalid string");
            }
            if (string.IsNullOrWhiteSpace(str5))
            {
                Console.WriteLine("Please enter a string");
                return;
            }
            Regex rgx5 = new Regex(@"^(cat|dog$)");
            if (rgx5.IsMatch(str5))
            {
                Console.WriteLine("Valid string");
            }
            else
            {
                Console.WriteLine("Invalid string");
            }
            if (string.IsNullOrWhiteSpace(str6))
            {
                Console.WriteLine("Please enter a string");
                return;
            }
            Regex rgx6 = new Regex(@"^\w+@(.co.il|.com)$");
            if (rgx6.IsMatch(str6))
            {
                Console.WriteLine("Valid email address");
            }
            else
            {
                Console.WriteLine("Invalid email address");
            }
            if (string.IsNullOrWhiteSpace(str7))
            {
                Console.WriteLine("Please enter a string");
                return;
            }
            else
            {
                string rpls = Regex.Replace(str7, @"\s+", " ");
                Console.WriteLine(rpls);
            }
            if (string.IsNullOrWhiteSpace(str8))
            {
                Console.WriteLine("Please enter a string");
                return;
            }
            string[] arr = Regex.Split(str8, @"[a-zA-Z]");
            for (int i = 0; i<arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
           
    }
}
