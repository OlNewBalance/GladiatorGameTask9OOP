namespace Gladiator_Game;

public class Warrior
{
    public bool WarriorDie = false;
    public int MaxHealth;
    public int Health;
    public int MinDamage;
    public int MaxDamage;
    public int Defense;

    public Warrior(int health, int minDamage, int maxDamage, int defense, int agility)
    {
        MaxHealth = health;
        Health = MaxHealth;
        MinDamage = minDamage;
        MaxDamage = maxDamage;
        Defense = defense;
    }

    private static readonly Random random = new Random();
    public void Damaging(Warrior target)
    {
        if (target == this) return;
        if (target.Health > 0)
        {
            int attackDamage = random.Next(this.MinDamage, this.MaxDamage + 1);
            int calculatedDamage = Math.Max(1, attackDamage - target.Defense / 2);
            target.Health -= calculatedDamage;
            if (target.Health < 0) target.Health = 0;
            Console.WriteLine($"\n{this.GetType().Name} атакует {target.GetType().Name} " +
                              $"и наносит {calculatedDamage} урона!");
            Console.WriteLine($"Состояние здоровья жертвы ({target.GetType().Name}): {target.Health}");
        }
    }

    public void Healing(Warrior target)
    {
        if (target != this) return;
        if (target.Health > 0)
        {
            Health += 15;
            if (Health > MaxHealth)
                Health = MaxHealth;
            Console.WriteLine($"Лечение +15 HP. Теперь {target.Health} здоровья у цели.");
        }
        else if (target.Health == 100)
        {
            Console.WriteLine("Состояние здоровья максимальное!");
        }
    }

    public void Speak(Warrior target)
    {
        if (target == this) return;
        if (target.Health > 0)
        {
            if (target == null || target.Health <= 0) return;
            if (target.Defense > 0)
            {
                target.Defense -= 15;
                if (target.Defense < 0) target.Defense = 0;
                Console.WriteLine($"Уровень защиты жертвы упал! Сейчас у жертвы - {target.Defense} защиты!");
                int speakRoll = random.Next(1, 6);
                switch (speakRoll)
                {
                    case 1:
                        Console.WriteLine("\"Твой последний вздох станет музыкой для воронов!\"");
                        break;
                    case 2:
                        Console.WriteLine("\"Я сложу из твоих костей трон, и на нём буду судить твоих соратников!\"");
                        break;
                    case 3:
                        Console.WriteLine("\"Ты дрожишь… Хорошо. Пусть страх сделает твою смерть ещё горше!\"");
                        break;
                    case 4:
                        Console.WriteLine("\"Твой бог отвернулся от тебя — ибо я его новое орудие!\"");
                        break;
                    case 5:
                        Console.WriteLine("\"Беги. Пусть твои трусливые шаги станут погребальным маршем твоих павших!\"");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Смысла забалтывать нет...");
            }
        }
        else
        {
            Console.WriteLine("Увы... Слова мертвого, не будут услышаны...");
        }
    }

    public void EnemyTurn(Warrior target)
    {
        if (target != this) return;
        if (target == target)
        {
            if (target.Health > 0)
            {
                if (target == null || target.Health <= 0) return;
                int enemyTurnRoll = random.Next(1, 4);
            }
        }
    }
}
