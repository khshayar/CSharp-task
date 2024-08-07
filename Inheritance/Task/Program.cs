using Homework;

var bookShop = new BookStore("blue","godosi",false,true,true);
bookShop.BookCase("secret", "death and life","the power of habit");
bookShop.Advice();
bookShop.Sell("death and life",20);

var onlinebookshop = new OnlineBookStore("onlineblue","godosi","www.blue.ir",false,false,true);
Console.WriteLine(onlinebookshop.ShoppingBag());