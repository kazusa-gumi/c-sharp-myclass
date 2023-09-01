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
            List<string> myList = new List<string>();
            myList.Add("Mon");
            myList.Add("Tue");
            myList.Add("aWeb");

            foreach(string s in myList)
            {
                Console.WriteLine(s);
            }

            myList.Remove("Tue");

            foreach (string s in myList)
            {
                Console.WriteLine(s);
            }

            myList.Sort();
            foreach (string s in myList)
            {
                Console.WriteLine(s);
            }
        }
    }
}