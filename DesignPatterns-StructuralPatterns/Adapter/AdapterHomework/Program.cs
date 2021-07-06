using AdapterHomework.Adaptee;
using AdapterHomework.Adapter;
using System;

namespace AdapterHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            ITarget consult = new Translator();

            ISpeaker Borko = new EnglishSpeaker();
            string question = Borko.AskQuestion("How are you?");
            Console.WriteLine(consult.TranslateToOtherPerson(question, "German"));

            Console.WriteLine();

            ISpeaker Diederich = new GermanSpeaker();
            string answer = Diederich.AnswerTheQuestion("Hallo!");
            Console.WriteLine(consult.TranslateToOtherPerson(answer, "English"));
        }
    }
}
