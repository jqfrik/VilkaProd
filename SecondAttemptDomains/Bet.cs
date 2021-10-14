using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondAttemptDomains
{
    public class Bet
    {
        /// <summary>
        /// Название букмекера
        /// </summary>
        public string BookmakerName { get; set; }
        /// <summary>
        /// Команды,принимающие участие
        /// </summary>
        public Teams Teams { get; set; }
        /// <summary>
        /// Название лиги
        /// </summary>
        public string LeagueName { get; set; }
        /// <summary>
        /// Название ставки
        /// </summary>
        public string BetValue { get; set; }
        /// <summary>
        /// Коэффициент ставки
        /// </summary>
        public double Coefficient { get; set; }
    }
}
