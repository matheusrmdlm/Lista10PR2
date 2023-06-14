using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista10PR2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int exec;
            do
            {
                Console.WriteLine("     menu");
                Console.WriteLine("Para sair, digite 0");
                Console.WriteLine("exercício 1");
                Console.WriteLine("exercício 2");
                Console.WriteLine("exercício 3");
                Console.WriteLine("exercício 4");
                Console.WriteLine("exercício 5");
                exec = int.Parse(Console.ReadLine());

                switch (exec)
                {
                    case 1:
                        Console.Write("Informe o tamanho do vetor: ");
                        int tamanho = int.Parse(Console.ReadLine());

                        float[] numeros = new float[tamanho];

                        for (int i = 0; i < tamanho; i++)
                        {
                            Console.Write("Informe o número {0}: ", i + 1);
                            numeros[i] = float.Parse(Console.ReadLine());
                        }

                        float menor = numeros[0];
                        float maior = numeros[0];
                        float soma = numeros[0];

                        for (int i = 1; i < tamanho; i++)
                        {
                            if (numeros[i] < menor)
                                menor = numeros[i];

                            if (numeros[i] > maior)
                                maior = numeros[i];

                            soma += numeros[i];
                        }

                        float media = soma / tamanho;

                        Console.WriteLine("Menor número: {0}", menor);
                        Console.WriteLine("Maior número: {0}", maior);
                        Console.WriteLine("Média aritmética: {0}", media);
                        break;

                    case 2:
                        Console.Write("Informe o tamanho do vetor: ");
                        tamanho = int.Parse(Console.ReadLine());

                        float[] numeros1 = new float[tamanho];

                        for (int i = 0; i < tamanho; i++)
                        {
                            Console.Write("Informe o número {0}: ", i + 1);
                            numeros1[i] = float.Parse(Console.ReadLine());
                        }

                        float soma1 = 0;

                        for (int i = 0; i < tamanho; i++)
                        {
                            soma1 += numeros1[i];
                        }

                        float media1 = soma1 / tamanho;

                        Console.WriteLine("Números maiores ou iguais à média:");

                        for (int i = 0; i < tamanho; i++)
                        {
                            if (numeros1[i] >= media1)
                                Console.WriteLine(numeros1[i]);
                        }

                        break;

                    case 3:
                        Console.Write("Informe o tamanho do vetor: ");
                        tamanho = int.Parse(Console.ReadLine());

                        Random random = new Random();
                        int[] numeros2 = new int[tamanho];

                        for (int i = 0; i < tamanho; i++)
                        {
                            numeros2[i] = random.Next(1, 101); // Gera um número aleatório entre 1 e 100
                        }

                        Console.WriteLine("Números gerados:");

                        for (int i = 0; i < tamanho; i++)
                        {
                            Console.WriteLine(numeros2[i]);
                        }
                        break;

                    case 4:
                        Console.Write("Informe o número de assinaturas: ");
                        int quantidade = int.Parse(Console.ReadLine());

                        List<string> nomes = new List<string>();

                        for (int i = 0; i < quantidade; i++)
                        {
                            Console.Write("Informe o nome {0}: ", i + 1);
                            string nome = Console.ReadLine();
                            nomes.Add(nome);
                        }

                        Console.WriteLine("Nomes em ordem reversa:");

                        for (int i = nomes.Count - 1; i >= 0; i--)
                        {
                            Console.WriteLine(nomes[i]);
                        }
                        break;

                    case 5:
                        Console.Write("Informe o tamanho do vetor: ");
                        int tamanho1 = int.Parse(Console.ReadLine());


                        int[] numer = new int[tamanho1];
                        Random rando = new Random();

                        int pares = 0;
                        int impares = 0;

                        for (int i = 0; i < tamanho1; i++)
                        {
                            numer[i] = rando.Next(1, 101);
                            if (numer[i] % 2 == 0)
                                pares++;
                            else
                                impares++;
                        }

                        Console.WriteLine("Números gerados:");

                        for (int i = 0; i < tamanho1; i++)
                        {
                            Console.WriteLine(numer[i]);
                        }

                        Console.WriteLine("Quantidade de números pares: {0}", pares);
                        Console.WriteLine("Quantidade de números ímpares: {0}", impares);
                        break;
                }

            } while (exec != 0);

        }
    }
}
