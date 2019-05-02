using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamAdoNet
{
    public class Country
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public City city { get; set; }
    }
}
