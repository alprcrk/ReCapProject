using Business.Concrete;
using DataAccess.Concrete.InMemory;

public class Program
{
    private static void Main(string[] args)
    {
        CarManager carManager = new CarManager(new InMemoryCarDal());

        foreach (var car in carManager.GetAll())
        {
            Console.WriteLine(car.Name);
        }
    }
}