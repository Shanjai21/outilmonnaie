// See https://aka.ms/new-console-template for more information




using System;

Console.WriteLine("Commment Voulez-vous convertir largent CAD USD EUR en Majuscule");
string type = Console.ReadLine();
Console.WriteLine("Entrer votre montant");
double argent = Convert.ToDouble(Console.ReadLine());

if (type == "USD")
{
    double USD = 0.94 * argent;
    Console.WriteLine(argent + "USD equivalent a " + USD + "$ EUR");

    double CAD = 1.35 * argent;
    Console.WriteLine(argent + "USD equivalent a " + CAD + "$ CAD");


}
if (type == "CAD")
{
    double CAD = 0.74 * argent;
    Console.WriteLine(argent + "CAD equivalent a " + CAD + "$ USD");

    double EUR = 0.70 * argent;
    Console.WriteLine(argent + "CAD equivalent a " + EUR + "$ EUR");


}
if (type == "EUR")
{
    double EUR = 1.05 * argent;
    Console.WriteLine(argent + "EUR equivalent a " + EUR+ "USD");

    double CAD = 1.42 * argent;
    Console.WriteLine(argent + "EUR equivalent a " + CAD + "CAD");


}





Console.ReadKey();
