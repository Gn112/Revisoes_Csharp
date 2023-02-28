
// -- Tipos Variáveis -- //
/*
Console.WriteLine("Olá, Mundinho!");

int num0 = 10;
float num1 = 2.4f;
double num2 = 0.1f;
string text0 = "Text";
char text1 = 'a';
bool value = false;
dynamic x = 10;

long num3 = 3423212344343333;
decimal num4 = 3.129m;
Console.WriteLine("Inteiro " + num0);
Console.WriteLine($"Inteiro, {num0}");
Console.WriteLine("Float " + num1);
Console.WriteLine("Double " + num2);
Console.WriteLine("String " + text0);
Console.WriteLine("Caractere " + text1);
Console.WriteLine("Boleano " + value);
Console.WriteLine("Dinamico " + x);
Console.WriteLine("Long " + num3);
Console.WriteLine("Decimal " + num4);
*/
// ---- //



// -- Estruturas de Repetição -- //

// For
Console.WriteLine("1. \n");
for (int i = 0; i < 3; i++)
{
    Console.WriteLine("For: O número é {0}", i);
}

Console.WriteLine("2. \n");
// While
int ie = 0;
while (ie < 3)
{
    Console.WriteLine("While: O número é {0}", ie);
    ie++;
}

Console.WriteLine("3. \n");
// Do-While
int iee = 0;
do
{
    Console.WriteLine($"Do: O número é {iee}");
    iee++;
} while (iee < 3);

Console.WriteLine("4. \n");
// For --
int x = 5;
for(int i = 10; i >= x; i--)
{
    Console.WriteLine("C# é massa {0}", i);
}

// ---- //

// -- Array -- //
Console.WriteLine("Array 1. \n");

string[] carros = { "Monza", "Fiat 147", "Passat", "Kaddet" };
foreach (string c in carros)
    Console.WriteLine(c);


// ---- //