﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.MoneyPart.Currency
{
    public interface ICurrency
    {
        string currencyName { get; set; }
        IMoney amount { get; }

        string DisplayAmount();
    }
}

