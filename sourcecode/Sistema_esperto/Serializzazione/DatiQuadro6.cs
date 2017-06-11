using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;

namespace Sistema_esperto.Serializzazione
{
    [Serializable]
    class DatiQuadro6
    {
        //proprieta'da passare al costruttore del quadro1        
        private double _limitePs;
        public double limitePs
        {
            get { return _limitePs; }
            set { _limitePs = value; }
        }

        public DatiQuadro6()
        {

        }
    }
}
