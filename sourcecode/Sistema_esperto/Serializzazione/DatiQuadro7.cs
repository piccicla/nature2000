using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;

namespace Sistema_esperto.Serializzazione
{
    [Serializable]
    class DatiQuadro7
    {
        //proprieta'da passare al costruttore del quadro1        
        private double _limiteEcumNoRedList;
        public double limiteEcumNoRedList
        {
            get { return _limiteEcumNoRedList; }
            set { _limiteEcumNoRedList = value; }
        }
        private double _limiteEcumRedList;
        public double limiteEcumRedList
        {
            get { return _limiteEcumRedList; }
            set { _limiteEcumRedList = value; }
        }

        public DatiQuadro7()
        {

        }
    }
}
