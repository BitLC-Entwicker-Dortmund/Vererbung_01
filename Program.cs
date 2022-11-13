using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vererbung_01 {
    class Program {
        static void Main ( string [ ] args ) {
            LKW oleg = new LKW ( );
            oleg.SetName ("Oleg sein Laster ;-)" );
            
            //Console.WriteLine ( oleg.GetName() );

            PKW pkw = new PKW ( );
            pkw.SetName ("Ein Standard PKW" );
            

            Auto roberts = new Auto ( );
            roberts.SetName ( "Roberts PKW");
            

            // Container
            Auto [ ] einArray = new Auto [3];
            einArray [ 0 ] = pkw;
            einArray [ 1 ] = oleg;
            einArray [ 2 ] = roberts;

            Console.WriteLine ( einArray[0].GetName());
            Console.WriteLine ( einArray[1].GetName());

            Console.WriteLine ( einArray[2].GetName() );
            Console.WriteLine ( "====== Behandlung von Konstruktoren in C# =====");

            Autofahrer af = new Autofahrer ( "Nick L.");
            Console.WriteLine ( af.GetName());

            Console.ReadLine ( );
        }
    }
}
