using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;

namespace Sistema_esperto.Serializzazione
{
    [Serializable]
    class DatiPaa
    {
        //proprieta'da passare al costruttore del quadro1        
        //proprieta'da serializzare       
        //testo parametri
        private string _testoParametro1;
        public string testoParametro1
        {
            get { return _testoParametro1; }
            set { _testoParametro1 = value; }
        }
        private string _testoParametro2;
        public string testoParametro2
        {
            get { return _testoParametro2; }
            set { _testoParametro2 = value; }
        }
        private string _testoParametro3;
        public string testoParametro3
        {
            get { return _testoParametro3; }
            set { _testoParametro3 = value; }
        }
        //testi misure
        //--------misura parametro 1------------------------
        private string _misura51;
        public string misura51
        {
            get { return _misura51; }
            set { _misura51 = value; }
        }
        private string _misura41;
        public string misura41
        {
            get { return _misura41; }
            set { _misura41 = value; }
        }
        private string _misura31;
        public string misura31
        {
            get { return _misura31; }
            set { _misura31 = value; }
        }
        private string _misura21;
        public string misura21
        {
            get { return _misura21; }
            set { _misura21 = value; }
        }
        private string _misura11;
        public string misura11
        {
            get { return _misura11; }
            set { _misura11 = value; }
        }
        //-----------misure parametro 2sx-----------------------
        private string _misurasx52;
        public string misurasx52
        {
            get { return _misurasx52; }
            set { _misurasx52 = value; }
        }
        private string _misurasx42;
        public string misurasx42
        {
            get { return _misurasx42; }
            set { _misurasx42 = value; }
        }
        private string _misurasx32;
        public string misurasx32
        {
            get { return _misurasx32; }
            set { _misurasx32 = value; }
        }
        private string _misurasx22;
        public string misurasx22
        {
            get { return _misurasx22; }
            set { _misurasx22 = value; }
        }
        private string _misurasx12;
        public string misurasx12
        {
            get { return _misurasx12; }
            set { _misurasx12 = value; }
        }
        //-----------misure parametro 2dx-----------------------
        private decimal _misuradx52;
        public decimal misuradx52
        {
            get { return _misuradx52; }
            set { _misuradx52 = value; }
        }
        private decimal _misuradx42;
        public decimal misuradx42
        {
            get { return _misuradx42; }
            set { _misuradx42 = value; }
        }
        private decimal _misuradx32;
        public decimal misuradx32
        {
            get { return _misuradx32; }
            set { _misuradx32 = value; }
        }
        private decimal _misuradx22;
        public decimal misuradx22
        {
            get { return _misuradx22; }
            set { _misuradx22 = value; }
        }
        private decimal _misuradx12;
        public decimal misuradx12
        {
            get { return _misuradx12; }
            set { _misuradx12 = value; }
        }
        //------------misure parametro 3-----------------------
        private string _misura53;
        public string misura53
        {
            get { return _misura53; }
            set { _misura53 = value; }
        }
        
        private string _misura33;
        public string misura33
        {
            get { return _misura33; }
            set { _misura33 = value; }
        }
        private string _misura23;
        public string misura23
        {
            get { return _misura23; }
            set { _misura23 = value; }
        }
        private string _misura13;
        public string misura13
        {
            get { return _misura13; }
            set { _misura13 = value; }
        }
        //------------uso del valore di ps-----------------------
        private bool _isPsOk;

        public bool isPsOk
        {
            get { return _isPsOk; }
            set { _isPsOk = value; }
        }
	
        public DatiPaa()
        {

        }
    }
}
