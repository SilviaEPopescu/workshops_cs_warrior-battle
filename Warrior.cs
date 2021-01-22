using System;

class Warrior
{
    public string Name;
    public int Health;
    public int MaxAttack;
    public int MaxBlock;

    public Warrior(string name,int health, int maxAttack, int maxBlock)
    {
        Name = name;
        Health = health;
        MaxAttack = maxAttack;
        MaxBlock = maxBlock;
    }

    public int GetAttack()
    {
        Random random= new Random();
        int attackDamage = random.Next(0,MaxAttack);
        Console.WriteLine(attackDamage);
        return attackDamage;
    }

}