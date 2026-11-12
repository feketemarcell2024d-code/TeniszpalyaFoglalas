using TeniszpalyaFoglalas;

string[] sorok = File.ReadAllLines("foglalasok.txt");
List<Foglalas> foglalasok = new List<Foglalas>();
foreach (string sor in sorok)
{
    foglalasok.Add(new Foglalas(sor));
}
Console.WriteLine("Napi pályafoglalások:");
int osszBevetel = 0;
Foglalas legtobb = foglalasok[0];
foreach (Foglalas f in foglalasok)
{
    Console.WriteLine(f);
    osszBevetel += f.FizetendoDij();
    if (f.FoglaltOrak > legtobb.FoglaltOrak)
    {
        legtobb = f;
    }
}

Console.WriteLine("Statisztika:");
Console.WriteLine($"Teniszcentrum teljes napi bevétele: {osszBevetel} Ft");
Console.WriteLine($"Legtöbb órát foglaló játékos: {legtobb.JatekosNev} ({legtobb.FoglaltOrak} óra)");