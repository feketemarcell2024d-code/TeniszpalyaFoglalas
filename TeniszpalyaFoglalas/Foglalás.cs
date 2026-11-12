namespace TeniszpalyaFoglalas;

public class Foglalas
{
    public string JatekosNev { get; set; }
    public int FoglaltOrak { get; set; }
    public int BereltUtoDb { get; set; }

    public Foglalas(string sor)
    {
        string[] adatok = sor.Split(';');
        JatekosNev = adatok[0];
        FoglaltOrak = int.Parse(adatok[1]);
        BereltUtoDb = int.Parse(adatok[2]);
    }

    public int FizetendoDij()
    {
        return FoglaltOrak * 3500 + BereltUtoDb * 800;
    }

    public override string ToString()
    {
        return $"{JatekosNev}: {FoglaltOrak} óra, {BereltUtoDb} db bérelt ütő - Fizetendő: {FizetendoDij()} Ft";
    }
}