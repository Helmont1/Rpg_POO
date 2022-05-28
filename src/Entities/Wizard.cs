namespace Rpg_POO.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, string HeroClass, int Health, int Mana) : base(Name, Level, HeroClass, Health, Mana)
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

        public string Attack(int Bonus)
        {
            if (Bonus == 0)
            {
                return this.Name + " casts the 3rd tier magic spell: 'Fireball' for " + this.Level + " damage!";
            }
            else if (Bonus == 1)
            {
                Mana -= 10;
                return this.Name + " casts the 5th Tier magic spell: 'Dragon Lightning' for " + (this.Level + 20) + " damage!";
            }
            else if (Bonus == 2)
            {
                Mana -= 20;
                return this.Name + " casts the 8th Tier magic spell: 'Astral Smite' for " + (this.Level + 30) + " damage!";
            }
            else if (Bonus == 3)
            {
                Mana -= 30;
                return this.Name + " casts the 10th Tier magic spell: 'Grasp Heart' for " + (this.Level + 899) + " damage!";
            }
            else
            {
                return this.Name + " throws a stone at the opponent for " + 0 + " damage!";
            }
        }

        public override string TakeDamage(int Damage)
        {
            return this.Name + " should takes " + Damage + " damage, but he is a wizard, he can't be hurt!";
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