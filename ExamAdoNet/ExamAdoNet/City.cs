using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamAdoNet
{
    public class City
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Street street { get; set; }
    }
}
