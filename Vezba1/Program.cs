﻿Console.WriteLine("Hello, World!!!");

/* multi
 * line
 * comment
 */
//var a = "abc";

/*string a = "nekoja recenica";
int b = 30;
double c = 0.2;*/

//int a = 1;
//int b = 2;
//int c = 3;
//int d = a /* ova e objasnuvanje za promenliva a */ + c;
//                                              //0 //1 //2 //3 //4
//Console.WriteLine("Rezultat na 1 + 3 = {4}", "SMX", 1,  2,  3,  4);
//Console.WriteLine(36 - 6);
//Console.WriteLine(36 / 6);
//Console.WriteLine(5 * 10);

//var text = Console.ReadLine();
//Console.WriteLine("Ova e tekstot koj sto e vnesen od strana na user: {0}", text) ;

Console.WriteLine("Vnesete gi posledovatelno cetirite varijabli a, b, c, d");
Console.WriteLine("*************************************************");

Console.WriteLine("Vnesete go prviot broj: ");
int a = int.Parse(Console.ReadLine());

if (a == 1)
{
    Console.WriteLine("True");
}
else
{
    Console.WriteLine("False");
}

Console.WriteLine("Vnesete go vtoriot broj: ");
int b = int.Parse(Console.ReadLine());

if (b == 2)
{
    Console.WriteLine("True");
}
else
{
    Console.WriteLine("False");
}



Console.WriteLine("Vnesete go tretiot broj: ");
int c = int.Parse(Console.ReadLine());

if (c == 3)
{
    Console.WriteLine("True");
}
else
{
    Console.WriteLine("False");
}

Console.WriteLine("Vnesete go cetvrtiot broj: ");
int d = int.Parse(Console.ReadLine());

if (d == 4)
{
    Console.WriteLine("True");
}
else
{
    Console.WriteLine("False");
}

if(a == 1 && b == 2 && c == 3 && d ==4)
{
    int result = a + b + c + d;
    Console.WriteLine(result);
}
else { 
    
    Console.WriteLine("Error");
}

//nekoj comment

//nekoj comment 2