using System;
using System.Collections.Generic;
using System.Text;

public class MyFirstClass
{
    static public void StaticMethod()
    {
        Console.WriteLine("[1] 정적 메서드");
    }

    public void InstanceMethod()
    {
        Console.WriteLine("[2] 인스턴스 메서드");
    }
}