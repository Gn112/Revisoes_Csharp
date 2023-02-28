// Lista
var nomes = new List<string> { "Pedro", "Diego" }; // Cria uma lista dinâmica
nomes.Add("Duda"); // .Add adiciona novos valores na lista
nomes.Add("Raissa");
nomes.Add("Brenda");
nomes.Add("Eduardo");
nomes.Add("Solinha");
nomes.Add("Oswaldo");
nomes.Add("Gabriel");

nomes.RemoveAt(8); // Remove Oitava Posição
nomes.RemoveRange(0, 3); // Remove valores em uma determinada faixa
nomes.Clear(); // Limpa todos os valores da lista


foreach (string nome in nomes) // Exibe uma frase com os valores da lista de forma condicional
    if (nome == "Eduardo" || nome == "Brenda" || nome == "Oswaldo") // Estrutura Condicional
    {
        Console.WriteLine($"SE FODA {nome.ToUpper()}! <3 \n");
    }
    else { 
        Console.WriteLine($"Olá {nome.ToUpper()}! <3 <3 \n"); 
    }

//Array

int[] numeros = new int[5];
Console.Write("Digite 5 números: ");

for(int i = 0; i < numeros.Length; i++)
{
    numeros[i] = Convert.ToInt32(Console.ReadLine());
}

for(int x = 0; x < numeros.Length; x++)
{
    Console.Write("Digitou" + numeros[x] \n);
}