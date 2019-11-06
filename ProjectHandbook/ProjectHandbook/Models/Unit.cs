using System.Collections.Generic;
using ProjectHandbook.Enums;

namespace ProjectHandbook.Models
{
    public class Unit
    {
        public UnitRole Role { get; set; }

        public List<Model> Models { get; set; }
    }
}
