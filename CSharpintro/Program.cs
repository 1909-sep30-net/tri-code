using System;

namespace CSharpIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Make bool, string, and int variables with vals
            bool boo = false;
            string s = "nyet";
            int i = 5;

            //change thier values to someting else
            boo = true;
            s = "da";
            i = 10;
            
            //print their values with consle
            Console.WriteLine(boo);
            Console.WriteLine(s);
            Console.WriteLine(i);

            //do something in a for loop
            for(int i1 = 0; i1 < 5; i1++){
                Console.WriteLine("privyet");
            }

            //do something in while loop
            int w = 0;
            while(w < 3){
                Console.WriteLine("lightweight");
                w++;
            }

            //do something with a switch statment 
            int number = 3;

            switch(number){
                case 1:
                    Console.WriteLine("Number 1");
                    break;
                case 2:
                    Console.WriteLine("Number 2");
                    break;
                case 3:
                    Console.WriteLine("Number 3");
                    break;
                default: 
                    Console.WriteLine("No number");
                    break;        

            }

            //do something with if, else if, else
            int condition = 100;

            if(condition > 70){
                Console.WriteLine("if success");
            }

            else if (condition == 100){
                Console.WriteLine("else if success");
            }
            else{
                Console.WriteLine("else ");
            }

            //figure out how to make multi-line comments in C#

            /* WOOOOO
            Successful
             */

            //figure out how to fomrat your docuent in VS COde

            //extra : make new static method to do something and call it
            static string Quote(string s){
                return "/" + s + "/";
            }

            //string interpolation syntax: return $"|"{s}"|";
            Console .WriteLine(Quote("Cheese"));



            //extra: learn what var means in C# amd try it
            var v1 = "v1";
            var v2 = 4.5;
        }
    }
}
