using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

public class Program
{
    private static void Main(string[] args)
    {
        CarTest();
        //BrandTest();
    }

    private static void BrandTest()
    {
        BrandManager brandManager = new BrandManager(new EfBrandDal());
        foreach (var brand in brandManager.GetAll())
        {
            Console.WriteLine(brand.BrandName);
        }
    }

    private static void CarTest()
    {
        CarManager carManager = new CarManager(new EfCarDal());

        var result = carManager.GetCarDetails();

        if (result.Success == true)
        {
            foreach (var car in carManager.GetCarDetails().Data)
            {
                Console.WriteLine(car.BrandName + " / " + car.CarName + " / " + car.DailyPrice);
            }
        }
        else
        {
            Console.WriteLine(result.Message);
        }

    }
}