using System;      // Namespace for String calss
using System.Text; // Namespace for StringBilder calss
using System.Collections.Generic;
using System.Linq;

using System.Threading.Tasks;

namespace Console_String_vs_StringBuilder
{
    class Program
    {     
        static void Main(string[] args)
        {
            StringClass.StringClass_Methods();
            StringBuilderClass.StringBuilderClass_Methods();
            Console.ReadLine();
        }
    }

    
    static class StringClass   //---------- String Class
    {
        public static void StringClass_Methods()
        {
            string str1 = "This is a sample text";
            string str2 = @"The path c:\myfolder\";
            string str3 = "The path c:\\myfolder";

            char[] mychar = { 'R', 'E', 'Z', 'A' };
            string str4 = new string(mychar);

            string str5 = new string('c', 5);

            Console.WriteLine(str1);
            Console.WriteLine(str2);
            Console.WriteLine(str3);
            Console.WriteLine(str4);
            Console.WriteLine(str5);
            Console.WriteLine("\n");


            string strTxt = "Hello Microsoft C# Developer";
            Console.WriteLine("The length:",strTxt.Length);
            Console.WriteLine(strTxt.Substring(6,12));
            Console.WriteLine(strTxt.Replace(strTxt,"Hello Reza")); 
            Console.WriteLine(strTxt.IndexOf('C'));      // retrun location of char/string on string (0 base array)
            Console.WriteLine(strTxt.IndexOf("Reza"));   //-1 means not found

            Console.WriteLine("\n");

            strTxt = strTxt.Replace(strTxt,"This is an alternative strTxt");
            Console.WriteLine(strTxt);

            Console.WriteLine("\n");

            double dollar = 1.5;
            Console.WriteLine("Current Time is {0:t} and Current Date is {0:D} and Each 10.000 Rial is {1:C1}", DateTime.Now,dollar);

            Console.WriteLine("\n");

            Console.Write("Enter a string:");
            string input= Console.ReadLine();
            if (String.IsNullOrEmpty(input))
                Console.WriteLine("You didn't enter anything : {0}",string.Empty);        
            else if (string.IsNullOrWhiteSpace(input))

                Console.WriteLine("You entered empty space : {0}",input.Trim());
            else
                Console.WriteLine("You entered : {0}", input);

        }
    }

    static class StringBuilderClass   //---------- StringBuilder Class
    {
        public static void StringBuilderClass_Methods()
        {
            StringBuilder stringBuilderObj = new StringBuilder();

            StringBuilder stringBuilderObj2 = new StringBuilder(5);   // make StringBuilder Object with this starter capacity

            StringBuilder stringBuilderObj3 = new StringBuilder(2,50); // make StringBuilder Object with this starter capacity and Limited to this MaxCapacity


            stringBuilderObj.Append("Hello");
            stringBuilderObj2.Append("This is a sample sentence");
            stringBuilderObj3.Append("This is a text with length of less than 50 char");  // Error : Tex length > Max defined capacity is 5 

            Console.WriteLine("The Maximum defined capacity is:{0}", stringBuilderObj3.MaxCapacity);  // Print defiend MaxCapacity of this instance

            Console.WriteLine("\n");

            Console.WriteLine(stringBuilderObj);
            Console.WriteLine(stringBuilderObj2);
            Console.WriteLine(stringBuilderObj3);

        }
    }
 }
