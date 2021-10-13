using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;

namespace Common
{
    [Serializable]
    [ComplexType]
    public class Bet
    {
        [Key]
        public long Id { get; set; }
        /// <summary>
        /// букмекер,участвующую в вилке в конкретной ставке
        /// </summary>
        public EBookmakers Bookmaker { get; set; }

        /// <summary>
        /// Коэффициент ставки
        /// </summary>
        public Decimal Coef { get; set; }

        /// <summary>
        /// Повышается,понижается,стоит на месте коэффициент
        /// </summary>
        public EDirection Direction { get; set; }

        /// <summary>
        /// Идентификатор ставки в конкретной букмекерской конторе
        /// </summary>
        public string BetId { get; set; }

        /// <summary>
        /// Тип спорта в ставке
        /// </summary>
        public ESport Sport { get; set; }

        /// <summary>
        /// Название ставки (например ТБ 7.5Б)
        /// </summary>
        public string BetValue { get; set; }

        /// <summary>
        /// В скольких вилках участвует данная ставка
        /// </summary>
        public int ForksCount { get; set; }

        /// <summary>
        /// Идентификатор события
        /// </summary>
        public string EvId { get; set; }

        /// <summary>
        /// Метаданные для получения подробной информации о ставке
        /// </summary>
        public string OtherData { get; set; }

        /// <summary>
        /// //Команды или игроки,которые участвует в текущей ставке в конкретном 
        /// букмекере
        /// </summary>
        public string Team { get; set; }

        /// <summary>
        /// Состояние текущего поединка,матча(пример  1 тайм 22 min,2 партия, 2 сет, 1 тайм 21:44)
        /// </summary>
        public string MatchData { get; set; }

        /// <summary>
        /// Url текущей ставки ,который понадобится для запроса для получения актуальной информации по Url букмекера
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Инициатор,та ставка,которая была инициирующей стороной в появлении вилки
        /// </summary>
        public bool IsInitiator { get; set; }
    }
}