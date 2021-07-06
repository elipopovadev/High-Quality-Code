using AdapterHomework.Adaptee;
using System.Collections.Generic;

namespace AdapterHomework.Adapter
{
   public  class Translator : ITarget
    {
        private static readonly Dictionary<string, string> EnglishGermanDictionary = new Dictionary<string, string>
        {
            {"Hello!", "Hallo!" },
            {"How are you?", "Wie geht es dir?"},
            {"Nice to meet you!", "Freut mich, dich kennenzulernen!" },
        };

        private static readonly Dictionary<string, string> GermanEnglishDictionary = new Dictionary<string, string>
        {
            {"Hallo!", "Hello!"},
            {"How are you?", "Wie geht es dir?"},
            {"Freut mich, dich kennenzulernen!", "Nice to meet you!"},
        };

        public string TranslateToOtherPerson(string words, string languageToConvert)
        {
            if(languageToConvert == "German")
            {
                if (words == "Hello!")
                {
                    return EnglishGermanDictionary["Hello!"];
                }
                else if(words == "How are you?")
                {
                    return EnglishGermanDictionary["How are you?"];
                }
                else if(words == "Nice to meet you!")
                {
                    return EnglishGermanDictionary["Nice to meet you!"];
                }
                return "Convert Error!";
            }

            else if(languageToConvert == "English")
            {
                if (words == "Hallo!")
                {
                    return GermanEnglishDictionary["Hallo!"];
                }
                else if (words == "Wie geht es dir?")
                {
                    return GermanEnglishDictionary["Wie geht es dir?"];
                }
                else if (words == "Freut mich, dich kennenzulernen!")
                {
                    return GermanEnglishDictionary["Freut mich, dich kennenzulernen!"];
                }
                return "Convert Error!";
            }

            return "Unknown language";
        }
    }
}
