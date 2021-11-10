﻿using _8heti.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8heti.Entities
{
    public class BallFactory : IToyFactory
    {

        public Toy CreateNew()
        {
            return new Ball();
        }

    }
}
