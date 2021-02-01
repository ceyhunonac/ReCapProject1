using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carmanager = new CarManager(new InMemoryCarDal());
            foreach (var item in carmanager.GetAll())
            {
                Console.WriteLine("Kiralanacak Araba Bilgisi : " + item.Description+ "--->" + 
                    "    Bu Arabanın Günlük Ücreti : "+ item.DailyPrice);
            }
            {

            }

        }
    }
}
