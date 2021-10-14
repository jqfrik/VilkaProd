﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondAttemptDomains
{
    public class User
    {
        public long Id { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public string Hash { get; set; }

        public bool IsActive { get; set; }
    }
}
