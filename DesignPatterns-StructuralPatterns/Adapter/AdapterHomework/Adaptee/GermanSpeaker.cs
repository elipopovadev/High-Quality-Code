using System;

namespace AdapterHomework.Adaptee
{
    public class GermanSpeaker : ISpeaker
    {
        public string AnswerTheQuestion(string words)
        {
            return words;
        }

        public string AskQuestion(string words)
        {
            return words;
        }
    }
}
