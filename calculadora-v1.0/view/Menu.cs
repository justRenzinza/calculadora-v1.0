using System;
using model;
namespace view{
    public class Menu{

        private model.Calculadora calculadora1;
        public void Exibir(){   

            calculadora1 = new model.Calculadora();

            Console.WriteLine("---------------");
            Console.WriteLine("Escolha a operação:");
            Console.WriteLine("1. soma");
            Console.WriteLine("2. subtracao");
            Console.WriteLine("3. multiplicacao");
            Console.WriteLine("4. divisao");
            Console.WriteLine("5. sair");
            Console.WriteLine("---------------");
            Console.WriteLine("Lembre-se de escrever tudo minúsculo, ou com os números!");
            Console.Write("Digite qual opção você deseja: ");

            string operacao = Console.ReadLine();

            if(operacao == "sair" || operacao == "5"){
                Console.WriteLine("Você desejou sair, até mais!");
            }
            else{
                Console.WriteLine("Agora digite o primeiro número: ");
                int numero1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Agora digite o segundo número: ");
                int numero2 = int.Parse(Console.ReadLine());

                int resultado = calculadora1.Calcular(operacao, numero1, numero2);
                Console.WriteLine($"Resultado: {resultado}");
            }
        }
    }

}   