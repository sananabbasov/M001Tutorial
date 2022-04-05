using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public string BAN { get; set; }
        public string QeydiyyatNomresi { get; set; }
        public int Benzin { get; set; }
        public int MaxBenzinTutumu { get; set; }
        public int CurrentKm { get; set; }
    }
}
