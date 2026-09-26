using OnlineShopApp.Context;
using OnlineShopApp.Entities;
using static System.Net.Mime.MediaTypeNames;
using var context = new AppDbContext();

//1 zadiniye
try
{
    var user = new User
    {
        Email = "test1@gmail.com"
    };
    context.Users.Add(user);
    context.SaveChanges();
}
catch (Exception ex)
{
    Console.WriteLine("FirstName обязателен");
}

//Задание 2
try
{
    var user1 = new User
    {
        FirstName = "Ali",
        Email = "ctoto@gmail.com"
    };
    var user2 = new User
    {
        FirstName = "Murad",
        Email = "ctoto@gmail.com"
    };
    context.Users.AddRange(user1, user2);
    context.SaveChanges();
}
catch (Exception ex)
{
    Console.WriteLine("Пользователь с такой почтой существует");
}

//Тест 3
try
{
    var product = new Product
    {
        Name = "NVIDIA GeForce RTX 5090",
        Price = -100,
        StockQuantity = 10,
        CategoryId = 1
    };
    context.Products.Add(product);
    context.SaveChanges();
}
catch (Exception ex)
{
    Console.WriteLine("Отрицательная цена нельзя вводить");
}

//Тест 4
try
{
    var product = new Product
    {
        Name = "Intel Core Ultra 9 290HX",
        Price = 100,
        StockQuantity = -5,
        CategoryId = 1
    };
    context.Products.Add(product);
    context.SaveChanges();
}
catch (Exception ex)
{
    Console.WriteLine("Отрицательный StockQuantity нельзя");
}

//Тест 5
try
{
    var review = new Review
    {
        UserId = 1,
        ProductId = 1,
        Rating = 10,
        Comment = "Bad thing"
    };
    context.Reviews.Add(review);
    context.SaveChanges();
}
catch (Exception ex)
{
    Console.WriteLine("Rating должен быть от 1 до 5");
}

//Тест 6
try
{
    var review1 = new Review
    {
        UserId = 1,
        ProductId = 1,
        Rating = 5,
        Comment = "First review"
    };

    var review2 = new Review
    {
        UserId = 1,
        ProductId = 1,
        Rating = 4,
        Comment = "Second review"
    };
    context.Reviews.AddRange(review1, review2);
    context.SaveChanges();
}
catch (Exception ex)
{
    Console.WriteLine("UserId и ProductId должны быть уникальными");
}

//Тест 7
try
{
    var orderItem = new OrderItem
    {
        OrderId = 1,
        ProductId = 1,
        Quantity = 0,
        UnitPrice = 100
    };
    context.OrderItems.Add(orderItem);
    context.SaveChanges();
}
catch (Exception ex)
{
    Console.WriteLine("Quantity должен быть больше чем 0");
}

// Тест 8
try
{
    var orderItem = new OrderItem
    {
        OrderId = 1,
        ProductId = 1,
        Quantity = 1,
        UnitPrice = -50
    };
    context.OrderItems.Add(orderItem);
    context.SaveChanges();
}
catch (Exception ex)
{
    Console.WriteLine("UnitPrice должен быть больше чем 0");
}

// Тест 9
try
{
    var user = context.Users.FirstOrDefault(u => u.Id == 1);
    context.Users.Remove(user);
    context.SaveChanges();
}
catch (Exception ex)
{
    Console.WriteLine("У User есть заказы его удалить нельзя");
}