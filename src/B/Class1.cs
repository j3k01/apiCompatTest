namespace B;

public sealed class Plugin
{
    public void SaveRachunek(string parseTest)
    {
        var parse = new Test();
        parse.Parse(parseTest);
    }
}
