﻿using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

public class Program
{
    private static void Main(string[] args)
    {
        //CarTest();
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

        foreach (var car in carManager.GetCarDetails())
        {
            Console.WriteLine(car.BrandName + "/" + car.ColorName);
        }
    }
}