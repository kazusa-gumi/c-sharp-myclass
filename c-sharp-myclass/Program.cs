using System;
// 名前空間
namespace HelloWorld
{

    // クラス
    class Program
    {
        // メソッド
        static void Main(string[] args)
        {
            // while文
            int i = 0;
            int j = 3;
            while (i < j)
            {
                int MyInt1 = Convert.ToInt32(Console.ReadLine());
                int MyInt2 = Convert.ToInt32(Console.ReadLine());

                int Result = MyInt1 + MyInt2;
                switch (Result)
                {
                    case 10:
                        Console.WriteLine("The number is 10");
                        break;
                    case 12:
                        Console.WriteLine("The number is 12");
                        break;

                    default:
                        Console.WriteLine("The number is not found, Try Again!");
                     break;
                }

                Console.WriteLine("The Sum = " + Result);
                i++;
            }
            // for文
         
                //int MyInt1 = Convert.ToInt32(Console.ReadLine());
                //int MyInt2 = Convert.ToInt32(Console.ReadLine());

                //int Result = MyInt1 + MyInt2;

                //if (Result == 10) // if yes will print found,
                // if no will jump to not found message


                //{
                //    Console.WriteLine("We found the sum = " + Result);
                //    Console.WriteLine("Break");
                //    // stop the loop
                //    break;
                //}
                //else
                //{
                //    Console.WriteLine("The number is not found, Try Again!");
                //}

                // like a door
                

                
            

            
        }
    }
}