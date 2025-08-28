public class Test
{
    public string Kraj { get; set; } = "";
    public string CS { get; set; } = "";
    public string Kierunek { get; set; } = "";
    public string Numer { get; set; } = "";

    public void Parse(string ss)
    {
        Numer = ss;
    }
}
