
using Ex007.Models;

Console.WriteLine("Primeira nota do aluno");
double nota1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Segunda nota do aluno");
double nota2 = Convert.ToDouble(Console.ReadLine());



Aluno aluno1 = new Aluno(nota1, nota2);
aluno1.Validar();
