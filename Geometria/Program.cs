

using geometria;



Console.Write("Inserisci un numero per creare la base del rettangolo ");
int baseUtente = int.Parse(Console.ReadLine());

Console.Write("Inserisci un numero per creare l'altezza del rettangolo ");
int altezzaUtente = int.Parse(Console.ReadLine());

Console.WriteLine();

Rettangolo MioRettangolo = new Rettangolo(baseUtente, altezzaUtente);

Console.WriteLine($"---------- Rettangolo1 ----------");

Console.WriteLine($"Il perimetro del rettangolo è {MioRettangolo.Perimetro(baseUtente, altezzaUtente)}");
Console.WriteLine($"L'area del rettangolo è {MioRettangolo.Area(baseUtente, altezzaUtente)}");
Console.WriteLine($"---------------------------------");




Console.Write("Inserisci un numero per creare la base del secondo rettangolo ");
int baseUtenteSecondo = int.Parse(Console.ReadLine());

Console.Write("Inserisci un numero per creare l'altezza del secondo rettangolo ");
int altezzaUtenteSecondo = int.Parse(Console.ReadLine());

Console.WriteLine();

RettangoloSecondo secondoMioRettangolo = new RettangoloSecondo(baseUtenteSecondo, altezzaUtenteSecondo);

Console.WriteLine($"---------- Rettangolo2 ----------");

Console.WriteLine($"Il perimetro del rettangolo è {secondoMioRettangolo.perimetroSecondo(baseUtente, altezzaUtente)}");
Console.WriteLine($"L'area del rettangolo è {secondoMioRettangolo.areaSecondo(baseUtenteSecondo, altezzaUtenteSecondo)}");
Console.WriteLine($"---------------------------------");