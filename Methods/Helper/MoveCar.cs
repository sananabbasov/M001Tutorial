using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods.Helper
{
    public class MoveCar
    {
        public void HerekeBasla(int km, int benzin, int kmLitr)
        {
            Console.WriteLine("Nece km getmek isteyirsiniz.");
            var carKm = Console.ReadLine();


            int netice = Convert.ToInt32(carKm) * kmLitr / benzin;


            if (netice > benzin)
            {
                Console.WriteLine("Bu qeder yol gede bilmezsiniz.");
            }
            else
            {
                Console.WriteLine("Gedilen yol: " + (Convert.ToInt32(carKm) + km));
                Console.WriteLine("Benzin: " + (benzin - netice));
            }


        }
    }
}
