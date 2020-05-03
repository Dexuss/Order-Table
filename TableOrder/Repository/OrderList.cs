using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TableOrder.Models;

namespace TableOrder.Repository
{
    public class OrderList
    {
        static List<OrderModel> orderList = null;
        static OrderList()
        {
            orderList = new List<OrderModel>(){
            new OrderModel()
            {
                OrderID = Guid.NewGuid(),
                Name = "Pierogi",
                Quantity = 2,
                Price = 12.0,
                TableName = "Stolik pod oknem"
            },
             new OrderModel()
            {
                OrderID = Guid.NewGuid(),
                Name = "Pierogi",
                Quantity = 3,
                Price = 12.0,
                TableName = "Stolik VIP"
            },
            new OrderModel()
            {
                OrderID = Guid.NewGuid(),
                Name = "Kotlet schabowy",
                Quantity = 1,
                Price = 23.0,
                TableName = "Stolik VIP"
            },
            new OrderModel()
            {
                OrderID = Guid.NewGuid(),
                Name = "Burger XXL",
                Quantity = 5,
                Price = 27.0,
                TableName = "Stolik VIP"
            },
            new OrderModel()
            {
                OrderID = Guid.NewGuid(),
                Name = "Kotlet schabowy",
                Quantity = 4,
                Price = 23.0,
                TableName = "Stolik na piętrze"
            },
            };
        }

        public static List<OrderModel> SelectOrderList()
        {
            return orderList;
        }

        public static void InsertOrderList(OrderModel ord)
        {
            ord.OrderID = Guid.NewGuid();
            orderList.Add(ord);
        }

        public static void UpdateOrderList(OrderModel ord)
        {
            OrderModel empUpdate = orderList.Find(x => x.OrderID == ord.OrderID);
            empUpdate.Name = ord.Name;
            empUpdate.Quantity = ord.Quantity;
            empUpdate.Price = ord.Price;
            empUpdate.TableName = ord.TableName;
        }
        public static void DeleteOrderList(Guid id)
        {
            OrderModel ordDelete = orderList.Find(x => x.OrderID == id);
            orderList.Remove(ordDelete);
        }
    }
}