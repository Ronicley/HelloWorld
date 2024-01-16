using ModuloCalculadora;

namespace CalculadoraConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var continuar = true;
            while (continuar)
            {
                double resultado = 0;

                Console.WriteLine("Escolha a operação: 1-Soma, 2-Subtração, 3-Multiplicação, 4-Divisão");
                var operacao = Console.ReadLine(); // le opção do usuario

                Console.Write("Digite um número: "); // le o numero digitado
                var numero1 = double.Parse(Console.ReadLine()); // transforma em numero

                Console.Write("Digite outro número: ");
                var numero2 = double.Parse(Console.ReadLine());

                // Realiza operação escolhida
                if (operacao == "1")
                    resultado = OperacoesAritimeticas.Adicao(numero1, numero2);
                else if (operacao == "2")
                    resultado = OperacoesAritimeticas.Subtracao(numero1, numero2);
                else if (operacao == "3")
                    resultado = OperacoesAritimeticas.Multiplicacao(numero1, numero2);
                else if (operacao == "4")
                    resultado = OperacoesAritimeticas.Divisao(numero1, numero2);
                else
                    Console.WriteLine("Opção inválida. Por favor, tente novamente.");

                Console.WriteLine("Resultado: " + resultado);

                Console.WriteLine();
                Console.Write("Deseja continuar? S/N ");
                if (Console.ReadLine() == "N" || Console.ReadLine() == "n")
                    continuar = false;
                else
                    Console.WriteLine();
            }
        }
    }
}

