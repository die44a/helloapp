namespace helloapp;

class Greeting
{
    public static void Main(string[] args)
    {
        Console.WriteLine("hello everyone");
        GreetBlack();
        GreetWhite();
    }

    private static void GreetWhite()
    {
        Console.WriteLine("hello everyone white");
    }

    private static void GreetBlack()
    {
        Console.WriteLine("hello black");
    }
}