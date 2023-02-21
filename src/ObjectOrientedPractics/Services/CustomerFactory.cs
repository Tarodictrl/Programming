using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.Services
{
    public static class CustomerFactory
    {
        public static Customer Randomize()
        {
            Customer customer = new Customer();
            customer.Fullname = "None";
            customer.Address = new Address();
            customer.Cart = new Cart();

            return customer;
        }
    }
}
