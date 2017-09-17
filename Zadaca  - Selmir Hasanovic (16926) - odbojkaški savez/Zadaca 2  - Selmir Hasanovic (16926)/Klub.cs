using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zadaca_2___Selmir_Hasanovic__16926_
{
    [Serializable()]
    public partial class Klub
    {
        private bool _prefiksBOK;

        public bool PrefiksBOK
        {
            get { return _prefiksBOK; }
            set { _prefiksBOK = value; }
        }
        private bool _prefiksHOK;

        public bool PrefiksHOK
        {
            get { return _prefiksHOK; }
            set { _prefiksHOK = value; }
        }
        private bool _prefiksMOK;

        public bool PrefiksMOK
        {
            get { return _prefiksMOK; }
            set { _prefiksMOK = value; }
        }
        private bool _prefiksOK;

        public bool PrefiksOK
        {
            get { return _prefiksOK; }
            set { _prefiksOK = value; }
        }
        private bool _prefiksSOK;

        public bool PrefiksSOK
        {
            get { return _prefiksSOK; }
            set { _prefiksSOK = value; }
        }
        private bool _prefiksŽOK;

        public bool PrefiksŽOK
        {
            get { return _prefiksŽOK; }
            set { _prefiksŽOK = value; }
        }
        private string _naziv;

        public string Naziv
        {
            get { return _naziv; }
            set { _naziv = value; }
        }
        private string _mjesto;

        public string Mjesto
        {
            get { return _mjesto; }
            set { _mjesto = value; }
        }
        private string _telefon;

        public string Telefon
        {
            get { return _telefon; }
            set { _telefon = value; }
        }
        private string _adresa;

        public string Adresa
        {
            get { return _adresa; }
            set { _adresa = value; }
        }
        private string _prefiks;

        public string Prefiks
        {
            get { return _prefiks; }
            set { _prefiks = value; }
        }

        public Klub() { }
        public Klub(bool _prefiksBOK, bool p2, bool p3, bool p4, bool p5, bool p6, string p7, string p8, string p9, string p10)
        {
            // TODO: Complete member initialization
            this._prefiksBOK = _prefiksBOK;
            this._prefiksHOK = p2;
            this._prefiksMOK = p3;
            this._prefiksOK = p4;
            this._prefiksSOK = p5;
            this._prefiksŽOK = p6;
            this._naziv = p7;
            this._mjesto = p8;
            this._telefon = p9;
            this._adresa = p10;
            OdabirPrefiksa();
        }
        private void OdabirPrefiksa() 
        {
            if(_prefiksBOK) _prefiks = "BOK";
            else if(_prefiksHOK) _prefiks = "HOK";
            else if(_prefiksMOK) _prefiks = "MOK";
            else if(_prefiksOK) _prefiks = "OK";
            else if(_prefiksSOK) _prefiks = "SOK";
            else if(_prefiksŽOK) _prefiks = "ŽOK";
        }
        public override string ToString()
        {
            return this._prefiks + " " + this.Naziv;
        }
    }
}
