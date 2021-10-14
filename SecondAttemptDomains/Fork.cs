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
        /// <summary>
        /// Прибыль вилки в процентах
        /// </summary>
        public double ProfitForkPercent { get; set; }
        /// <summary>
        /// Время жизни вилки
        /// </summary>
        public int TimeOfLifeFork { get; set; }
        /// <summary>
        /// Вид спорта
        /// </summary>
        public Sports Sport { get; set; }
        /// <summary>
        /// Первая ставка
        /// </summary>
        public Bet FirstBet { get; set; }
        /// <summary>
        /// Вторая ставка
        /// </summary>
        public Bet SecondBet { get; set; }
    }
}
