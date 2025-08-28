public class Test
{
    public string Country { get; set; } = string.Empty;
    public string BankCode { get; set; } = string.Empty;
    public string Branch { get; set; } = string.Empty;
    public string Number { get; set; } = string.Empty;

    public void Parse(string ss) { Number = ss; } 
}
    