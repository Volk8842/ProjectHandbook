using System.Collections.Generic;

namespace ProjectHandbook.Models
{
    public class UnitModel
    {
        public string Name { get; set; }

        public UnitStatsModel UnitStats { get; set; }

        public List<WeaponModel> Weapons { get; } = new List<WeaponModel>();

        public List<object> Abilities { get; } = new List<object>();

        public List<object> Psyker { get; } = new List<object>();

        public List<object> Specialists { get; } = new List<object>();

        public List<object> FactionKeyword { get; } = new List<object>();

        public List<object> Keywords { get; } = new List<object>();

    }
}
