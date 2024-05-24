using System;

class Program {
    static void Main(string[] args)
    {

        Bank A = new BankA();
        int balanceA = A.getBalance();
        Console.WriteLine(balanceA);

        Bank B = new BankB();
        int balanceB = B.getBalance();
        Console.WriteLine(balanceB);

        Bank C = new BankC();
        int balanceC = C.getBalance();
        Console.WriteLine(balanceC);

    }
}

public abstract class Bank
{
    public abstract int getBalance();
}

public class BankA : Bank
{
    public override int getBalance()
    {
        int deposit = 100;
        return deposit;
    }
}

public class BankB : Bank
{
    public override int getBalance()
    {
        int deposit = 150;
        return deposit;
    }
}

public class BankC : Bank
{
    public override int getBalance()
    {
        int deposit = 200;
        return deposit;
    }
}



