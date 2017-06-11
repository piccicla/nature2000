using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;

namespace Sistema_esperto.Serializzazione
{   
    [Serializable]
    class DatiQuadro1
    {
        //proprieta'da passare al costruttore del quadro1        
        private double _Qs1;
        public double Qs1
        {
            get { return _Qs1; }
            set { _Qs1 = value; }
        }

        private int _numQs1;
        public int numQs1
        {
            get { return _numQs1; }
            set { _numQs1 = value; }
        }

        private double _Qs2;
        public double Qs2
        {
            get { return _Qs2; }
            set { _Qs2 = value; }
        }

        private int _numQs2;
        public int numQs2
        {
            get { return _numQs2; }
            set { _numQs2 = value; }
        }
        private bool _sup;
        public bool sup
        {
            get { return _sup; }
            set { _sup = value; }
        }
        private int _raggio;
        public int raggio
        {
            get { return _raggio; }
            set { _raggio = value; }
        }
        private bool _qsOk;
        public bool qsOk
        {
            get { return _qsOk; }
            set { _qsOk = value; }
        }
	
        public DatiQuadro1() {
            /*Qs1 = 4.8;
            numQs1 = 3;
            Qs2 = 4.5;
            numQs2 = 4;
            sup = false;
            raggio=300;*/
        }
    }
}
