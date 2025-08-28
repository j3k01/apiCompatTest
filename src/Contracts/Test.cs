public class Test
{
    public string Country { get; set; } = string.Empty;
    public string BankCode { get; set; } = string.Empty;
    public string Branch { get; set; } = string.Empty;
    public string Number { get; set; } = string.Empty;

    public void Parse(string ss) { Number = ss; } 
}
//using Demo.Contracts;

//public class Test : ITest
//{
//    public string Country { get; set; } = string.Empty;
//    public string BankCode { get; set; } = string.Empty;
//    public string Branch { get; set; } = string.Empty;
//    public string Number { get; set; } = string.Empty;
//}

//public static class TestExtensions
//{
//    public static void Parse(this ITest nr, string text)
//    {
//        nr.Number = text;
//    }
//}