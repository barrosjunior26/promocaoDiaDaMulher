namespace Exercicio23
{
    class PromocaoDiaDaMulher
    {
        public static void Main(String[] args)
        {
            /*Numa promoção exclusiva para o Dia da Mulher, uma loja quer dar descontos
            para todos, mas especialmente para mulheres.Faça um programa que leia nome,
            sexo e o valor das compras do cliente e calcule o preço com desconto. Sabendo
            que:
            -Homens ganham 5 % de desconto
            -Mulheres ganham 13 % de desconto*/

            //Declaração de variáveis
            int opcao = 0;

            do
            {
                //Solicitando ao usuário seu nome, sexo e valor das compras
                Console.Write("Digite seu nome e sobrenome: ");
                String nome = Console.ReadLine().ToUpper();
                Console.Write("Por favor, informe seu sexo, sendo (1) para feminino ou (2) para masculino: ");
                byte sexo = byte.Parse(Console.ReadLine());
                Console.Write("Informe o valor total de suas compras: R$");
                double compras = double.Parse(Console.ReadLine());

                //PROCESSAMENTO DOS DADOS - Condições de descontos para diferentes sexos
                if (sexo == 1)
                {
                    //Calculo de descontos para compras realizadas pelo sexo feminio
                    double comprasF = (compras * 13) / 100;
                    Console.WriteLine("Nome do cliente: " + nome + "\nSexo: Feminino" + "\nTotal de descontos: R$" + Math.Round(comprasF, 2) + "\nValor total das compras: R$" + Math.Round(compras, 2) + "\nValor total a pagar com desconto de 13%. R$" + Math.Round((compras - comprasF), 2));
                }
                else if (sexo == 2)
                {
                    //Calculo de descontos para compras realizadas pelo sexo feminio
                    double comprasM = (compras * 5) / 100;
                    Console.WriteLine("Nome do cliente: " + nome + "\nSexo: Masculino" + "\nTotal de descontos: R$" + Math.Round(comprasM, 2) + "\nValor total das compras: R$" + Math.Round(compras, 2) + "\nValor total a pagar com desconto de 5%. R$" + Math.Round((compras - comprasM), 2));
                }
                else
                {
                    Console.WriteLine("Entrada inválida!");
                }
                Console.Write("Digite 1 - NOVA OPERAÇÃO ou 0 - PARA SAIR: ");
                opcao = int.Parse(Console.ReadLine());
            } while(opcao != 0);
        }
    }
}