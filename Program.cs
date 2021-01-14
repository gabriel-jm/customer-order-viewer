using System;
using System.Collections.Generic;
using customer_order_viewer.Repositories;
using customer_order_viewer.Models;

namespace customer_order_viewer
{
    class Program
    {
        static void Main()
        {
            CustomerOrderDetailCommand customerOrderDetailCommand = new CustomerOrderDetailCommand(
                @"Data Source=localhost;Initial Catalog=CustomerOrderViewer;Integrated Security=True"
            );

            IList<CustomerOrderDetailModel> customerOrderDetailModels = customerOrderDetailCommand.GetList();

            foreach(CustomerOrderDetailModel customerOrder in customerOrderDetailModels)
            {
                Console.WriteLine(customerOrder.toJSON());
            }
        }
    }
}
