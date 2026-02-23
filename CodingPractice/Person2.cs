using System;
using System.Collections.Generic;
using System.Text;

public class Person2
{
    public string name;
    public string friend;


    public Person2(string name)
    {
        this.name = name; 
    }

    public void SetFriend(Person2 friend)
    {
        this.friend = friend.name;
    }
}