﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
    public class Orange:Fruit
    {
        public override string GetColor()
        {
            return base.GetColor()+"Апельсин оранжевий";
        }
    }
}
