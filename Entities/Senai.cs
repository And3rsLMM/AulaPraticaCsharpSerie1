using System;

namespace AulaPraticaCsharpSerie1.Entities
{
    public class Senai
    {
        public const string senai = "Seja bem vindo ao SENAI - Serviço Nacional de Aprendizagem Industrial";
        public void WelcomeMessage()
        {
            Console.WriteLine(senai);
        }
    }
}