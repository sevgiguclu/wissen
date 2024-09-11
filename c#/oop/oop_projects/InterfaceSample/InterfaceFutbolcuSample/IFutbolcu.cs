﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceFutbolcuSample
{
    interface IFutbolcu
    {
        string AdSoyad { get; set; }
        int FormaNumarasi { get; set; }
        byte SutGucu { get; set; }
        byte Refleks { get; set; }

        byte Agresiflik { get; set; }

        byte Dayaniklilik { get; set; }

        bool SolAYakMi { get; set; }

        string SutCek();
        string TopKurtar();
        string Sakatlandi();
    }
}
