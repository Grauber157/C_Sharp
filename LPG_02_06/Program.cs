using System;

public class Aluno
{
    public double n1, n2, n3, n4;

    public struct AlunoVariavel
    {
        public string nome;

        public int id;

    }

    //public string[] nome = {"Jorgi", "Carlito", "Jubiscleuda", "Claudinei", "Dejair"};
    //public int[] id = {1, 2, 3, 4, 5};

    //metodo para calculo semestral
    public void CalculoMedia(double n1, double n2, int x)
    {
        double sem;

        sem = (n1 + n2) / 2;

        Console.WriteLine("Nota Semestre" + x + ": " + sem);

        if(sem >= 6)
        {   
            Console.WriteLine("Aprovado");
        }
        else if(sem < 6 && sem >= 5)
        {
            Console.WriteLine("Recuperacao");
        }
        else
        {
            Console.WriteLine("Reprovado");
        }

    }

    //metodo para calculo anual
    public void CalculoMedia(double n1, double n2, double n3, double n4)
    {
        double resul;

        resul = (n1 + n2 + n3 + n4) / 4;

        Console.WriteLine("Nota Anual: " + resul);

        if (resul >= 6)
        {
            Console.WriteLine("Aprovado");
        }
        else if (resul < 6 && resul >= 5)
        {
            Console.WriteLine("Recuperacao");
        }
        else
        {
            Console.WriteLine("Reprovado");
        }
    }

}



public class Turma
{
    public int ano = 2;

}



public class Curso
{
    public string curso = "informatica";

}



class program
{
    static void Main()
    {
        double resultado;

        Aluno a = new Aluno();
        Turma t = new Turma();
        Curso c = new Curso();

        Console.WriteLine("1-Notas Semestrais \n2-Notas Anuais");
        resultado = Convert.ToDouble(Console.ReadLine());

        Aluno.AlunoVariavel[] av = new Aluno.AlunoVariavel[4];

        switch (resultado)
        {
            case 1:
                {
                    Console.WriteLine("Nota 1: ");
                    a.n1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Nota 2: ");
                    a.n2 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Nota 3: ");
                    a.n3 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Nota 4: ");
                    a.n4 = Convert.ToDouble(Console.ReadLine());

                    a.CalculoMedia(a.n1, a.n2, 1);
                    a.CalculoMedia(a.n3, a.n4, 2);

                    break;
                }

            case 2:
                {
                    Console.WriteLine("Nota 1: ");
                    a.n1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Nota 2: ");
                    a.n2 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Nota 3: ");
                    a.n3 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Nota 4: ");
                    a.n4 = Convert.ToDouble(Console.ReadLine());

                    a.CalculoMedia(a.n1, a.n2, a.n3, a.n4);

                    break;
                }

        }

        //Fazer switch case para escolha das opções no menu

        //Metodos para atribuir valores às variáveis 

    }
}