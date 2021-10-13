using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    [Serializable]
    public class Fork
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public long Id { get; set; }
        /// <summary>
        /// время жизни вилки
        /// </summary>
        public TimeSpan Time { get; set; }

        /// <summary>
        /// прибыль вилки в процентах
        /// </summary>
        public Decimal Profit { get; set; }

        /// <summary>
        /// тип спорта
        /// </summary>
        public Sport Sport { get; set; }

        /// <summary>
        /// букмекеры,которые участвуют в вилке
        /// </summary>
        public BookmakersName Bookmakers { get; set; }
       
        /// <summary>
        /// Команды,играющие в первой ставке
        /// </summary>
        public Teams TeamsFirstStake { get; set; }

        /// <summary>
        /// Команды,играющие во второй ставке
        /// </summary>
        public Teams TeamsSecondStake { get; set; }

        /// <summary>
        /// состояние матча(счёт,период,тайм) в обоих букмекерах
        /// </summary>
        public MatchDatas MatchData { get; set; }

        /// <summary>
        /// ставка для первого букмекера в вилке
        /// </summary>
        public Bet FirstBet { get; set; }

        /// <summary>
        /// ставка для второго букмекера в вилке
        /// </summary>
        public Bet SecondBet { get; set; }

        /// <summary>
        /// время создания вилки
        /// </summary>
        public DateTime Creted { get; }

        public Fork(long id)
        {
            this.Creted = DateTime.Now;
            this.Id = id;
        }

        public Fork()
        {
            this.Creted = DateTime.Now;
        }
    }
}
