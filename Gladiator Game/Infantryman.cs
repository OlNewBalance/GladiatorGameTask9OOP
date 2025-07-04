namespace Gladiator_Game;

public class Infantryman : Warrior
{
    Random random = new Random();

    public Infantryman() : base(
        health: 100,
        minDamage: 10,
        maxDamage: 20,
        defense: 20,
        agility: new Random().Next(0, 20))
    {
    }
}
