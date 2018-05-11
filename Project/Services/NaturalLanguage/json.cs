using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLUInterface
{
    public class IntentRanking
    {
        public string name { get; set; }
        public double confidence { get; set; }
    }

    public class Intent
    {
        public string name { get; set; }
        public double confidence { get; set; }
    }

    public class RasaModel
    {
        public List<object> entities { get; set; }
        public List<IntentRanking> intent_ranking { get; set; }
        public string text { get; set; }
        public Intent intent { get; set; }
    }
}
