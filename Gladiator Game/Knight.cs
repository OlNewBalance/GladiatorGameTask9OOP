namespace Gladiator_Game
{
    public class Knight : Warrior
    {
        Random random = new Random();

        public Knight() : base(
            health: 100,
            minDamage: 20,
            maxDamage: 50,
            defense: 60,
            agility: new Random().Next(0, 2))
        {
        }
    }
}
