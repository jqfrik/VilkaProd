using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondAttemptDomains
{
    public class Bet
    {
        public string BookmakerName { get; set; }

        public Teams Teams { get; set; }

        public string LeagueName { get; set; }

        public string BetValue { get; set; }

        public double Coefficient { get; set; }
    }
}
