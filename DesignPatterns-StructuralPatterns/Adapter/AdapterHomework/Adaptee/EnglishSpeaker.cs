namespace AdapterHomework.Adaptee
{
    public class EnglishSpeaker : ISpeaker
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
