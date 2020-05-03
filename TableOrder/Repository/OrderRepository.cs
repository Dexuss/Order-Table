using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace TableOrder.Repository
{
    public class OrderRepository
    {
        public List<Models.OrderModel> SelectAllOrders()
        {
            return OrderList.SelectOrderList();
        }

        public Models.OrderModel SelectOrderById(Guid id)
        {
            return OrderList.SelectOrderList().Find(x => x.OrderID == id);
        }

        public IEnumerable<Models.OrderModel> SelectOrderByTableName(string table)
        {
            return OrderList.SelectOrderList().Where(x => x.TableName == table);
        }

        public void InsertOrder(Models.OrderModel ord)
        {
            OrderList.InsertOrderList(ord);
        }

        public void UpdateOrder(Models.OrderModel ord)
        {
            OrderList.UpdateOrderList(ord);
        }

        public void DeleteOrder(Guid id)
        {
            OrderList.DeleteOrderList(id);
        }
    }
}