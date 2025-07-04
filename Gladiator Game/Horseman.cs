namespace Gladiator_Game;

public class Horseman : Warrior
{
    public Horseman() : base(
        health: 100,
        minDamage: 20,
        maxDamage: 35,
        defense: 30,
        agility: new Random().Next(0, 5))
    {
    }
}
