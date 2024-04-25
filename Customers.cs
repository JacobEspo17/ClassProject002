using System.IO.Pipes;

namespace ClassProject002;

public class Customers
{
    public List<Customer> customerList {get; set;}

    public Customers()
    {
        customerList = new List<Customer>();
    }

    public Customer Authenticate (string username, string password)
    {
        var c = customerList.Where(o => (o.UserName == username) && (o.Passsword == password));
        
        if(c.Count() > 0)
        {
            return c.First();
        }
        else
        {
            return null;
        }

    }


}
