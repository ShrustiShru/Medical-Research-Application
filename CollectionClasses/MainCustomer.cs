using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionClasses
{
    class MainCustomer
    {
        static void Main(string[] args)
        {
            ICustomer component = new CollectionCustomer();
            component.AddCustomer(new Customer{ CustomerName = "Shru", CustomerId = 21, CustomerAddress = "Bangalore", CustomerBillAmount = 56200 });
            component.AddCustomer(new Customer { CustomerName = "Hemi", CustomerId = 25, CustomerAddress = "Mangalore", CustomerBillAmount = 78500 });
            component.AddCustomer(new Customer { CustomerName = "Deepu", CustomerId = 27, CustomerAddress = "Davangere", CustomerBillAmount = 89300 });
            component.DeleteCustomer(0);
        }
    }
}
