namespace Rpg_POO.src.Entities
{
    public abstract class Hero
    {
        public string Name;
        public int Level;
        public string HeroClass;
        public int Health;
        public int Mana;

        public Hero(string Name, int Level, string HeroClass, int Health, int Mana)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroClass = HeroClass;
            this.Health = Health;
            this.Mana = Mana;
        }

        public override string ToString()
        {
            return this.Name + " " + this.Level + " " + this.HeroClass;
        }

        public virtual string Attack()
        {
            return this.Name + " attacks for " + this.Level + " damage!";
        }

        public virtual string TakeDamage(int Damage)
        {
            this.Health -= Damage;
            return this.Name + " takes " + Damage + " damage!";
        }

        public virtual string ShowStatus()
        {
            return this.Name + " " + this.Level + " " + this.HeroClass + " " + this.Health + " " + this.Mana;
        }
    }
}