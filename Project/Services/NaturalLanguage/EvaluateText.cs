using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NLUInterface
{
    static class EvaluateText
    {
        public static void Evaluate(string Text, string Language)
        {
            if (Language == "EN")
            {
                EnglishIntent(Text);
            }
            if (Language == "VI")
            {
                VietnameseIntent(Text);
            }
        }

        public static event EventHandler FinishNLU;
        private static async void EnglishIntent(string text)
        {
            RasaModel NLUResult = await GetResult.English(text);
            FinishNLU?.Invoke(NLUResult, EventArgs.Empty);
        }

        public static async Task<RasaModel> EnglishIntentAsync(string text)
        {
            RasaModel NLUResult = await GetResult.English(text);
            return NLUResult;
        }

        public static async Task<RasaModel> VietnameseIntentAsync(string text)
        {
            string EnConverted = await GoogleTranslator.Translator.Vi2En(text);
            Debug.WriteLine(EnConverted);
            RasaModel NLUResult = await GetResult.Vietnamese(EnConverted);
            return NLUResult;
        }

        private static async void VietnameseIntent(string text)
        {
            string EnConverted = await GoogleTranslator.Translator.Vi2En(text);
            RasaModel NLUResult = await GetResult.Vietnamese(EnConverted);
            FinishNLU?.Invoke(NLUResult, EventArgs.Empty);
        }


    }
}
