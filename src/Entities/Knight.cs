namespace Rpg_POO.src.Entities
{
    public class Knight : Hero
    {
        public Knight(string Name, int Level, string HeroClass, int Health, int Mana) : base(Name, Level, HeroClass, Health, Mana)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroClass = HeroClass;
            this.Health = Health;
            this.Mana = Mana;
        }

        public override string Attack()
        {
            return this.Name + " swings his sword for " + this.Level + " damage!";
        }
        public override string TakeDamage(int Damage)
        {
            this.Health -= Damage;
            return this.Name + " takes " + Damage + " damage!";
        }

        public override string ShowStatus()
        {
            return $@"
    {this.Name} - Level {this.Level} - {this.HeroClass}
    Health: {this.Health} - Mana: {this.Mana}
            ";
        }
    }
}