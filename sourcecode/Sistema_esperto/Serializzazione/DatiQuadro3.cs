using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;

namespace Sistema_esperto.Serializzazione
{
    [Serializable]
    class DatiQuadro3
    {
        private double _limiteEi;
        public double limiteEi
        {
            get { return _limiteEi; }
            set { _limiteEi = value; }
        }
        private double _limiteEcs;
        public double limiteEcs
        {
            get { return _limiteEcs; }
            set { _limiteEcs = value; }
        }
        private bool _varOR;

        public bool varOR
        {
            get { return _varOR; }
            set { _varOR = value; }
        }
    public DatiQuadro3(){
    
    }
    }
}
