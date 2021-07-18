using System;

namespace GitPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Hello1.HelloWorld();
            Hello2.HelloWorld();
            Hello3.HelloWorld();

            FuncionalidadeA.DoWork();
            FuncionalidadeB.DoWork();
            FuncionalidadeC.DoWork();
            FuncionalidadeD.DoWork();
            FuncionalidadeE.DoWork();
            FuncionalidadeF.DoWork();
            // Faz uma leitura para que o usuário possa visualizar o console antes de fechar o programa
            Console.ReadKey();
        }
    }
}
