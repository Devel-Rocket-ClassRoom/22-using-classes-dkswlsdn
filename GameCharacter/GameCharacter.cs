using System;
using System.Collections.Generic;
using System.Text;

public class GameCharacter
{
    string name;
    int level;
    int maxHp;
    int currentHp;
    int attackPower;
    bool isAlive;

    public GameCharacter(string name, int level)
    {
        this.name = name;
        this.level = level;
        maxHp = level * 100;
        currentHp = maxHp;
        attackPower = level * 10;
        isAlive = currentHp > 0;
    }

    public void Attack(GameCharacter target)
    {
        target.TakeDamage(attackPower);

        Console.WriteLine($"{name}이(가) {target.name}에게 {attackPower} 데미지를 입혔습니다!");
    }

    public void TakeDamage(int damage)
    {
        if (currentHp < damage)
        {
            damage = currentHp;
        }

        currentHp -= damage;
    }

    public void ShowStatus()
    {
        Console.WriteLine($"[{name}] LV.{level} - HP: {maxHp}/{currentHp}, 공격력: {attackPower}");
    }
}