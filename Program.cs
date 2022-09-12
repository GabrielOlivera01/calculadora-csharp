using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            bool novaOperacao;

            do
            {
                //Operação escolhida pelo usuário
                string? operacaoEscolhida = EscolheOperacao();

                //Valores para a operação
                var valores = PegaValores();
                float valor1 = valores[0];
                float valor2 = valores[1];

                switch (operacaoEscolhida)
                {
                    case "sum":
                        Somar(valor1, valor2);
                        break;
                    case "sub":
                        Subtrair(valor1, valor2);
                        break;
                    case "mul":
                        Multiplicar(valor1, valor2);
                        break;
                    case "div":
                        Dividir(valor1, valor2);
                        break;
                }

                novaOperacao = NovaOperacao();

            } while (novaOperacao == true);
        }

        static string EscolheOperacao()
        {
            Console.WriteLine("Informe a operação desejada: ");
            Console.WriteLine("(sum (para soma), sub (para subtração), mul (para multiplicação), div (para divisão))");

            string? operacaoEscolhida = Console.ReadLine();

            return operacaoEscolhida;
        }

        static float[] PegaValores()
        {
            float[] valores = new float[2];

            Console.WriteLine("Escolha o primeiro valor: ");
            valores[0] = float.Parse(Console.ReadLine());
            Console.WriteLine("Escolha o segundo valor: ");
            valores[1] = float.Parse(Console.ReadLine());

            Console.WriteLine(" ");

            return valores;
        }

        static bool NovaOperacao()
        {
            bool res = false;

            Console.WriteLine(" ");
            Console.WriteLine("Deseja realizar uma nova operação? (s) SIM || (n) NÃO");

            string? novaOperacao = Console.ReadLine();

            if (novaOperacao == "s")
            {
                res = true;
                return res;
            }

            return res;
        }

        //Operações da Calculadora
        static void Somar(float priValor, float segValor)
        {
            float resultadoOperacao = (priValor + segValor);
            Console.WriteLine($"O resultado da Soma é: {resultadoOperacao}");
        }

        static void Subtrair(float priValor, float segValor)
        {
            float resultadoOperacao = (priValor - segValor);
            Console.WriteLine($"O resultado da Subtração é: {resultadoOperacao}");
        }

        static void Multiplicar(float priValor, float segValor)
        {
            float resultadoOperacao = (priValor * segValor);
            Console.WriteLine($"O resultado da Multiplicação é: {resultadoOperacao}");
        }

        static void Dividir(float priValor, float segValor)
        {
            float resultadoOperacao = (priValor / segValor);
            Console.WriteLine($"O resultado da Divisão é: {resultadoOperacao}");
        }
    }
}
