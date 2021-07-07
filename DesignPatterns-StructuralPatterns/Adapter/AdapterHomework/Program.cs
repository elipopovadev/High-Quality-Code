using AdapterHomework.Adaptee;
using AdapterHomework.Adapter;
using System;

namespace AdapterHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            ITarget translator = new Translator();
            ISpeaker Borko = new EnglishSpeaker();
            ISpeaker Diederich = new GermanSpeaker();

            try
            {
                string question = Borko.AskQuestion("How are you?");
                Console.WriteLine(translator.TranslateToOtherPerson(question, "German"));
                Console.WriteLine();
                string answer = Diederich.AnswerTheQuestion("Hallo!");
                Console.WriteLine(translator.TranslateToOtherPerson(answer, "English"));
            }

            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
