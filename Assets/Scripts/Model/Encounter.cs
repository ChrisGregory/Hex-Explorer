using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Model
{
    public class Encounter
    {
        public String Name { get; set; }
        public String Description { get; set; }
        public float Weight { get; set; }
        public List<Tag> Tags { get; set; }
    }
}
