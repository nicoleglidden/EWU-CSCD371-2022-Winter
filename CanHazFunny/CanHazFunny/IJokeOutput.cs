﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanHazFunny
{
    public interface IJokeOutput
    { 
        public string? Joke { get; set; }
        public void WriteJoke(string joke);
    }
}
