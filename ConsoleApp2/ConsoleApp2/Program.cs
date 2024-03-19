using System;

namespace ConsoleApp2 {

    class Program {


        static void Main() {

            //float user_num;

            //Console.WriteLine("Введите десятичное число для проверки");
            //// user_num = Convert.ToDouble(Console.ReadLine());
            //float user_num = float.Parse(Console.ReadLine());
            
            //Console.WriteLine("Вы ввели " + user_num);


            //float result = user_num + 10f;

            //Console.WriteLine(result);



            //Console.WriteLine(Math.PI);
            //Console.WriteLine(Math.Abs(-20));
            //получаю данные



            short user_input = Convert.ToInt16(Console.ReadLine());

            switch(user_input)
            {
                case 0: 
                    Console.WriteLine("Number is 0");
                    break;
                case 1:
                    Console.WriteLine("Number is 1");
                    break;
                case 100:
                    Console.WriteLine("Number is 100");
                    break;
                case 155:
                    Console.WriteLine("Number is 155");
                    break;
                default:    
                    Console.WriteLine("Number is unreggular");
                    break;

            }

            for(short i = user_input; i <= 25; i++)
            {
                Console.WriteLine("Element: {0}", i);
            }




            Console.ReadKey();
        }

    }

}