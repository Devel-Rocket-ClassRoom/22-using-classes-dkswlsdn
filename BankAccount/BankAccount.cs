using System;
using System.Collections.Generic;
using System.Text;

public class BankAccount
{
    readonly string accountNumber;
    readonly string ownerName;
    private int balance;

    public BankAccount(string accountNumber, string ownerName)
    {
        this.accountNumber = accountNumber;
        this.ownerName = ownerName;
        balance = 0;
    }

    public void Deposit(int amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("입금 금액은 0보다 커야합니다");
            return;
        }

        balance += amount;

        Console.WriteLine($"{amount}원 입금 완료. 잔액: {balance}원");
    }

    public void Withdraw(int amount)
    {
        if (balance < amount)
        {
            Console.WriteLine("잔액이 부족합니다.");
            return;
        }

        balance -= amount;
        Console.WriteLine($"{amount}원 출금 완료. 잔액: {balance}원");
    }

    public void ShowInfo()
    {
        Console.WriteLine($"[계좌 정보] {accountNumber} ({ownerName}) - 잔액: {balance}원");
    }
}