﻿using System;
using System.Collections.Generic;

#nullable disable

namespace GladiatorDemo.Models
{
    public partial class AdminDetail
    {
        public int AdminId { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
    }
}
