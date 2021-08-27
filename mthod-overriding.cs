using System;
public class food
{
    public virtual void eat()
    {
        Console.WriteLine("Eating...");
    }
}
public class pizza : food
{
    public override void eat()
    {
        Console.WriteLine("Eating pizza...");
    }
}
public class TestOverriding
{
    public static void Main()
    {
        pizza p = new pizza();
        p.eat();
    }
}