namespace Lod.Task1;

public abstract class Shape
{
    public abstract double GetArea();
}

public class Circle(double radius) : Shape
{
    public double Radius { get; } = radius;

    public override double GetArea() => Math.PI * Radius * Radius;
}

public class Rectangle(double width, double height) : Shape
{
    public double Width { get; } = width;
    public double Height { get; } = height;

    public override double GetArea() => Width * Height;
}


public interface IMovable
{
    void Move();
}

public class Car : IMovable
{
    public void Move()
    {
        Console.WriteLine("Машина едет");
    }
}

public class Bicycle : IMovable
{
    public void Move()
    {
        Console.WriteLine("Велосипед едет");
    }
}

public class BankAccount(decimal initialBalance)
{
    public BankAccount() : this(0) { }

    public decimal Balance { get; private set; } = initialBalance;

    public void Deposit(decimal amount)
    {
        if (amount <= 0) throw new ArgumentException("Сумма должна быть положительной.");
        
        Balance += amount;
    }

    public bool Withdraw(decimal amount)
    {
        if (!CanWithdraw(amount)) return false;
        
        Balance -= amount;
        return true;

    }
    
    public bool CanWithdraw(decimal amount) => Balance >= 0 && amount >= 0 && Balance >= amount;
}