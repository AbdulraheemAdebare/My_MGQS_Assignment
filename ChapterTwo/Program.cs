// Number 1
sbyte a = -115;
sbyte b = -44;
byte c = 97;
byte d = 224;
byte e = 112;
short f = -10000;
short g = 1990;
short h = 20000;
ushort i = 52130;
int j = -1000000;
uint k = 4825932;
long l = 970700000;
ulong m = 123456789123456789;

// Number 2
// All of the number can be assigned to variables of type float, double and decimal.

// Number 3
double comp = double.Parse(Console.ReadLine()!);
double comp2 = double.Parse(Console.ReadLine()!);
bool comp3 = Math.Abs(comp-comp2) < 0.000001;
switch (comp3)
{
    case true:
    Console.WriteLine("The numbers are equal");
    break;

    case false:
    Console.WriteLine("The NUmbers are not equal.");
    break;
}

// Number 4,5,6,7,8,9
int valueInt = 0x100;
char valueChar = '\u0048';
bool isMale = true;
string hello = "Hello, ";
string world = "world!";
object helloWorld = hello + world;
Console.WriteLine(helloWorld);
string cast = (string)helloWorld;
string test = "The use of Quotations causes difficulties";
string test2 = "The \"use\" of Quotations causes difficulties";

// Number 10,11
Console.WriteLine("    o     o\n   o   o   o\n   o       o\n    o     o\n      o o\n\n       /\\\n      /  \\\n     /    \\\u00A9\n    /______\\");

// Number 12
string fname;
string lname;
int age;
char @gender;
uint uniqueNumber;

// Number 13
int a1 = 5;
int a2 = 10;
a1 += a2;
a2 = a1 - a2;
a1 -= a2;
Console.WriteLine(a1);
Console.WriteLine(a2);
