
Console.WriteLine("Sisesta sõna");
string UserInput = Console.ReadLine();

PrintAnyWord(UserInput); // userImput on argument

static void PrintAnyWord(string anyString) // anyString on parameeter
{
    anyString = anyString.ToUpper();
    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine(anyString);
    }
}