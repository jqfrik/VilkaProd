using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondAttemptDomains
{
    public class User
    {
        public long Id { get; set; }
        /// <summary>
        /// Логин пользователя
        /// </summary>
        public string Login { get; set; }
        /// <summary>
        /// Пароль пользователя
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// Активность пользователя
        /// </summary>
        public bool IsActive { get; set; }
    }
}
