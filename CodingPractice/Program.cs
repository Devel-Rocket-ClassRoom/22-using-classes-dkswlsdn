using System;

Console.WriteLine("\n====================");

ClassName.MemberName();


Console.WriteLine("\n====================");

Console.WriteLine(Square.GetName());


Console.WriteLine("\n====================");

MyFirstClass.StaticMethod();

MyFirstClass mfs = new MyFirstClass();

mfs.InstanceMethod();


Console.WriteLine("\n====================");

Person hong = new Person();
hong.name = "홍길동";
hong.age = 25;

Person kim = new Person();
kim.name = "김철수";
kim.age = 30;

hong.Introduce();
kim.Introduce();


Console.WriteLine("\n====================");

Point point1 = new Point();
point1.x = 10;

Point point2 = point1;
point2.x = 100;
point2.y = 100;

Console.WriteLine($"point1.X = {point1.x}");
Console.WriteLine($"point2.X = {point2.x}");


Console.WriteLine("\n====================");

PointStruct ps1 = new PointStruct();
PointClass pc1 = new PointClass();

PointStruct ps2 = ps1;
PointClass pc2 = pc1;

ps1.x = 10;
ps2.x = 100;

pc1.x = 10;
pc2.x = 100;

Console.WriteLine($"구조체: ps1.X = {ps1.x}, ps2.X = {ps2.x}");
Console.WriteLine($"클래스: pc1.X = {pc1.x}, pc2.X = {pc2.x}");


Console.WriteLine("\n====================");

Calculator calc = new Calculator();

Console.WriteLine($"3 + 5 = {calc.Add()}");
Console.WriteLine($"3 * 5 = {calc.Multiply()}");


Console.WriteLine("\n====================");

Player player1 = new Player();
Player player2 = new Player("용사", 150);

player1.ShowStatus();
player2.ShowStatus();


Console.WriteLine("\n====================");

Stock st = new Stock();
st.CurrentPrice = 30;

Console.WriteLine($"주가: {st.CurrentPrice}");


Console.WriteLine("\n====================");

Product product = new Product();
product.Name = "노트북";
product.Price = 1500000;

Console.WriteLine($"{product.Name}: {product.Price}원 (수량: {product.Quantity})");


Console.WriteLine("\n====================");

Circle circle = new Circle();
circle.Radius = 5;

Console.WriteLine($"반지름: {circle.Radius} , 넓이: {circle.Area}");


Console.WriteLine("\n====================");

Monster goblin = new Monster();
goblin.name = "고블린";
goblin.health = 100;

Monster ork = new Monster
{
    name = "오크",
    health = 100
};

goblin.Attack();
ork.Attack();


Console.WriteLine("\n====================");

Character character = new Character
{
    Name = "용사",
    Level = 10,
    Job = "전사"
};

Console.WriteLine($"{character.Name} - LV.{character.Level} {character.Job}");


Console.WriteLine("\n====================");

Random random = new Random();

Console.WriteLine($"임의의 정수: {random.Next()}");
Console.WriteLine($"0 ~ 4: {random.Next(5)}");
Console.WriteLine($"1 ~ 9: {random.Next(1, 10)}");
Console.WriteLine($"0.0 ~ 1.0: {random.NextDouble()}");


Console.WriteLine("\n====================");

Console.WriteLine("주사위를 5번 굴립니다:");

for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"  {i}번째: {random.Next(1, 7)}");
}


Console.WriteLine("\n====================");

Person2 alice = new Person2("Alice");
Person2 bob = new Person2("bob");

bob.SetFriend(alice);

Console.WriteLine($"{bob.name}의 친구는 {bob.friend}입니다.");