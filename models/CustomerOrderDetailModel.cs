namespace customer_order_viewer.Models
{
  class CustomerOrderDetailModel
  {
    public int CustomerOrderId { get; set; }
    public int CustomerId { get; set; }
    public int ItemId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Description { get; set; }

    public string toJSON() {
      return "{\n"+
        $"\t\"CustomerOrderId\": {CustomerOrderId}\n"+
        $"\t\"CustomerId\": {CustomerId}\n"+
        $"\t\"ItemId\": {ItemId}\n"+
        $"\t\"FirstName\": {FirstName}\n"+
        $"\t\"LastName\": {LastName}\n"+
        $"\t\"Description\": {Description}\n"+
        "}\n"
      ;
    }
  }
}