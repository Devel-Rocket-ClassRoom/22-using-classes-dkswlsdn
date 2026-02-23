using System;
using System.Collections.Generic;
using System.Text;

public class ProductInfo
{
    public string name;
    public int price;
    public double discountPercent;
    public double discountAmount;
    public double finalPrice;


    public ProductInfo(string name, int price)
    {
        this.name = name;
        this.price = price;
        discountPercent = 0;
        discountAmount = 0;
        finalPrice = price;
    }

    public ProductInfo(string name, int price, double discountPercent)
    {
        this.name = name;
        this.price = price;
        this.discountPercent = discountPercent;
        discountAmount = price * discountPercent / 100;
        finalPrice = price - discountAmount;
    }


    public void PrintInfo()
    {
        Console.WriteLine($"[상품 정보] {name} - 가격: {price}원, 할인: -{discountPercent}% ({discountAmount}원), 최종가: {finalPrice}원");
    }
}
