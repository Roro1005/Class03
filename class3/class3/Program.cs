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
//long temp1 = 1;
//long temp2 = 1;

//Console.WriteLine(1 + ":" + temp1);
//Console.WriteLine(2 + ":" + temp2);

//for (int i = 3; i <= 50; i++)
//{
//    long next = temp1 + temp2;
//    Console.WriteLine(i + ":" + next);

//    temp1 = temp2;
//    temp2 = next;
//}

//ハンズオン11
/*
double Weight = 60.0;
double Height = 1.7;

double BMI=Weight/(Height*Height);
Console.WriteLine("BMIは"+BMI+"です。");
*/

//ハンズオン12
/*
Console.WriteLine("体重を入力してください(kg)");
string userWeight = Console.ReadLine();
double weight=double.Parse(userWeight);
Console.WriteLine("体重は" + weight.ToString("F2") + "です。");
Console.WriteLine("身長を入力してください(m)");
string userHeight = Console.ReadLine();
double height = double.Parse(userHeight);
Console.WriteLine("身長は" + height.ToString("F2") + "です。");

double BMI = weight / (height * height);
Console.WriteLine("BMIは" + BMI.ToString("F2") + "です。");
*/
//try-catchサンプル
/*
string input = Console.ReadLine()??"";
int parsed = 0;
try
{
    parsed=int.Parse(input);
}
catch(Exception e)
{
    Console.WriteLine("バース失敗:"+e.ToString());
}
Console.WriteLine("バース結果:"+parsed);
*/
//ハンズオン13
/*
double weight = 0;
bool parseSuccess = false;
Console.WriteLine("体重を入力してください(kg)");
while (!praseSuccess)
{
    string userWeight = Console.ReadLine();
    try
    {
        weight = double.Parse(userWeight);
        parseSuccess = true;
    }
    catch (Exception e)
    {
        Console.WriteLine("数値を入力してください。");
        
    }
}
Console.WriteLine("体重は" + weight.ToString("F2") + "です。");

Console.WriteLine("身長を入力してください(m)");
double height = 0;
parseSuccess = false;
while(!praseSuccess)
{
    string userHeight = Console.ReadLine();
    try
    {
        height = double.Parse(userHeight);
        parseSuccess=true;
    }
    catch(Exception e)
    {
        Console.WriteLine("数値を入力してください。");
    }
}
Console.WriteLine("身長は" + height.ToString("F2") + "です。");

double BMI = weight / (height * height);
Console.WriteLine("BMIは" + BMI.ToString("F2") + "です。");
*/
//TryParseサンプル
/*
string input=Console.ReadLine();
int parsed;

bool parseSuccess=int.TryParse(input, out parsed);
if(parseSuccess)
{
    Console.WriteLine("パース成功:"+ parsed);
}
else
{
    Console.WriteLine("パース失敗");
}
*/
//ハンズオン14
/*
double weight = 0;
bool parseSuccess = false;
Console.WriteLine("体重を入力してください(kg)");
while (!parseSuccess)
{
    string userWeight = Console.ReadLine();

    parseSuccess=double.TryParse(userWeight, out weight);
    if (!parseSuccess)
    {
        Console.WriteLine("数値を入力してください。");
    }
}
Console.WriteLine("体重は" + weight.ToString("F2") + "です。");

Console.WriteLine("身長を入力してください(m)");
double height = 0;
parseSuccess = false;
while (!parseSuccess)
{
    string userHeight = Console.ReadLine();
    parseSuccess = double.TryParse(userHeight, out height);
    if(!parseSuccess)
    {
        Console.WriteLine("数値を入力してください。");
    }
}
Console.WriteLine("身長は" + height.ToString("F2") + "です。");

double BMI = weight / (height * height);
Console.WriteLine("BMIは" + BMI.ToString("F2") + "です。");
*/
//ハンズオン15
int[] intArray = new int[] { 3, 5, 2, 7, 18, 12,15 };
//配列の中身を確認
for(int i=0;i<intArray.Length;i++)
{
    Console.WriteLine("インデックス"+i+":"+intArray[i]);
}
//配列の最大値を確認
int max = int.MinValue;
int min = int.MaxValue;
long sum = 0;
for (int i=0; i<intArray.Length;i++)
{
    if (max < intArray[i])
    {
        max = intArray[i];
    }
    if(min > intArray[i])
    {
        min=intArray[i];
    }
    sum+=intArray[i];
}
double mean=(double)sum/(double)intArray.Length;

Console.WriteLine("最大値"+max);
Console.WriteLine("最小値"+min);
Console.WriteLine("合計値" + sum);
Console.WriteLine("平均値"+mean.ToString("F2"));



//配列の中身を小さい順に並べ替える
Array.Sort(intArray);

for (int i = 0; i < intArray.Length; i++)
{
    Console.WriteLine("インデックス" + i + ":" + intArray[i]);
}

//中央値
double median = 0;
if(intArray.Length%2==1)
{
    int targetIndex=(intArray.Length-1)/2;
    median = intArray[targetIndex];
}
else
{
    int targetIndex=(intArray.Length/2);
    int medianSum=intArray[targetIndex]+intArray[targetIndex-1];
    median = (double)medianSum / 2.0;
}
Console.WriteLine("中央値" + median);
