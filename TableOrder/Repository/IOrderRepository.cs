using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TableOrder.Models;

namespace TableOrder.Repository
{
    public interface IOrderRepository
    {
        List<OrderModel> SelectAllOrders();
        OrderModel SelectOrderById(int id);
        List<OrderModel> SelectOrderByTable(string table);
        void InsertOrder(OrderModel ord);
        void UpdateOrder(OrderModel ord);
        void DeleteOrder(Guid id);
    }
}