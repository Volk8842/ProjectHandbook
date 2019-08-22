using Prism.Navigation;

using ProjectHandbook.Models;

namespace ProjectHandbook.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private UnitModel unitModel;

        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            this.UnitModel = new UnitModel
                                 {
                                     Name = "SICARIAN RUSTSTALKER",
                                     UnitStats = new UnitStatsModel
                                                     {
                                                         Move = "8''",
                                                         WeaponSkill = "3+",
                                                         BallisticSkill = "3+",
                                                         Strength = "4",
                                                         Toughness = "3",
                                                         Wounds = "2",
                                                         Attacks = "3",
                                                         Leadership = "6",
                                                         Save = "4+",
                                                         MaxCount = "-"
                                                     }
                                 };
            this.UnitModel.Weapons.Add(
                new WeaponModel { Name = "Chordclaw", Range = "Melee", Type = "Melee", Strength = "User", ArmorPenetration = "0", Damage = "D3", Abilities = "A chordclaw can only be used to make one attack each time this moel fights." });
            this.UnitModel.Weapons.Add(
                new WeaponModel { Name = "Transonic razor", Range = "Melee", Type = "Melee", Strength = "User", ArmorPenetration = "0", Damage = "1", Abilities = "Custom text" });
        }

        public UnitModel UnitModel
        {
            get => this.unitModel;
            set => this.SetProperty(ref this.unitModel, value);
        }
    }
}
