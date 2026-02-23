using System;
using System.Collections.Generic;
using System.Text;

public class Monster
{
    public string name;
    public int health;

    public void Attack()
    {
        Console.WriteLine($"{name}이(가) 공격합니다!");
    }
}