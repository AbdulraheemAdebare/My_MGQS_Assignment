// // Number One
// Console.Write("Enter the first Integer:");
// int firstIntegers = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Enter the second integer:");
// int secIntegers = int.Parse(Console.ReadLine()!);
// if (firstIntegers > secIntegers)
// {
//     int a = firstIntegers;
//     firstIntegers = secIntegers;
//     secIntegers = a;
// }
// Console.WriteLine($"{firstIntegers},{secIntegers}");

// Number Two

Console.WriteLine("Enter three numbers of your choice:");
float yourNumber6 = float.Parse(Console.ReadLine()!);
float yourNumber7 = float.Parse(Console.ReadLine()!);
float yourNumber8 = float.Parse(Console.ReadLine()!);
if((yourNumber6 * yourNumber7 * yourNumber8) > 0 ){
    Console.WriteLine("Positive.");
}
else if((yourNumber6 * yourNumber7 * yourNumber8) < 0){
    Console.WriteLine("Negative");
}
else if((yourNumber6 * yourNumber7 * yourNumber8) == 0){
    Console.WriteLine("The number contains a zero");
}

// // Number Three
// Console.Write("Enter the first Number:");
// int number1 = int.Parse(Console.ReadLine()!);
// Console.Write("Enter the second Number:");
// int number2 = int.Parse(Console.ReadLine()!);
// Console.Write("Enter the third Number:");
// int number3 = int.Parse(Console.ReadLine()!);
// if (number1 > number2)
// {
//     if (number1 > number3)
//     {
//         Console.Write("Number " + number1 + " is the biggest number.");
//     }
// }
// else if (number2 > number3)
// {
//     if (number2 > number1)
//     {
//         Console.WriteLine("Number " + number2 + " is the biggest number.");
//     }
// }
// else if (number3 > number2)
// {
//     if (number3> number1)
//     {
//         Console.Write("Number " + number3 + " is the biggest number.");
//     }
// }

// // Number 4
// Console.WriteLine("Enter Three integers.");
// int[] yournumber4 = new int[3];
// for (int yeah = 0; yeah < yournumber4.Length; yeah++)
// {
//    yournumber4[yeah] =int.Parse(Console.ReadLine()!);
// }

// // Number 5
// Console.Write("Enter any Integer from 0-9");
// int yournumber5 = int.Parse(Console.ReadLine()!);
//  switch (yournumber5)
//  {
//     case 0:
//     Console.WriteLine("Zero");
//     break;
//     case 1:
//     Console.WriteLine("One");
//     break;
//     case 2:
//     Console.WriteLine("Two");
//     break;
//     case 3:
//     Console.WriteLine("Three");
//     break;
//     case 4:
//     Console.WriteLine("Four");
//     break;
//     case 5:
//     Console.WriteLine("Five");
//     break;
//     case 6:
//     Console.WriteLine("Six");
//     break;
//     case 7:
//     Console.WriteLine("Seven");
//     break;
//     case 8:
//     Console.WriteLine("Eight");
//     break;
//     case 9:
//     Console.WriteLine("Nine");
//     break;
//  }

// Number 6
// Console.WriteLine("Enter the co-efficient of the Quadratic equation below:");
// double a,b,c,discriminant,root1,root2;
// a = double.Parse(Console.ReadLine()!);
// b = double.Parse(Console.ReadLine()!);
// c = double.Parse(Console.ReadLine()!);
// discriminant = b*b - 4*(a*c);
// if (discriminant == 0)

// // Number 7

// //Number 8
// Console.Write("What data type will you like to iput? Enter 1 for int, 2 for double, and 3 for string: ");
// int choice1 = int.Parse(Console.ReadLine()!);
// switch (choice1)
// {
//    case 1:
//    Console.Write("Now, enter an integer:");
//    int integerInput = int.Parse(Console.ReadLine()!);
//    Console.WriteLine(integerInput + 1);
//    break;
//    case 2:
//    Console.Write("Now enter a double:");
//    int doubleInput = int.Parse(Console.ReadLine()!);
//    Console.WriteLine(doubleInput + 1);
//    break;
//    case 3:
//    Console.Write("Now, enter a string:");
//    string stringInput = Console.ReadLine()!;
//    Console.WriteLine(stringInput + "*");
// }

// Number 9

// // Number 10
// Console.Write("What is your score?:");
// int yourScores = int.Parse(Console.ReadLine()!);
// if (yourScores == 0 || yourScores > 9)
// {
//    Console.ForegroundColor = ConsoleColor.DarkRed;
//    Console.WriteLine("Invalid Input");
//    Console.ResetColor();
//    return;
// }
// else if (yourScores <= 3)
// {
//    yourScores *= 10;
// }
// else if (yourScores <= 6)
// {
//    yourScores *= 100;
// }
// else if (yourScores <= 9)
// {
//    yourScores *= 1000;
// }

// Number 11