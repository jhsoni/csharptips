namespace csharptips;

class Program
{
    static void Main(string[] args)
    {
        var multiLineRawString = """
                This is a multi-line raw string literal.
                It can have leading and trailing whitespace,
                which is ignored.
                """;
        Console.WriteLine(multiLineRawString);
        
        var jsonData = """
                        {
                            "name": "John Doe",
                            "age": 30
                        }
                        """;
        Console.WriteLine(jsonData);
    }
}
