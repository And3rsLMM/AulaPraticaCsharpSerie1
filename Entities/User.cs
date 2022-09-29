using System;

namespace AulaPraticaCsharpSerie1.Entities
{
    public class UserSenai
    {
        public string Name { get; set; }
        public void NomeInPut()
        {
            Console.WriteLine("Por favor, digite seu nome: ");
            Name = Console.ReadLine();
        }
        
        public void NomeOutPut()
        {
            Console.WriteLine($"{Name} seja bem vindo SENAI!");
        }
    }
}