using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MockAsssessment7a.Models
{
    public class Doughnut
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public int Calories { get; set; }
        public String PhotoURL { get; set; }
        public String[] Extras { get; set; }

        public Doughnut()
        {

        }
    }
}