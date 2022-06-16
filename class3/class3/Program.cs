/*
//ハンズオン01

int a=400;
int b=500;

int c=a+b;

//Console.WriteLine(c);


//ハンズオン02
int h02 = 121;
int rest = h02 % 2;

if(rest == 0)
{
    Console.WriteLine(h02 + " は偶数です");
}
else
{
    Console.WriteLine(h02 + " は奇数です");
}



//ハンズオン03
string Answer = "i";

Console.WriteLine("文字当てゲーム:回答を入力してください");
string userAnswer = Console.ReadLine() ?? "";

while(userAnswer != Answer)
{
    Console.WriteLine("不正解..もう一度入力してください");
    userAnswer = Console.ReadLine() ?? "";
}

Console.WriteLine("正解！");



//ハンズオン04

int loop = 1;
int sum = 0;
while(loop <= 100)
{
    //sum = sum + loop;
    sum += loop;

    //loop = loop + 1;
    loop++;
}

Console.WriteLine("合計は" + sum + "です");

//ハンズオン05

string Answer = "i";

Console.WriteLine("文字当てゲーム:回答を入力してください");
string userAnswer;

do
{
    userAnswer = Console.ReadLine();
    Console.WriteLine("不正解..もう一度入力してください");
    if (userAnswer == Answer)
    {
        Console.WriteLine("正解！");

    }

}
while (userAnswer != Answer);
*/

//do~whileのサンプル
/*
int number = 0;
do
{
    number++;
    Console.WriteLine(number);
}
while (number < 10);

*/
//ハンズオン06
/*
int sum06 = 0;
for(int i=0;i<=100;i++)
{
    sum06 += i;
}
Console.WriteLine("合計:" + sum06);
*/
/*
//ハンズオン07
float rumber = 3.14f;
float result = rumber * 300.5f;
Console.WriteLine(result);
*/

//ハンズオン08
/*
float number = 0f;
for(int i=0;i<1000;i++)
{
    number += 0.001f;
}
Console.WriteLine(number);
float number2 = 10000f;
number2 += 0.001f;
Console.WriteLine(number2);
*/

//ハンズオン09
/*
int number = 11;
bool numberIsOver0 = number >= 0;
bool numberIsUnder10 = number <= 10;
if(numberIsOver0&&numberIsUnder10)
{
    Console.WriteLine(number + "は0以上10以下です");
}

if(!numberIsOver0||!numberIsUnder10)
{
    Console.WriteLine(number + "は0より小さいか10より大きいです");
}
*/
//ハンズオン10
long temp1 = 1;
long temp2 = 1;

Console.WriteLine(1 + ":" + temp1);
Console.WriteLine(2 + ":" + temp2);

for (int i = 3; i <= 50; i++)
{
    long next = temp1 + temp2;
    Console.WriteLine(i + ":" + next);

    temp1 = temp2;
    temp2 = next;
}