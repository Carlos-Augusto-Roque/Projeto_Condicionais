using System;

namespace Projeto_Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            //variáveis
            float nota1, nota2, nota3, media; //float tipo de variável para números a serem calculados , criado variáveis para notas e média
            string nomeCompleto; //string tipo de variável para texto , criado variável para o nome completo do aluno
    
            //entrada de dados
            Console.WriteLine("Digite o nome do aluno"); // WriteLine é o comando que exibirá o que estiver escrito entre " " no console
            nomeCompleto = Console.ReadLine(); //comando para armazenar o nome completo do aluno digitado nesse campo

            Console.Write("Digite a primeira nota: ");// WriteLine é o comando que exibirá o que estiver escrito entre " " no console
            nota1 = float.Parse(Console.ReadLine());//comando para armazenar a primeira nota digitada nesse campo transformando a variável string em float

            Console.Write("Digite a segunda nota: ");// WriteLine é o comando que exibirá o que estiver escrito entre " " no console
            nota2 = float.Parse(Console.ReadLine());//comando para armazenar a segunda nota digitada nesse campo transformando a variável string em float

            Console.Write("Digite a terceira nota: ");// WriteLine é o comando que exibirá o que estiver escrito entre " " no console
            nota3 = float.Parse(Console.ReadLine());//comando para armazenar a terceira nota digitada nesse campo transformando a variável string em float

            //processamento
            media = (nota1+nota2+nota3)/3; //comando para processar a média

            //exibir o resultado
            if(media>5){ //condicional SE (se media for maior que 5,aluno aprovado)
                //valor verdadeiro
                Console.WriteLine("O aluno "+nomeCompleto+" está Aprovado com a média de: "+media);
            }
            else{ //condicional SE NÂO (se media for menor ou igual que 5,aluno reprovado)
                //valor falso
                Console.WriteLine("O aluno "+nomeCompleto+" está Reprovado com a média de: "+media);
            }

        }
    }
}
