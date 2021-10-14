using SecondAttemptDomains.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondAttemptDomains
{
    public class Fork
    {
        public long Id { get; set; }

        public double ProfitFork { get; set; }

        public int TimeOfLifeFork { get; set; }

        public Sports Sport { get; set; }

        public Bet FirstBet { get; set; }

        public Bet SecondBet { get; set; }
    }
}
