using Vezba1;

#region Test Region 1 - Commented


//Console.WriteLine("Hello, World!!!")
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
//int finalResult = 4;
//0 //1 //2 //3 //4
//Console.WriteLine($"Rezultat na 1 + 3 = {finalResult}", 4);


//Console.WriteLine(36 - 6);
//Console.WriteLine(36 / 6);
//Console.WriteLine(5 * 10);

//var text = Console.ReadLine();
//Console.WriteLine("Ova e tekstot koj sto e vnesen od strana na user: {0}", text) ;

//Console.WriteLine("Vnesete gi posledovatelno cetirite varijabli a, b, c, d");
//Console.WriteLine("*************************************************");

//Console.WriteLine("Vnesete go prviot broj: ");
//int a = int.Parse(Console.ReadLine());

//int = ImeNaPrvaPromenliva = 0;

//if (a == 1)
//{
//    Console.WriteLine("True");
//}
//else
//{
//    Console.WriteLine("False");
//}

//Console.WriteLine("Vnesete go vtoriot broj: ");
//int b = int.Parse(Console.ReadLine());

//if (b == 2)
//{
//    Console.WriteLine("True");
//}
//else
//{
//    Console.WriteLine("False");
//}



//Console.WriteLine("Vnesete go tretiot broj: ");
//int c = int.Parse(Console.ReadLine());

//if (c == 3)
//{
//    Console.WriteLine("True");
//}
//else
//{
//    Console.WriteLine("False");
//}

//Console.WriteLine("Vnesete go cetvrtiot broj: ");
//int d = int.Parse(Console.ReadLine());

//if (d == 4)
//{
//    Console.WriteLine("True");
//}
//else
//{
//    Console.WriteLine("False");
//}

//if(a == 1 && b == 2 && c == 3 && d ==4)
//{
//    int result = a + b + c + d;
//    Console.WriteLine(result);
//}
//else { 

//    Console.WriteLine("Error");
//}

//nekoj comment

//nekoj comment 2

// nesto developirame novo vo noviot branch
// nesto developirame novo vo noviot branch 2
// nesto developirame novo vo noviot branch 3
// nesto developirame novo vo noviot branch 4
// nesto developirame novo vo noviot branch 5

// nesto developirame novo vo noviot branch 6_6
// nesto developirame novo vo noviot branch 7

// nesto developirame novo vo noviot branch 6

//++

#endregion

#region Test Region 2


Console.WriteLine("Region 2 Execute...");

// var functions = new Functions();
Functions functions = new Functions();


User korisnik  = new User();
korisnik.Id = 1;
korisnik.Name = "Ivan";
korisnik.Country = "Macedonia";
korisnik.City = "Skopje";
korisnik.Address = "Ilindenska br.1";
korisnik.Email = "korisnik@gmail.com";
korisnik.Username = "username_korisnik";
korisnik.Password = "password";
korisnik.DateCreated = DateTime.Now;
korisnik.LastOnline = DateTime.Now;
korisnik.Years = 30;

User user2 = new User()
{
	Id = 2,
	Name = "Jovan",
	City = "Veles",
	Country = "Macedonia",
};

Console.WriteLine(user2);
Console.WriteLine("\n");
Console.WriteLine("\n");
Console.WriteLine("\n");

Console.WriteLine($"Korisnikot so ime {user2.Name}\n" +
	$"so mesto na ziveenje vo {user2.City}, {user2.Country}\n" +
	$"ima {user2.Years} godini!"
	);

Console.WriteLine(korisnik);
Console.WriteLine("\n");
Console.WriteLine("\n");
Console.WriteLine("\n");


Console.WriteLine($"Korisnikot so ime {korisnik.Name}\n" +
	$"so mesto na ziveenje vo {korisnik.City}, {korisnik.Country}\n" +
	$"ima {korisnik.Years} godini!"
	);


var number = 1;

//var checkIfNumber = 


#endregion