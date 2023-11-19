// // Number 1
// Console.Write("Enter your input:");
// long yourNumber1 = long.Parse(Console.ReadLine()!);
// for (int printer = 1; printer <= yourNumber1; printer++)
// {
//     Console.WriteLine(printer);
// }

// // Number 2
// Console.Write("Enter your input:");
// long yourNumber2 = long.Parse(Console.ReadLine()!);
// for (int printer1 = 1; printer1 <= yourNumber2; printer1++)
// {
//     while (printer1 % 3 == 0 && printer1 % 7 == 0)
//     {
//         continue;
//     }
//     Console.WriteLine(printer1);
// }

// // Number 3 yet to be solved
// Console.Write("How many integers do you wish to enter?:");
// int n = int.Parse(Console.ReadLine()!);
// int yeah = 0;
// int b = Int32.MaxValue;
// int s = Int32.MinValue;
// for (int i = 0; i < n; i++)
// {
//     yeah = int.Parse(Console.ReadLine()!);
//     b = int.Max(yeah,yeah);
//     s = int.Min(yeah,yeah);
// }
// Console.WriteLine(b);
// Console.WriteLine(s);

// Number 4


//Number 5


// Number 6
int k = 3;
int N = 5;
int Nfactorial = 1;
int Kfactorial = 1;
int b = 0;
for (int i = 1; i <= N; i++)
{
    Kfactorial *= i;
    Nfactorial *= i;
    if (i <= k)
    {
        b = Kfactorial;
    }
}
Kfactorial = b;
var ans = Nfactorial/Kfactorial;
Console.WriteLine(ans);

//  Number 7
var multiplication = Nfactorial * Kfactorial;
var subtraction = N - k;
int subtractionFactorial = 1;
for (int i = 1; i <= subtraction; i++)
{
    subtractionFactorial *= i; 
}
var ans2 = multiplication / subtractionFactorial;
Console.WriteLine(ans2);

// Number 8


//Number 9


// Number 10