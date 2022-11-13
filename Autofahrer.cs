using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vererbung_01 {
    class Autofahrer : Person {
        // Standard-Konstruktor
        //public Autofahrer ( ) : base ( ) {

        //}
        public Autofahrer ( string n) : base ( n ) {
            base.SetName ( n );
        }

    }
}
