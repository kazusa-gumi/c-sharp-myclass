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
