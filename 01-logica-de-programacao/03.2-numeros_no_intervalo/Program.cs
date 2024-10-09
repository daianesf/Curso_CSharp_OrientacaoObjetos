using System.Collections;

Console.Write("Escreva a quantidade de numeros a serem lidos: ");
int quantidade = int.Parse(Console.ReadLine());

List<int> numeros = new List<int>();

for(int i = 0; i < quantidade; i++) {
    Console.Write("Digite o " + (i + 1) + " numero: ");
    numeros.Add(int.Parse(Console.ReadLine()));
}

int numerosIn10e20 = 0;
int numerosOut10e20 = 0;

Console.Write("Numeros Lidos: ");

for(int i = 0; i < numeros.Count; i++) {
    Console.Write(numeros[i] + ", ");

    if(numeros[i] > 10 && numeros[i] < 20) {
        numerosIn10e20 += 1;
    } else {
        numerosOut10e20 += 1;
    }
}

Console.WriteLine("\nNumeros in 10 e 20: " + numerosIn10e20);
Console.WriteLine("Numeros out 10 e 20: " + numerosOut10e20);