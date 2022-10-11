// See https://aka.ms/new-console-template for more information
using System.Text;
using System.Text.RegularExpressions;

namespace ExemploArrayDeStrings
{
    class Program
    {

        public static void Main(string[] args)
        {
            SelecaoDeDesafio();

        }

        public static void Continuar()
        {
            Console.WriteLine("Gostaria de Repetir o processo?");
            Console.WriteLine("1 - Novo Teste");
            Console.WriteLine("2 - Sair");
            string continuar = Console.ReadLine() ?? "2";
            if (continuar == "1")
            {
                Console.Clear();
                SelecaoDeDesafio();
            }
            else
            {
                Environment.Exit(0);
            }
        }

        public static void SelecaoDeDesafio()
        {
            Console.WriteLine("Digite o valor numeral referente ao qual teste gostaria de verificar e aperte Enter por favor :");
            Console.WriteLine("1 - para Multiplicação");
            Console.WriteLine("2 - para nomes");
            Console.WriteLine("3 - sair");
            string retorno = Console.ReadLine() ?? "a";

            if (retorno.All(char.IsDigit) && (retorno == "1" || retorno == "2" || retorno == "3"))
            {
                switch (retorno)
                {
                    case "1":
                        MultiplicacaoNumero();
                        break;
                    case "2":
                        Ordenacao();
                        break;
                    case "3":
                        break;

                }
            }
            else
            {
                Console.WriteLine("Favor Digitar somente numeros 1, 2 ou 3");
                SelecaoDeDesafio();
            }
            Continuar();
        }
        public static void MultiplicacaoNumero()
        {
            Console.WriteLine("Digite um numero maior que 0 e aperte Enter por favor");
            string retorno = Console.ReadLine() ?? "a";
            int num, soma = 0;

            if (retorno.All(char.IsDigit))
            {
                num = Convert.ToInt32(retorno);

                for (int i = 1; i <= num; i++)
                {
                    soma += i;
                }
                Console.WriteLine("O resultado é: " + soma);
            }

            else
            {
                Console.WriteLine("Favor Digitar somente numeros");
                MultiplicacaoNumero();
            }
        }

        public static void Ordenacao()
        {
            Console.WriteLine("Digite uma sequencia de frases separadas por virgula e aperte Enter por favor");
            string retorno = Console.ReadLine();
            string[] array = retorno.Split(",");
            foreach (var item in array)
            {
                Regex rgx = new Regex(@"([^rs])(?=\1+)|(rr)(?=r+)|(ss)(?=s+)", RegexOptions.Compiled);
                string resumida = rgx.Replace(item, "");
                Console.WriteLine(resumida);
            }

        }

    }
}
