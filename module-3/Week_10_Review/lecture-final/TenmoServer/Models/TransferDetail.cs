﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TenmoServer.Models
{
    public class TransferDetail : Transfer
    {
        public string From { get; set; }
        public string To { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
    }
}
