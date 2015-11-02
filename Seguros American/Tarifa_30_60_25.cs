using System;
using System.Collections.Generic;


namespace Tarifa.BindingDataGridView.Clases
{
    internal class Tarifa_30_60_25
    {
        public int dias { get; set; }

        public float pb { get; set; }

        public float gm { get; set; }

        public float dp { get; set; }

        public float calculatotal 
        {
            get
            {
                var t = (dias*(pb +gm +dp));
                return t ;            
             }
        }

        public Tarifa_30_60_25()
        {
            dias = 0;
            pb = 0;
            gm = 0;
            dp = 0;

        }

    }
}
