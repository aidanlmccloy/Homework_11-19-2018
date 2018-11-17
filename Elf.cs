namespace InterfacesDemo

{
    class Elf : Monster, IEquatable<Elf>, IAttacker<Elf>
    {
        private int Arrow;
        private double Damage;
        public Elf(string name, int level) : base(name, level)
        {
            this.Health = level * 0.8;
            this.Armour = Health * 2.0;
            this.Arrow = 9;
            this.Damage = level / Arrow;
        }

        public bool Equals(Elf other) => this.Level == other.Level; 
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

 