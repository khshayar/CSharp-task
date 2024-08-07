namespace Homework;

public class OnlineBookStore :BookStore
{
    public OnlineBookStore(
        string name ,string addres,string webAddres,bool studySpace,bool coffeeShop,bool stationery)
        :base(name,addres,studySpace,coffeeShop,stationery)
    {
        WebAddres = webAddres;
    }
    public string WebAddres { get; set; }
    
    public string ShoppingBag() => $"your bag is empty";

}