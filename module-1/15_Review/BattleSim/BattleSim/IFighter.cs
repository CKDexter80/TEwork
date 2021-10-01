namespace BattleSim
{
    //interface inheritance
    public interface IFighter : ITakeDamage
    {

        string Name { get; }
        int Strength { get; }

        void Attack(ITakeDamage victim);
    }
}