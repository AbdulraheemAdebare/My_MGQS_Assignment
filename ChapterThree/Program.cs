// Number 1
Console.Write("Enter a Number:");
int yourNumber = int.Parse(Console.ReadLine()!);
int evenOrOdd = yourNumber%2;
if (evenOrOdd == 0)
{
    Console.WriteLine($"{yourNumber} is an even number.");
}
else if (evenOrOdd == 1)
{
    Console.WriteLine($"{yourNumber} is an Odd Number");
}

// Number 2
Console.Write("Enter a Number:");
int yourNumber2 = int.Parse(Console.ReadLine()!);
int divisible = yourNumber2 % 7;
int divisible2 = yourNumber2 % 5;
if (divisible == 0 && divisible2 == 0)
{
    Console.WriteLine($"{yourNumber2} is divisible by both 7 and 5.");
}
else
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("Oga, na rubbish u enter!");
    Console.ResetColor();
}

// Number 3
Console.WriteLine("Enter a Number(not less than 3 digits):");
int yourNumber3 = int.Parse(Console.ReadLine()!);
int check1 = yourNumber3 % 100;
int check2 = check1 % 10;
if (check2 == 7)
{
    Console.WriteLine("The third digit of the number is 7.");
}
else
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("The Third digit of the number is not 7!");
    Console.ResetColor();
}

// Number 4
int yourNumber4 = int.Parse(Console.ReadLine()!);
bool check3 = Convert.ToBoolean(yourNumber4 & 2);
switch (check3)
{
    case true:
    Console.WriteLine("The third bit of the number is One.");
    break;

    case false:
    Console.WriteLine("The third bit of the number is Zero.");
    break;
}

// Number 5
Console.Write("Enter the first side:");
int side1 = int.Parse(Console.ReadLine()!);
Console.Write("Enter the second side:");
int side2 = int.Parse(Console.ReadLine()!);
Console.Write("Enter the height:");
int @height = int.Parse(Console.ReadLine()!);
int area = (side1 + side2) * @height / 2;
Console.WriteLine($"The Area of the Trapezoid is {area}");

// Number 6
Console.Write("Enter the first side:");
int side3 = int.Parse(Console.ReadLine()!);
Console.Write("Enter the second side:");
int side4 = int.Parse(Console.ReadLine()!);
int perimeter = 2 * (side3 + side4);
int area2 = side3 * side4;
Console.WriteLine($"The perimeter of the Rectangle is {perimeter}.\nThe Area of the Rectangle is {area2}.");

// Number 7
Console.Write("What is the weight of the man on Earth?(kg):");
int weightOfMan = int.Parse(Console.ReadLine()!);
Console.WriteLine($"The weight of the man on the moon will be {weightOfMan * 0.17}kg.");

// Number 8
Console.Write("Enter first point(x-axis):");
int fPoint = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter the second point:");
int sPoint = int.Parse(Console.ReadLine()!);
bool check4 = fPoint <= 5 && sPoint <= 5;
Console.WriteLine(check4 ? "It's inside the circle." : "It's not inside the circle!");

// Number 9 
Console.Write("Enter the position of the Rectangle {0,0}, {0,0}:");
int fPoint2 = int.Parse(Console.ReadLine()!);
int sPoint2 = int.Parse(Console.ReadLine()!);

bool check5 = fPoint2 <= 5 && sPoint2 <= 5 ;


// Number 10
Console.Write("Enter a four digits number:");
int yourNumber5 = int.Parse(Console.ReadLine()!);
int a = (yourNumber5 / 1000) % 10;
int b = (yourNumber5 / 100) % 10;
int c = (yourNumber5 / 10) % 10;
int d = yourNumber5 % 10;
int sum = a + b + c + d;
Console.WriteLine($"The sum is {sum}.");
Console.WriteLine($"{d}{c}{b}{a}");
Console.WriteLine($"{d}{a}{b}{c}");
Console.WriteLine($"{a}{c}{b}{d}");

// Number 11
Console.Write("Enter a number:");
int yourNumber6 = 23; //0001 0111
int p = 3;
int i = 0; //0000 0000
int check6 = i >> p;
Console.WriteLine((check6 & yourNumber6) == 0? 0 : 1);

// Number 12
Console.Write("Enter a number:");
int yourNumber7 = 23; //0001 0111
int p2 = 3;
int i2 = 0; //0000 0000
int check7 = i2 >> p2;
Console.WriteLine((check7 & yourNumber7) == 1? "True" : "False");

// Number 13


//  Number 14
Console.Write("Enter a number within the range of 1-100. Let's check if it's a prime number.:");
 int yourNumber8 = int.Parse(Console.ReadLine()!);
 if (!(yourNumber8 % 2 == 0 && yourNumber8 % 3 == 0))
 {
    Console.WriteLine("The Number is a prime Number.");
 }
 else
 {
    Console.WriteLine("The Number is not a Prime Number!");
 }

//  Chapter 15


// Chapter 16

