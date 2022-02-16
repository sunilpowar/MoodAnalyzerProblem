using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer
{
    public class MoodAnalyzer
    {
        public string Mood(string message)
        {
            if (message.ToLower().Contains(""))
            {
                return "SAD";
            }
            else
            {
                return "HAPPY";
            }
        }
    }
}
