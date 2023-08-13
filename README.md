# c-sharp-myclass　C#自己学習用のリポジトリ

git のコミっトの仕方
①リモートにあるやつをローカルに持ってくる時
git clone utl　でローカルにリモートの内容をcloneしてあげる。
変更したいことを修正
そのディレクトリの中でターミナルで git initをやる
git add . で全てのファイルをステージングへあげる
git commit -m メッセージでコミットする
できたら、git branch -M mainをする。（masterではなく、mainにpush.ブランチ切って作業する時はそれでもおけ）
git push -u origin main
でpushできます。

①ローカルにあるやつをリモートへpushしたい時
いつも通り、作業ふぁいるなどを作成します
リモートリポジトリも作成する(gitで）
git init      
git add . 
git commit -m メッセージ
git branch -M main         
git remote add origin url
git push -u origin main


でOK！！！


2023.08/06　メモ 以下ノート箇所

```
// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


//Console.WriteLine("文字を入力してください");
//string input = Console.ReadLine();
//Console.Write("入力文字:");
//Console.WriteLine(input);
//Console.ReadKey();


//using System;

//namespace HelloWorld
//{
// C#はclass内で実行される
//    class Program
//    {aaa
// C#はmain関数で開始・終了する
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Hello World!");
//        }
//    }
//}

//Console.WriteLine("Hello World!");

//int x;
//x = 5;
//Console.WriteLine(x);



namespace HelloWorld
{

    class Program
    {

        static void Main(string[] args)
        {
            // 10　ライブラリ
            // .NETクラスライブラリのSystem.Raddomクラスを使用
            // diceをサイコロとしてものとして、オブジェクトとして見ましょうって感じ
            Random dice = new Random();

            // diceオブジェクトのNext()メソッドを呼び出す
            int roll = dice.Next(1, 7);
            // ConsoleクラスのWriteLine()メソッドを呼び出す
            Console.WriteLine(roll);
            int roll1 = dice.Next(1, 7);
            Console.WriteLine(roll1);
            int roll2 = dice.Next(1, 7);
            Console.WriteLine(roll2);
            int roll3 = dice.Next(1, 7);
            Console.WriteLine(roll3);
            int roll4 = dice.Next(1, 7);
            Console.WriteLine(roll4);

            // 11　続ライブラリ
            //ステートレスメソッド: すでにメモリに入っている値を参照しない 過去の記憶は使用しない
            Console.WriteLine('a'); // WriteLineの中に入っているものだけ見ればOKみたいな

            //ステートフルメソッド（若干手続きある、Randomに一旦コピーしないといけないし）
            // メモリ内に入った値を参照し、更新する。
            // ob = クラスのインスタンス（オブジェクト）
            Random ob = new Random(); // newの箇所でメモリを確保、オブジェクトを生成, Randomは時刻に基づいた乱数生成
            int roll5 = ob.Next(1, 7);
            Console.WriteLine(roll5);

            // 12　オーバーロード
            // 1: 引数に様々なデータ型を使用できる
            // 2: 引数の数を選ぶことができる 引数渡したら戻り値帰ってくる

            int x = 1;
            Console.WriteLine(x);// int型
            Console.WriteLine("Good");// string型

            Random rand = new Random();
            int rand1 = rand.Next();
            Console.WriteLine(rand1);
            int rand2 = rand.Next(100);
            Console.WriteLine(rand2);
            // 90~99までしか取らない。maxValueは100入れない。minValueは90も含める
            int rand3 = rand.Next(90, 100);
            Console.WriteLine(rand3);
            // https://learn.microsoft.com/en-us/dotnet/api/system.random.next?view=net-7.0 でメソッドの種類も確認OK

            // 13　if文（分岐）ifはbool型
            // x >y, x<=y, x===y, x!=y
            // C#をAzureにupする方法確認
            var dice1 = new Random(); // varは型推定
            int roll6 = dice1.Next(1, 7);
            Console.WriteLine(roll6);

            if(roll6 >= 5)
            {
                Console.WriteLine("Very good!");
            } else if(roll6 >= 3)
            {
                Console.WriteLine("so good!");
            }
            else
            {
                Console.WriteLine("Bad..");
            }
            // 14　配列
            string[] item = new string[3];
            item[0] = "A123";
            item[1] = "B456";
            item[2] = "C789";
            Console.WriteLine(item[0]);
            Console.WriteLine(item[1]);
            Console.WriteLine(item[2]);

            // string[]で型宣言
            string[] fluits = { "apple", "orange", "pine" };
            Console.WriteLine(fluits[1]);
            // 配列に何個入っているかのメソッド
            Console.WriteLine(fluits.Length);

            // 15　foreach文
            // fluit は新しく宣言されたもの　インテレータ:順番に調べる, 0から順番に並べる
            foreach (string fluit in fluits)
            {
                Console.WriteLine(fluit);
            }
            Console.WriteLine();

            for(int i=0; i < fluits.Length; i++)
            {
                Console.WriteLine(@"#############");
                Console.WriteLine(fluits[i]);
                Console.WriteLine(@"#############");
            }
        }
    }
}
```


2023.08/13　メモ
```
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
            // ①Const 宣言時は大文字の方がわかりやすい
            const int NUM = 5; // いじって欲しくないやつはconstで宣言
            int[] array = new int[NUM];
            array[0] = 10;
            array[1] = 20;
            array[2] = 30;
            array[3] = 40;
            array[4] = 50;

            // 始まり、終わり、進める
            for (int i = 0; i < NUM; i++)
            {
                Console.WriteLine(array[i]);
            }

            // ②型推論 varは右辺から型を推論
            var x = 10;
            var y = 10.5m;

            // GetTypeCodeは型を返すメソッドaaa
            Console.WriteLine(x.GetTypeCode());
            Console.WriteLine(y.GetTypeCode());

            // 本来なら　Random randにしないといけない。どんな型で返ってくるかわからないときはvarで宣言するのも１つのやり方。です。
            var rand = new Random();
            int roll = rand.Next(1, 7);
            Console.WriteLine(roll);

            // ③メソッド
            // 自作メソッドは、コンポーネントみたいに何度も使い回しできるけど、流れがみにくい・・短い内容のメソッドは使用しなくてもいいかも。
            var x1 = 10;
            int y1;
            y1 = NewMethod(x1);
            printAnswer(y1);
            // ④名前空間、クラスで使用classAのsqrtメソッドを
            Console.WriteLine(A.sqrt(x));

            // ⑤配列
            int[] array1;// 宣言したがまだ生成されていない
            array1 = new int[3];// インスタンス生成、メモリ割り当て
            foreach (int a1 in array1)
            {
                Console.WriteLine(a1);
            }
            // ⑥拡大・縮小変換

            // int→decimalは拡大（情報が増える）ので自動で可能
            int a = 3;
            decimal number = a;
            Console.WriteLine(number);


            // decimal→intは縮小（情報が減る）ので指定が必要、宣言をしないとエラーでる。
            decimal z = 3.14m;
            int b = (int)z;
            Console.WriteLine(b);

            // 文字・数字変換
            int text = 3;
            int text2 = 5;
            // 文字型に変換可能 toString()
            string s = text.ToString() + text2.ToString();
            Console.WriteLine(s);

            string s1 = "3";
            string s2 = "5";

            // int.Parseで文字→数値に変換できる
            int sum = int.Parse(s1) + int.Parse(s2);
            Console.WriteLine(sum);
        }

        //引数
        private static void printAnswer(int y1)
        {
            Console.WriteLine(y1);
            Console.WriteLine(y1);
            Console.WriteLine(y1);
        }

        private static int NewMethod(int x1)
        {
            //返り値
            return x1 * x1;
        }

        // ④名前空間、クラス
        class A
        {
            public static int sqrt(int x)
            {
                return x * x + x;
            }
        }

        

        
    }
}
```

