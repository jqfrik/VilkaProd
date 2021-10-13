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
        public ESport Sport { get; set; }

        /// <summary>
        /// букмекеры,которые участвуют в вилке
        /// </summary>
        public string Bookmakers
        { 
            get
            {
                return string.Format("{0} - {1}", (object)this.OneBet?.Bookmaker, (object)this.TwoBet?.Bookmaker);
            }
        }

        /// <summary>
        /// какие команды играют
        /// </summary>
        public string Teams
        {
            get
            {
                return string.Format("{0} - {1}", (object)this.OneBet?.Team, (object)this.TwoBet?.Team);
            }
        }

        /// <summary>
        /// состояние матча(счёт,период,тайм) в обоих букмекерах
        /// </summary>
        public string Other
        {
            get
            {
                return string.Format("{0} - {1}", (object)this.OneBet?.MatchData, (object)this.TwoBet?.MatchData);
            }
        }

        /// <summary>
        /// ставка для первого букмекера в вилке
        /// </summary>
        public Bet OneBet { get; set; }

        /// <summary>
        /// ставка для второго букмекера в вилке
        /// </summary>
        public Bet TwoBet { get; set; }

        /// <summary>
        /// время создания вилки
        /// </summary>
        public DateTime Creted { get; }

        /// <summary>
        /// Метаданные fork.K1 + fork.K2 для получения данных об актуальном Url
        /// </summary>
        public string CridId { get; set; }

        /// <summary>
        /// метаданные для первого букмекера
        /// </summary>
        public string K1 { get; set; }

        /// <summary>
        /// метаданные для второго букмекера
        /// </summary>
        public string K2 { get; set; }

        /// <summary>
        /// метаданные для получения данных об Url,Elid берётся из ссылки на позитиве
        /// </summary>
        public string Elid { get; set; }

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
