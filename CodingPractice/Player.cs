using System;
using System.Collections.Generic;
using System.Text;

public class Player
{
    string name;
    int Hp;

    public Player()
    {
        name = "Unknown";
        Hp = 100;
    }

    public Player(string name, int hp)
    {
        this.name = name;
        Hp = hp;
    }

    public void ShowStatus()
    {
        Console.WriteLine($"이름: {name}, 체력: {Hp}");
    }
}