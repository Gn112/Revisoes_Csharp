/*
static void Soma()
{
    int n1 = 1;
    int n2 = 2;
    int n3 = 3;

    int soma = n1 + n2 + n3;

    Console.WriteLine(soma);
}

Soma();
*/

/*
static int Cubo(int l)
{
    return l * l * l;
}

Console.WriteLine(Cubo(2));
*/

static int F1 (int x)
{
    return x * 5;
}

static int F2(int x)
{
    return x * 2;
}

Console.WriteLine(F2(F1(2)));