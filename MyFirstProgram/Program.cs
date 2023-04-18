using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            /** Console.WriteLine("I like pizza!");
             Console.WriteLine("It's really good!");
             Console.WriteLine("Test");**/
            //This is a comment

            /***
             multiline comment
             */

            /** Console.WriteLine("\tRanveerAncharaz"); add a tab space
             Console.WriteLine("\tRanveer\bAncharaz"); add a backspace
             Console.WriteLine("\tRanveer\b \nAncharaz"); breakline

             Console.ReadKey(); remove excess in console
            
             **/



            //variable part

            /** int x; 
             x = 333;  
             int y = 321;
             int z = x + y;

             Console.WriteLine(x);
             Console.WriteLine(y);
             Console.WriteLine(z);


             int age = 33;
             Console.WriteLine("Your age is " + age);

             **/

            //VARIABLE

            //int age = 33;
            //double height = 5.6; //decimal
            //bool alive = false; //true or false
            //char symbol = '@'; //single caracter
            //string name = "Ranveer";
            //String userName = symbol + name;

            /**

            Console.WriteLine("My age is " + age + "My height is " + height);
            Console.WriteLine("Are you alive ? -> " + alive);
            Console.WriteLine("Your symbol is " + symbol);
            Console.WriteLine("Your username is " + userName);
            Console.ReadKey();
            **/


            //csharp has const to so that the variable is not mutable or change 
           //const double pi = 3.141;
            

            //int c = 123;
            //double d = Convert.ToDouble(c) + 0.1;
            //Console.WriteLine(d.GetType());


           // int e = 132;
            //string f = Convert.ToString(e);



            //String g = "$";
            //char h = Convert.ToChar(g);
    


            // String i = "true";
           // bool j = Convert.ToBoolean(i);
 
            //remove decimal rounded
           // double a = 3.141;
            //int b = Convert.ToInt32(a);
            // Console.WriteLine(a.GetType());  get type know the type bool double int char
            // Console.WriteLine(pi);
            // Console.WriteLine(h);
            // Console.WriteLine(h.GetType());
            // Console.WriteLine(f);
            // Console.WriteLine(f.GetType());
            //Console.WriteLine(j.GetType());

            //USER INPUT
            // Console.WriteLine("What's your name ?");
            //String name = Console.ReadLine();

            //Console.WriteLine("What's your age ?");
           // int age = Convert.ToInt32(Console.ReadLine());


            // Console.WriteLine("Hello " + name + "!" + " So you are " + age + " years old, innit ?");


            int friends = 10;

            /*friends = friends += 5;
           friends++;*/

            //Console.WriteLine(friends);

            /* friends = friends -= 1;
             friends -= 1;
             friends--;*/


            //friends = friends * 2;
            // friends *= 2;
            //friends /= 2;
            //friends = friends / 2;

            //int remainder = friends % 3;

            //Console.WriteLine(remainder);




            // double x = 3.99;
            //double y = 5;


            // double a = Math.Pow(x, 2);
            //double a = Math.Sqrt(x);
            //double a = Math.Abs(x);
            //double a = Math.Ceiling(x);
            //double a = Math.Floor(x);
            //double a = Math.Round(x);
            //double a = Math.Max(x, y);
            //double a = Math.Min(x, y);

            //Console.WriteLine(a);

            
            
            
            
            //generate random numbers
            Random random = new Random();
            //between 1 being the minima, 6 being the maximum
            int num1 = random.Next(1,21);
            int num2 = random.Next(1, 21);
            int num3 = random.Next(1, 21);
            
            //double num = random.NextDouble(); //double decimal
            
            
            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine(num3);

            Console.ReadKey();










}
}
}