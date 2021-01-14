using System.Collections.Generic;
using customer_order_viewer.Models;
using System.Data.SqlClient;

namespace customer_order_viewer.Repositories
{
  class CustomerOrderDetailCommand
  {
    private string _connectionString;

    public CustomerOrderDetailCommand(string connectionString)
    {
      _connectionString = connectionString;
    }

    public IList<CustomerOrderDetailModel> GetList()
    {
      List<CustomerOrderDetailModel> customerOrderDetailModels = new List<CustomerOrderDetailModel>();

      using(SqlConnection connection = new SqlConnection(_connectionString))
      {
        connection.Open();

        using(SqlCommand command = new SqlCommand(
          "SELECT CustomerOrderId, CustomerId, ItemId, FirstName, LastName, [Description] FROM CustomerOrderDetail;",
          connection
        ))
        {
          using(SqlDataReader reader = command.ExecuteReader())
          {
            if(reader.HasRows)
            {
              while(reader.Read())
              {
                CustomerOrderDetailModel customerOrderDetailModel = new CustomerOrderDetailModel() {
                  CustomerOrderId = (int) reader["CustomerOrderId"],
                  CustomerId = (int) reader["CustomerId"],
                  ItemId = (int) reader["ItemId"],
                  FirstName = reader["FirstName"].ToString(),
                  LastName = reader["LastName"].ToString(),
                  Description = reader["Description"].ToString()
                };

                customerOrderDetailModels.Add(customerOrderDetailModel);
              }
            }
          }
        }
      }

      return customerOrderDetailModels;
    }
  }
}
