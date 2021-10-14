using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondAttemptDomains
{
    /// <summary>
    /// Букмекер
    /// </summary>
    public class Bookmaker
    {
        /// <summary>
        /// Название букмекера
        /// </summary>
        public string BookmakerName { get; set; }
        /// <summary>
        /// Url букмекера
        /// </summary>
        public string Url { get; set; }
        /// <summary>
        /// Логин букмекера
        /// </summary>
        public string Login { get; set; }
        /// <summary>
        /// Пароль букмекера
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// Баланс букмекера
        /// </summary>
        public double Balance { get; set; }
    }
}
