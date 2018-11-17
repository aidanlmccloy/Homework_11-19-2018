namespace InterfacesDemo
{
    interface IAttacker<T>
    {
        double Attack(double armour);
        void TakeDamage(double damage);
    }
}