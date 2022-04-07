// See https://aka.ms/new-console-template for more information

using geometria;


Console.Write("Inserisci un numero per creare la base del rettangolo ");
int baseUtente = int.Parse(Console.ReadLine());

Console.Write("Inserisci un numero per creare l'altezza del rettangolo ");
int altezzaUtente = int.Parse(Console.ReadLine());

Console.WriteLine();

Rettangolo MioRettangolo = new Rettangolo(baseUtente, altezzaUtente);

Console.WriteLine($"---------- Rettangolo1 ----------------");
Console.WriteLine($"La base del rettangolo è {(baseUtente)} cm");
Console.WriteLine($"L'altezza del rettangolo è {(altezzaUtente)} cm");
Console.WriteLine($"Il perimetro del rettangolo è {MioRettangolo.Perimetro(baseUtente, altezzaUtente)} cm");
Console.WriteLine($"L'area del rettangolo è {MioRettangolo.Area(baseUtente, altezzaUtente)} cm^2 ");
Console.WriteLine($"---------------------------------------");




Console.Write("Inserisci un numero per creare la base del secondo rettangolo ");
int baseUtenteSecondo = int.Parse(Console.ReadLine());

Console.Write("Inserisci un numero per creare l'altezza del secondo rettangolo ");
int altezzaUtenteSecondo = int.Parse(Console.ReadLine());

Console.WriteLine();

RettangoloSecondo secondoMioRettangolo = new RettangoloSecondo(baseUtenteSecondo, altezzaUtenteSecondo);

Console.WriteLine($"---------- Rettangolo2 -----------------");
Console.WriteLine($"La base del rettangolo è {(baseUtenteSecondo)} cm");
Console.WriteLine($"L'altezza del rettangolo è {(altezzaUtenteSecondo)} cm");
Console.WriteLine($"Il perimetro del rettangolo è {secondoMioRettangolo.perimetroSecondo(baseUtente, altezzaUtente)} cm");
Console.WriteLine($"L'area del rettangolo è {secondoMioRettangolo.areaSecondo(baseUtenteSecondo, altezzaUtenteSecondo)} cm^2");
Console.WriteLine($"----------------------------------------");