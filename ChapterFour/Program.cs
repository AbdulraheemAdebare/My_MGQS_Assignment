// Number 1
Console.Write("Enter any three numbers of your choice:");
int yourNumber1 = int.Parse(Console.ReadLine()!);
int a = (yourNumber1 / 100) % 10;
int b = (yourNumber1 / 10) % 10;
int c = yourNumber1 % 10;
int sum = a + b + c;
Console.WriteLine ("The sum of the numbers is"+ " " + sum + ".");

// Number 2
Console.Write("Enter the radius of the circle:");
int radiusOfCircle = int.Parse(Console.ReadLine()!);
double PiOfCircle = Math.PI;
Console.WriteLine("The Area of the cirle is " + (PiOfCircle * radiusOfCircle * radiusOfCircle));
Console.WriteLine("The Perimeter of the circle is " + (2 * PiOfCircle * radiusOfCircle));

// Number 3
Console.Write("Enter the name of the name of the company:");
string nameOfCompany = Console.ReadLine()!;
Console.Write("Enter the address of the company:");
string addressOfCompany = Console.ReadLine()!;
Console.Write("Enter the phone number of the company:");
double PhoneNumber = Double.Parse(Console.ReadLine()!);
Console.Write("Enter the fax number of the company:");
double faxNumber = double.Parse(Console.ReadLine()!);
Console.Write("Enter the website of the company:");
string websiteOfCompany = Console.ReadLine()!;
Console.Write("======Now Enter the Information of the Manager.====== \nEnter the First name of the Manager:");
string nameOfManager = Console.ReadLine()!;
Console.WriteLine("Enter the Surname of the Manager:");
string SurnameOfManager = Console.ReadLine()!;
Console.Write("Enter the Phone Number of the Manager:");
double numberOfManager = double.Parse(Console.ReadLine()!);
Console.WriteLine("");

// Number 4