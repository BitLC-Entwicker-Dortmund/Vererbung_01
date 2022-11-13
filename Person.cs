using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vererbung_01 {
    class Person {
        private string name;
        //public Person ( ) { }

        public Person ( string name ) {
            this.name = name;
        }

        public void SetName(string name ) {
            this.name = name;
        }

        public string GetName ( ) {
            return name;
        }
    }
}
