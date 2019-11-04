using Lojista.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lojista.DataFake
{
    public class DataFake
    {

        public enum OrderStatus { Requested = 1, New = 2, InManufacturing = 3, Finished = 4, Dispatched = 5 };



        public static List<ShoppingCar> ShoppingCars()
        {

            var shoppingcar1 = new ShoppingCar()
            {
                CodeProduct = 2,
                Count = 2,
                Obs = string.Empty
            };

            var shoppingcar2 = new ShoppingCar()
            {
                CodeProduct = 3,
                Count = 11,
                Obs = string.Empty
            };

            var shoppingcar3 = new ShoppingCar()
            {
                CodeProduct = 1,
                Count = 3,
                Obs = string.Empty
            };

            var shoppingcar4 = new ShoppingCar()
            {
                CodeProduct = 2,
                Count = 67,
                Obs = string.Empty
            };

            var shoppingcar5 = new ShoppingCar()
            {
                CodeProduct = 9,
                Count = 2,
                Obs = string.Empty
            };

            var shoppingcar6 = new ShoppingCar()
            {
                CodeProduct = 3,
                Count = 8,
                Obs = string.Empty
            };

            var shoppingcar7 = new ShoppingCar()
            {
                CodeProduct = 4,
                Count = 1,
                Obs = string.Empty
            };

            var shoppingcar8 = new ShoppingCar()
            {
                CodeProduct = 4,
                Count = 4,
                Obs = string.Empty
            };

            var shoppingcar9 = new ShoppingCar()
            {
                CodeProduct = 5,
                Count = 15,
                Obs = string.Empty
            };
            return new List<ShoppingCar>() { shoppingcar1, shoppingcar2, shoppingcar3, shoppingcar4, shoppingcar5, shoppingcar6, shoppingcar7, shoppingcar8, shoppingcar9 };

        }

        public static List<Solicitation> Solicitations()
        {

            var solicitation1 = new Solicitation()
            {
                ID = 1,
                ShoppingCars = new List<ShoppingCar>() { ShoppingCars().Where(x => x.CodeProduct == 5).FirstOrDefault(), ShoppingCars().Where(x => x.CodeProduct == 4).LastOrDefault(), ShoppingCars().Where(x => x.CodeProduct == 1).FirstOrDefault() }

            };
            var solicitation2 = new Solicitation()
            {
                ID = 2,
                ShoppingCars = new List<ShoppingCar>() { ShoppingCars().Where(x => x.CodeProduct == 9).FirstOrDefault(), ShoppingCars().Where(x => x.CodeProduct == 1).FirstOrDefault(),
                                                         ShoppingCars().Where(x => x.CodeProduct == 3).FirstOrDefault(), ShoppingCars().Where(x => x.CodeProduct == 2).FirstOrDefault() }

            };
            var solicitation3 = new Solicitation()
            {
                ID = 3,
                ShoppingCars = new List<ShoppingCar>() { ShoppingCars().Where(x => x.CodeProduct == 4).FirstOrDefault(), ShoppingCars().Where(x => x.CodeProduct == 2).FirstOrDefault() }

            };
            var solicitation4 = new Solicitation()
            {
                ID = 4,
                ShoppingCars = new List<ShoppingCar>() { ShoppingCars().Where(x => x.CodeProduct == 5).LastOrDefault() }

            };
            var solicitation5 = new Solicitation()
            {
                ID = 5,
                ShoppingCars = new List<ShoppingCar>() { ShoppingCars().Where(x => x.CodeProduct == 2).LastOrDefault(), ShoppingCars().Where(x => x.CodeProduct == 3).LastOrDefault() }

            };

            return new List<Solicitation>() { solicitation1, solicitation2, solicitation3, solicitation4, solicitation5 };
        }

        public static List<Budget> Budgets()
        {
            var budget1 = new Budget()
            {
                ID = 1,
                DateReceive = DateTime.Now.AddDays(+5),
                Price = 30.00,
                IDSolicitation = 1
            };

            var budget2 = new Budget()
            {
                ID = 2,
                DateReceive = DateTime.Now.AddDays(+15),
                Price = 20.00,
                IDSolicitation = 2
            };

            var budget3 = new Budget()
            {
                ID = 3,
                DateReceive = DateTime.Now.AddDays(+21),
                Price = 170.00,
                IDSolicitation = 3
            };

            var budget4 = new Budget()
            {
                ID = 4,
                DateReceive = DateTime.Now.AddDays(+2),
                Price = 10.00,
                IDSolicitation = 4
            };

            var budget5 = new Budget()
            {
                ID = 5,
                DateReceive = DateTime.Now.AddDays(+7),
                Price = 50.00,
                IDSolicitation = 5
            };

            return new List<Budget>() { budget1, budget2, budget3, budget4, budget5 };
        }

        public static List<Order>Orders()
        {

            var order1 = new Order()
            {
                ID = 1,
                Status = (int)OrderStatus.InManufacturing,
                IDSolicitation = 1
            };

            var order2 = new Order()
            {
                ID = 2,
                Status = (int)OrderStatus.New,
                IDSolicitation = 2
            };

            var order3 = new Order()
            {
                ID = 3,
                Status = (int)OrderStatus.Requested,
                IDSolicitation = 3
            };

            var order4 = new Order()
            {
                ID = 4,
                Status = (int)OrderStatus.Dispatched,
                IDSolicitation = 4
            };

            var order5 = new Order()
            {
                ID = 5,
                Status = (int)OrderStatus.InManufacturing,
                IDSolicitation = 5
            };

            return new List<Order>() { order1, order2, order3, order4, order5 };
        }
    }
}
