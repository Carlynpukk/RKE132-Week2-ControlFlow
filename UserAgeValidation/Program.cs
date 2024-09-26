// See https://aka.ms/new-console-template for more information

//Rakendus küsib kasutajal sisestada tema vanuse
//Kui kasutaja vanus on alla 13, siis konsoolis kuvatakse:
//"You are too young to use Instagram."
//Muul juhul kuvatakse konsoolis:
//"Welcome ti Instagram!"

Console.WriteLine("Enter your age:");

int userAge = Int32.Parse(Console.ReadLine()); //"13" - heap, 13 - stack

if(userAge >= 13)
{
    Console.WriteLine("Welcome to Instagram!");
}
else //If < 13
{
    Console.WriteLine("You are too young to use Instagram.");
}