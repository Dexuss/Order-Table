using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using TableOrder.Models;

namespace TableOrder.Repository
{
    public class OrderRepository : IOrderRepository
    {
        public List<OrderModel> SelectAllOrders() =>
            OrderList.SelectOrderList();

        public OrderModel SelectOrderById(Guid id) =>
            OrderList.SelectOrderList().Find(x => x.OrderID == id);

        public IEnumerable<OrderModel> SelectOrderByTableName(string table) =>
            OrderList.SelectOrderList().Where(x => x.TableName == table);

        public void InsertOrder(OrderModel ord) =>
            OrderList.InsertOrderList(ord);

        public void UpdateOrder(OrderModel ord) =>
            OrderList.UpdateOrderList(ord);

        public void DeleteOrder(Guid id) =>
            OrderList.DeleteOrderList(id);
    }
}