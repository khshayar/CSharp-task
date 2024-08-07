namespace Homework;

public class BookStore
{
    public string Name { get; set;}
    public string Addres { get; set;}
    public bool StudySpace { get; set;}
    public bool CoffeeShop { get; set;}
    public bool Stationery { get; set;}
    public BookStore(string name, string addres ,bool studySpace,bool coffeeShop,bool stationery )
    {
        Name = name;
        Addres = addres;
        StudySpace = studySpace;
        CoffeeShop = coffeeShop;
        Stationery = stationery;
        Console.WriteLine($"book store {Name} is creat");
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