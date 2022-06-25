namespace Rpg_POO.src.Entities
{
    public class Priest : Hero
    {
        public Priest(string Name, int Level, string HeroClass, int Health, int Mana) : base(Name, Level, HeroClass, Health, Mana)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroClass = HeroClass;
            this.Health = Health;
            this.Mana = Mana;
        }

        public override string Attack() 
        {
            return this.Name + " casts a spell for " + this.Level + " damage!";
        }

    }
}