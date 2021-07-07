using AdapterHomework.Adaptee;
using System;
using System.Collections.Generic;

namespace AdapterHomework.Adapter
{
    public class Translator : ITarget
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

        public string TranslateToOtherPerson(string text, string targetLanguage)
        {
            if (targetLanguage == "German" && EnglishGermanDictionary.ContainsKey(text))
            {
                return EnglishGermanDictionary[text];
            }

            else if (targetLanguage == "German" && !EnglishGermanDictionary.ContainsKey(text))
            {
                throw new ArgumentException("Unknown text!");
            }

            else if (targetLanguage == "English" && GermanEnglishDictionary.ContainsKey(text))
            {
                return GermanEnglishDictionary[text];
            }

            else if(targetLanguage == "English" && !GermanEnglishDictionary.ContainsKey(text))
            {
                throw new ArgumentException("Unknown text!");
            }

            throw new ArgumentException("Unknown language!");
        }
    }
}
