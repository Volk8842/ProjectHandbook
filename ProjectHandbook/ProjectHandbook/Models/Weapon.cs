using System.Collections.Generic;

namespace ProjectHandbook.Models
{
    public class Weapon
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int PtsCost { get; set; }

        public List<WeaponMode> WeaponModes { get; set; }
    }
}
