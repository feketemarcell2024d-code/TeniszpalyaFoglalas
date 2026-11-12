using TeniszpalyaFoglalas;

string[] sorok = File.ReadAllLines("foglalasok.txt");
List<Foglalas> foglalasok = new List<Foglalas>();
foreach (string sor in sorok)
{
    foglalasok.Add(new Foglalas(sor));
}
