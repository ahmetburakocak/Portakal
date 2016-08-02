using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portakal.Model
{
    class Bilet
    {
        #region prop
        private int _kalkisID;
        private int _varisID;
        private string _kalkisYeri;
        private string _inisYeri;
        private DateTime _gidisTarihi;
        private DateTime _donusTarihi;
        private int _kisiSayisi;
        private int _BagajKilosu;
        private string _biletTipi;
        private bool _tekYonMu;

        public int KalkisID
        {
            get { return _kalkisID; }
            set { _kalkisID = value; }
        }
        
        public int VarisID
        {
            get { return _varisID; }
            set { _varisID = value; }
        }
       
        public string KalkisYeri
        {
            get { return _kalkisYeri; }
            set { _kalkisYeri = value; }
        }
       
        public string InisYeri
        {
            get { return _inisYeri; }
            set { _inisYeri = value; }
        }
      
        public DateTime GidisTarihi
        {
            get { return _gidisTarihi; }
            set { _gidisTarihi = value; }
        }
        
        public DateTime DonusTarihi
        {
            get { return _donusTarihi; }
            set { _donusTarihi = value; }
        }
       
        public int KisiSayisi
        {
            get { return _kisiSayisi; }
            set { _kisiSayisi = value; }
        }
        
        public int BagajKilosu
        {
            get { return _BagajKilosu; }
            set { _BagajKilosu = value; }
        }
        
        public string BiletTipi
        {
            get { return _biletTipi; }
            set { _biletTipi = value; }
        }

        
        public bool TekYonMu
        {
            get { return _tekYonMu; }
            set { _tekYonMu = value; }
        } 
        #endregion


    }
}
