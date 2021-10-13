using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.NonCommon
{
    public class Bookmaker
    {
        public Bookmakers Ebookmaker { get; set; }

        public string Url { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public double Balance { get; set; }
    }
}
