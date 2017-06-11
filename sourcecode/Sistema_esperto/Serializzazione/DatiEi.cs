using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;

namespace Sistema_esperto.Serializzazione
{
    [Serializable]
    class DatiEi
    {
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
        private string _testoParametro2Info;
        public string testoParametro2Info
        {
            get { return _testoParametro2Info; }
            set { _testoParametro2Info = value; }
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
        //-----------misure parametro 2------------------------
        private string _misura52;
        public string misura52
        {
            get { return _misura52; }
            set { _misura52 = value; }
        }
        private string _misura42;
        public string misura42
        {
            get { return _misura42; }
            set { _misura42 = value; }
        }
        private string _misura32;
        public string misura32
        {
            get { return _misura32; }
            set { _misura32 = value; }
        }
        private string _misura22;
        public string misura22
        {
            get { return _misura22; }
            set { _misura22 = value; }
        }
        private string _misura12;
        public string misura12
        {
            get { return _misura12; }
            set { _misura12 = value; }
        }
        //------------misure parametro 3-----------------------
        private string _misura53;
        public string misura53
        {
            get { return _misura53; }
            set { _misura53 = value; }
        }
        private string _misura43;
        public string misura43
        {
            get { return _misura43; }
            set { _misura43 = value; }
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

        public DatiEi()
        {
    
        }
    }
}
