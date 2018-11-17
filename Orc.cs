namespace InterfacesDemo

{
    class Orc : Monster, IEquatable<Orc>, IAttacker<Orc>
    {
        private int Log;
        private double Damage;
        public Orc(string name, int level) : base(name, level)
        {
            this.Health = level * 1.5;
            this.Armour = Health * 5.0;
            this.Log = 7;
            this.Damage = level / Log;
        }

        public bool Equals(Orc other) => this.Level == other.Level;
        override public string ToString()
        {
            return this.Name;
        }
        public double Attack(double armour)
        {
            return this.Damage;
        }
        public void TakeDamage(double damage)
        {
            if (this.Armour > 0)
            {
                this.Armour = this.Armour - damage;
            }
            else if (this.Health > 0)
            {
                this.Health = this.Health - damage;
            }
        }
    }
}

