// Ehitame kalkulaatori mis kalkuleerib summa allahindlus
// kui summa <100 , ah 1%
// kui summa <200 && <400 , ah 5%
// kui summa >=400 , ah 10%

Console.WriteLine("Sisesta summa:");
int userInput = Int32.Parse(Console.ReadLine());

double discount = calculateDiscount(userInput);

Console.WriteLine($"Sinu allahindluse summa on: {discount}%");

double newTotal = calculateNewTotal (userInput, discount); //userInput - (userInput * discount) / 100;

Console.WriteLine($"Sinu summa allahindlusega {discount}% on: {newTotal}EUR");


static double calculateDiscount(int total)
{
    if(total < 100)
    {
        return 1;
    }
    else if (total >=200 && total < 400)
    {
        return 5;
    }
    else
    {
        return 10;
    }
}

static double calculateNewTotal(double total, double discount)
{
    double result = total - (total * discount) / 100;
    return result;
}