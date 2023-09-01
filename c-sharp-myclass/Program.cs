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
            string[] MyArray = { "Mon", "Tue", "Web" };
            //for(int i =0; i < MyArray.Length; i++)
            //{
            //    Console.WriteLine(MyArray[i]);
            //}

            // foreach文
            // 配列の要素１つ１つを取り出して表示しているイメージかな。
            foreach(var item in MyArray) {
                Console.WriteLine(item);
            }
        }
    }
}