using System.Collections.Generic;

namespace ProjectHandbook
{
    public class UnitModel
    {
        public string Name { get; set; }

        public UnitStatsModel UnitStats { get; set; }

        public List<WeaponModel> Weapons { get; } = new List<WeaponModel>();
    }
}
