namespace Gladiator_Game;

public class Skirmisher : Warrior
{
    Random random = new Random();

    public Skirmisher() : base(
        health: 100,
        minDamage: 5,
        maxDamage: 30,
        defense: 0,
        agility: new Random().Next(0, 4))
    {
    }
}
