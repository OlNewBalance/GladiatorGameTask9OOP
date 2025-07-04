namespace Gladiator_Game;

public class Spearman : Warrior
{
    Random random = new Random();

    public Spearman() : base(
        health: 100,
        minDamage: 5,
        maxDamage: 35,
        defense: 0,
        agility: new Random().Next(0, 5))
    {
    }
}
