using System;

namespace VariablesConsule
{
    class Program
    {
        static void Main(string[] args)
        {

            string dogName = "Ralph";
            int dogAge = 10;
            char nickName = 'R';
            bool lovesBall = true;
            double basketBalls = 33;
            decimal weight = 50.7m;

         
            Console.WriteLine($"My dog's name is {dogName}, He is {dogAge} years old and he has {basketBalls} basketballs and it is {lovesBall} that he loves to play ball which keeps him healthy at his {weight} ");

            if (lovesBall == true)
            {
                Console.WriteLine($"{dogName} loves playing ball");
            }
            else
                Console.WriteLine($"{dogName} hates playing ball");

        }
    }
}
