using System;
using System.Collections.Immutable;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

//made by Gabriel F. Dias   2ºINFO 09/06/2023

public class Aluno
{
    public double n1, n2, n3, n4;

    //struct para criar vetores dos alunos
    public struct AlunoVariavel
    {
        public string nome;
        public double notaAnual;
        public double notaSemestral1;
        public double notaSemestral2;
        public int id;

    }

    //metodo para calculo do SEMESTRE
    public double CalculoMedia(double n1, double n2, int x)
    {
        double sem;
        sem = (n1 + n2) / 2;

        return sem;
    }

    //metodo para calculo do ANO
    public double CalculoMedia(double n1, double n2, double n3, double n4)
    {
        double resul;
        resul = (n1 + n2 + n3 + n4) / 4;

        return resul;
    }
    
    //metodo para mostrar dados SEMESTRE
    public void MostrarResultado(string nome, int id, string curso, int turma, double s1, double s2, string situacao)
    {
        Console.WriteLine("\nAluno: " + nome);
        Console.WriteLine("ID: " + id);
        Console.WriteLine("Turma: " + turma + curso);
        Console.WriteLine("Nota Semestre 1: " + s1);
        Console.WriteLine("Nota Semestre 2: " + s2);
        Console.WriteLine("Situacao: " + situacao);
    }

    //metodo para mostrar dados ANO
    public void MostrarResultado(string nome, int id, string curso, int turma, double ano, string situacao)
    {
        Console.WriteLine("\nAluno: " + nome);
        Console.WriteLine("ID: " + id);
        Console.WriteLine("Turma: " + turma + curso);
        Console.WriteLine("Nota Ano: " + ano);
        Console.WriteLine("Situacao: " + situacao);
    }
}

public class Turma
{
    //struct para criar vetor 'ano'
    public struct TurmaVariavel
    {
        public int ano;
    }
}

public class Curso
{
    //struct para criar vetor 'curso'
    public struct CursoVariavel
    {
        public string curso;
    } 
}

//Programa principal
class program
{
    static void Main()
    {
        //atributos para transportar valores para os parâmetros
        double resultado;
        double nota1;
        double nota2;
        double resul;

        //atributos do usúario
        string nome = "Gabriel";
        string curso = "-INFO";
        string situacao;
        int id = 16;
        int ano = 2;

        //instancia das classes
        Aluno a = new Aluno();
        Turma t = new Turma();
        Curso c = new Curso();

        //criacao dos vetores
        Aluno.AlunoVariavel[] av = new Aluno.AlunoVariavel[5];
        Turma.TurmaVariavel[] tv = new Turma.TurmaVariavel[5];
        Curso.CursoVariavel[] cv = new Curso.CursoVariavel[5];

        Console.WriteLine("1-Notas Semestrais \n2-Notas Anuais \n3-Relatorio Alunos");
        resultado = Convert.ToDouble(Console.ReadLine());

        //estrutura de escolha
            switch (resultado)
            {
                //case para opção SEMESTRE
                case 1:
                    {
                        //metodos 'WriteLine()' e 'ReadLine' para atribuir valor às variáveis das notas para os metodos 'CalculoMedia()'
                        Console.WriteLine("Nota 1: ");
                        a.n1 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Nota 2: ");
                        a.n2 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Nota 3: ");
                        a.n3 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Nota 4: ");
                        a.n4 = Convert.ToDouble(Console.ReadLine());

                        //sobrecarga de metodos para calcular SEMESTRE 1 e 2
                        nota1 = a.CalculoMedia(a.n1, a.n2, 1);
                        nota2 = a.CalculoMedia(a.n3, a.n4, 2);

                        //media da nota dos dois SEMESTRES para estrutura condicional
                        resul = (nota1 + nota2)/2;

                        //estrutura condicional para atribuir valor a variavel 'situacao' usando a nota como parâmetro
                        if (resul >= 6 && resul >= 6)
                        {
                            situacao = "Aprovado";
                        }
                        else if (resul < 6 && resul >= 5)
                        {
                            situacao = "Recuperacao";
                        }
                        else
                        {
                            situacao = "Reprovado";
                        }

                        //metodo para mostrar os dados ANUAL do usúario principal
                        a.MostrarResultado(nome, id, curso, ano, nota1, nota2, situacao);

                        break;
                    }

                //case para opção ANO
                case 2:
                    {
                        //metodos 'WriteLine()' e 'ReadLine' para atribuir valor às variáveis das notas para o metodo 'CalculoMedia()'
                        Console.WriteLine("Nota 1: ");
                        a.n1 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Nota 2: ");
                        a.n2 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Nota 3: ");
                        a.n3 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Nota 4: ");
                        a.n4 = Convert.ToDouble(Console.ReadLine());

                        //atribuindo valor a variavel 'nota1' para entrar no metodo 'MostrarResultado()'
                        nota1 = a.CalculoMedia(a.n1, a.n2, a.n3, a.n4);

                        //estrutura condicional para atribuir valor a variavel 'situacao' usando a nota como parâmetro
                        if (nota1 >= 6)
                        {
                            situacao = "Aprovado";
                        }
                        else if (nota1 < 6 && nota1 >= 5)
                        {
                            situacao = "Recuperacao";
                        }
                        else
                        {
                            situacao = "Reprovado";
                        }

                        //metodo para mostrar os dados ANUAL do usúario principal
                        a.MostrarResultado(nome, id, curso, ano, nota1, situacao);

                        break;
                    }

                //case para digitar outros 5 usúarios
                case 3:
                    {
                        //atribuição de valor para os vetores
                        av[0].nome = "Diego";
                        av[1].nome = "Vinicios";
                        av[2].nome = "Dejair";
                        av[3].nome = "Claudiane";
                        av[4].nome = "Rafaela";

                        av[0].id = 1;
                        av[1].id = 2;
                        av[2].id = 3;
                        av[3].id = 4;
                        av[4].id = 5;

                        av[0].notaAnual = 6;
                        av[1].notaAnual = 1;
                        av[2].notaAnual = 10;
                        av[3].notaAnual = 5;
                        av[4].notaAnual = 9;

                        tv[0].ano = 2;
                        tv[1].ano = 2;
                        tv[2].ano = 3;
                        tv[3].ano = 2;
                        tv[4].ano = 3;

                        cv[0].curso = "-INFO";
                        cv[1].curso = "-ADM";
                        cv[2].curso = "-INFO";
                        cv[3].curso = "-INFO";
                        cv[4].curso = "-INFO";

                        for (int i = 0; i != 5; i++)
                        {
                            Console.WriteLine("\nAluno: " + av[i].nome);
                            Console.WriteLine("ID: " + av[i].id);
                            Console.WriteLine("Turma: " + tv[i].ano + cv[i].curso);
                            Console.WriteLine("Nota Ano: " + av[i].notaAnual);
                        }

                        break;
                    }
            }
    }
}