using System.Dynamic;

public class Dice
{
    private int face, numSides;
    public Dice()
    {
        numSides = 6;
        face = 1;
    }
    public Dice(int num)
    {
        if (num != 0)
        {
            numSides = Math.Abs(num);
        }
        else
        {
            numSides = 6;
        }
    }
    public void Roll()
    {
        Random obj = new();
        face = obj.Next(1, numSides);
    }
    public int Face
    {
        get
        {
            return face;
        }
    }
}
class Program{
    static void Main()
    {
        Dice d1 = new();
        Dice d2 = new(12);
        Dice d3 = new(-20);
        Dice d4 = new(0);
        d1.Roll();
        d2.Roll();
        d3.Roll();
        d4.Roll();
        Console.WriteLine(d1.Face);
        Console.WriteLine(d2.Face);
        Console.WriteLine(d3.Face);
        Console.WriteLine(d4.Face);
        
    }
}