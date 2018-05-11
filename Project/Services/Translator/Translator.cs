using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleTranslator
{
    public static class Translator
    {
        private static TranslateCore TranslateCore = new TranslateCore();

        public static Task<string> Vi2En(string input)
        {
            return Task.Run(() =>
            {
                return TranslateCore.Translate(input, "Vietnamese", "English");
            });
        }

        public static Task<string> En2Vi(string input)
        {
            return Task.Run(() =>
            {
                return TranslateCore.Translate(input, "English", "Vietnamese");
            });
        }

    }
}
