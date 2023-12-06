using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7
{
    class Program
    {
        
        static void Main(string[] args)
        {
            #region task 3
            //3) User ad soyad və yaşını qeyd etsin. Əgər yaşı 18dən kiçikdirsə 18 olana kimi "{name} {surname} {age} yaşınız mübarək.". Əgər 18dən böyükdürsə bir dəfə "{name} {surname} {age} yaşınız mübarək çıxsın"
            /* #region  task 3
             Console.WriteLine("adinizi daxil edin: ");
             string name = Console.ReadLine();

             Console.WriteLine("soyadinizi daxil edin: ");
             string surname = Console.ReadLine();

             Console.WriteLine("yasinizi daxil edin:");
             int age = int.Parse(Console.ReadLine());


             for (int i = 1; age <= 39; age++)
             {
                 if (age <= 18)
                 {
                     Console.WriteLine($"{name} {surname} {age} ad gununuz mubarek!!");
                 }

                 else if (age >18)
                 {
                     Console.WriteLine($"{name} {surname} {age} ad gununuz mubarek!!");
                     break;
                 }
             }*/
            #endregion

            #region task 4
            //4) User 2 rəqəm daxil etsin. Birinci ikincidən balaca olsun və hər ikisi müsbət ədəd olsun.
            /* Əgər şərt ödənməyibsə "Wrong input yazılsın.". 2 rəqəm arasında olan tək ədədlərin sayını çıxarsın. 2 rəqəm arasında olan hər hansısa rəqəm 2 - cinin yarısıdırsa həmin rəqəmi hesablamasın. 2 rəqəm arasında olan hər hansısa rəqəmin kvadratı ikinci ədəd edirsə bu zaman proses ümumiyyətlə dayansın və ekrana "Process terminated" yazısı çıxsın.*/

            /* Console.WriteLine("reqemleri daxil edin :");
             string input1 = Console.ReadLine();
             string input2 = Console.ReadLine();

             int num1 = int.Parse(input1);
             int num2 = int.Parse(input2);

             if (num1 > num2 && num1 > 0 && num2 > 0)
             {
                 Console.WriteLine("Wrong input");
             }

             int tekEdedler=0;
             for (int i = num1; i <=num2; i++)
             {

                 if (i%2!=0)
                 {
                     tekEdedler++;
                 }
                 Console.WriteLine(tekEdedler);
             }*/


            #endregion

            #region task 5

            //

            /*int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int sum = 0;

            foreach (var number in numbers)

            {
                if (number % 2 == 0)
                {
                    
                    sum += number;
                    Console.WriteLine(sum);

                }
                
            }*/


            #endregion

            #region task 6
            /*int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };

            int sum = 0;

            foreach (var number in numbers)
            {
                sum += number;

            }
            Console.WriteLine((sum) / (numbers.Length));*/


            #endregion

            #region task 7
            /*int[] numbers1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10,  };
            int[] numbers2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };

            int max1 =0 ;
            int max2 = 0;
            


            foreach (var number1 in numbers1)
            {
                if (number1>max1)
                {
                    max1 = number1;
                }
            }


            foreach (var number2 in numbers2)
            {
                if (number2 > max2)
                {
                    max2 = number2;
                }
            }
            int sum = max1 + max2;

            Console.WriteLine($"en boyuk ededlerin cemi:  {sum}");
*/

            #endregion





        }
    }
}
