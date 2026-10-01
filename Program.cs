using System;

class program
{
    public class dados()
    {
        public string nome, curso;
        public int ra, semestre, faltas;
        public double p1, p2, media, mediadecimal; //tem que ser double pra utilizar o comando Math.Round

    }
    public class registro : dados
    {
        public registro()
        {
            nome = "flavio";
            curso = "SI";
            ra = 270183;
            semestre = 2;
            faltas = 3;
            p1 = 4;
            p2 = 6;
            media = (p1 + p2 * 2) / 3;
            mediadecimal = Math.Round(media, 2); //Math.Round(valor,2); é o mesmo que .toFixed(2) em JS, ele faz o numero ficar em decimal
        }
        public void exibe()
        {
            Console.WriteLine($"Olá {nome}, aqui estão as suas informaçoes de cadastro");
            Console.WriteLine($"Curso:{curso} | RA:{ra} | {semestre} Semestre | Faltas: {faltas}|  Nota P1:{p1} Nota P2 {p2} | Media: {media}");
        }
    }
    static void Main(string[] args)
    {
        registro dados = new registro();
        dados.exibe();
    }
}