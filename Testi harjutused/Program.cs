//Console.WriteLine("Enter your comment:");
//string userInput = Console.ReadLine();

//CountSpaces(userInput);

//static void CountSpaces(string someString)
//{
//    someString = someString.Trim();
//    int wordCounter = 1;

//    foreach (char symbol in someString)
//    {
//        if (char.IsWhiteSpace(symbol))
//        {
//            wordCounter++;
//        }
//    }

//    string word = "word";
//    if (wordCounter > 1)
//    {
//        word = "words";
//    }
//    Console.WriteLine($"Your comment contains {wordCounter} {word}.");
//}




//Console.WriteLine("Enter your name:");
//string userName = Console.ReadLine();

//GreetUser(userName);

//static void GreetUser(string someName)
//{
//    Console.WriteLine($"Hello, {someName}");
//}

//HelloWorld();

//static void HelloWorld()
//{
//    Console.WriteLine("Hello, World!");
//}

//Console.WriteLine("How many steps have you walked today?");
//int usersSteps = Int32.Parse(Console.ReadLine());

//string result = HealthMonitor(usersSteps);

//Console.WriteLine(result);

//static string HealthMonitor(int steps)
//{
//    if (steps < 4000)
//    {

//        return "You need to move more.";
//    }
//    else if (steps >= 4000 && steps < 8000)
//    {

//        return "Health goal achieved,";
//    }
//    else
//    {

//        return "Well done!";
//    }
//}

//Kirjutage programm, mis teisendab Fahrenheiti kraadi Celsiuse järgi ja vastupidi.
//*Programm võimaldab kasutajal valida, kas teisendada väärtuse Celciusesse või Farenheiti.
//* Kui kasutaja on oma valiku teinud, programm küsib sisendit, teostab arvutusi ja kuvab tulemuse.
//* fahrenheit = (celsius * 9) / 5 + 32;
//*celsius = (fahrenheit - 32) * 5 / 9;

Console.WriteLine("This program converts degrees in C' to degrees in F' or vice versa.");
Console.WriteLine("Enter the temperature system from witch you wish to convert (C;F):");
char degreeSystem = char.Parse(Console.ReadLine().ToUpper());

Console.WriteLine($"Enter the {degreeSystem} value:");
int degreeValue = Int32.Parse(Console.ReadLine());

if (degreeSystem == 'F')
{
    ConvertToCelsius(degreeValue);
}
else if (degreeSystem == 'C')
{
    ConvertToFahrenheit(degreeValue);
}
else
{
    Console.WriteLine("Oops! The input is not valid, please use only 'C' or 'F'!");
}

static void ConvertToCelsius(int degreeValue)
{
    double result = (degreeValue - 32) * 5 / 9;
    Console.WriteLine($"{degreeValue}F' = {result}C'");
}
static void ConvertToFahrenheit(int degreeValue)
{
    double result = (degreeValue * 9) / 5 + 32;
    Console.WriteLine($"{degreeValue}C' = {result}F'");
}