using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q331ny.HowToos
{
    public class HowToKlasse
    {

        #region Hændelser 
        public event EventHandler EventNavn;
        #endregion

        #region Felter (data)
        private int felt1;
        public int felt2; // NEJ TAK... brug egenskab
        #endregion

        #region Egenskaber
        // propfull
        private int _egenskab1;
        public int Egenskab1
        {
            get { return _egenskab1; }
            set { _egenskab1 = value; }
        }

        // prop
        public int Egenskab2 { get; set; }

        #endregion

        #region Metoder
        public void Metode1()
        {
            if (EventNavn != null)
                EventNavn(this, new EventArgs());
        }
        private void Metode2() { }
        #endregion

        #region Constructor og Destructor
        // ctor (default)
        public HowToKlasse()
        {
            // initialsering
        }

        // custom
        public HowToKlasse(int egenskab1)
        {
            //this._egenskab1 = egenskab1; nej
            this.Egenskab1 = egenskab1;
        }


        ~HowToKlasse()
        {
            // kører når objektet bliver slettet fra heap
        }
        #endregion
    }
}
