using System;
using System.Collections.Generic;
using System.Text;

public class Person
{
    public string name;
    public int age;

    public void Introduce()
    {
        Console.WriteLine($"안녕하세요, {name}입니다. {age}살입니다.");
    }
}