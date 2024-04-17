using System;

namespace Atividade_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*ATIVIDADE 1
            int dinheiro = 35;
            int horas = 8;

            int salario = dinheiro * horas;

            Console.WriteLine("Seu salário é : " + salario);*/



            /* ATIVIDADE 2
            int numero1 = 27;
            int numero2 = 16;

            int subtracao = numero1 - numero2;
            Console.WriteLine("Ela tem: " + subtracao + " Bombons");*/



            /*ATIVIDADE 3
            int numero01 = 12;
            int numero02 = 10;

            Console.WriteLine("Seus Numeros são: " + numero01 + " e " + numero02);

            int soma = numero01 + numero02;

            Console.WriteLine("Seu total é: " + soma);*/



            /*ATIVIDADE 4
            int numero1 = 300;
            int numero2 = 20;


            int divisao = numero1 / numero2;


            Console.WriteLine("Essa é a quantidade de caixas utilizadas: " + divisao);*/

            //ATIVIDADE 5
            double instalacao = 300;
            double limpeza = 150;
            double manutencao = 500;
            double desconto = 50;

            double total1 = instalacao - desconto;
            double total2 = limpeza - desconto;
            double total3 = manutencao - desconto;

            Console.WriteLine("O total é : " + total1 + " da limpeza");
            Console.WriteLine("O total é : " + total2 + " da instalação");
            Console.WriteLine("O total é : " + total3 + " da manutenção");
        }
    }
}
