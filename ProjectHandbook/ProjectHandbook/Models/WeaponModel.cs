using Prism.Mvvm;

namespace ProjectHandbook.Models
{
    public class WeaponModel : BindableBase
    {
        public string Name { get; set; }

        public string Range { get; set; }

        public string Type { get; set; }

        // public int ShotsCount { get; set; }

        public string Strength { get; set; }

        public string ArmorPenetration { get; set; }

        public string Damage { get; set; }

        public string Abilities { get; set; }

        public int Points { get; set; }
    }
}
