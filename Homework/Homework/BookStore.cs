namespace Homework;

public class BookStore
{
    private string _name;
    private bool _studySpace;
    private bool _coffeeShop;
    private bool _stationery;
    public BookStore(string name,bool studySpace,bool coffeeShop,bool stationery )
    {
        _name = name;
        _studySpace = studySpace;
        _coffeeShop = coffeeShop;
        _stationery = stationery;
        Console.WriteLine($"book store {_name} is creat");
    }

    public void BookCase(params string [] books)   //for showing book
    {
        foreach (var book in books)
        {
            Console.WriteLine(book);
        }
    }

    public void Advice()
    {
        Console.WriteLine("do you need Advice");
        var result =Console.ReadLine();
        if (result == "yes")
        {
            Console.WriteLine("we cant help you sorry !!");
        }
        
    }
    
    public void Sell(string name ,int price)
    {
        Console.WriteLine($"{name} sold whit this ({price})price");
    }
}