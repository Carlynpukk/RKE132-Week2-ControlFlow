// See https://aka.ms/new-console-template for more information

//Rakendus küsib kasutajalt küsida tema sugu (mees/naine)
//Rakendus küsib kasutajal sisestada tema perekonnanimi
//Lähtudes kasutaja valikust, tervitab rakendus kasutajat järgnevalt:
//"Welcome, Mr. (kasutaja perekonnanimi) /"Welcome, Ms. (kasutaja perekonnanimi)"

Console.WriteLine("Plese, select your gender (m/f):");

char userGender = Char.Parse(Console.ReadLine()); //Loeb konsoolist maha sting ehk sõne formaadis

Console.WriteLine("Please, enter your last name:") ;
string userLastName = Console.ReadLine();

if (userGender == 'm')
{
    Console.WriteLine($"Welcome, Mr. {userLastName}!");
}
else if (userGender == 'f')
{
    Console.WriteLine($"Welcome, Ms. {userLastName}!)");
}
else
{
    Console.WriteLine($"Welcome, {userLastName}!");
}