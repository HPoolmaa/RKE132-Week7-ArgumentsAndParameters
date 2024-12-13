
Console.WriteLine("Tere, maailm!");




PrintHello(); // tegemist on Call-on funktsiooniga. Kutsutakse all olev funktsioon välja
PrintGoodBye();
static void PrintHello() // funktsioon /method
{
    Console.WriteLine("Tere, maailm!");
}

static void PrintGoodBye()
{
    Console.WriteLine("Tere, tere, vanakere!");
}



Console.WriteLine("Kas sa tuled või ei tule? (jah/ei):");
string userChoise = Console.ReadLine();

if(userChoise == "jah")
{
    PrintHello();
}
else
{
    PrintGoodBye();
}