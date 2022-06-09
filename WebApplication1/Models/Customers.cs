using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Customers
    {
        [Key]
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public string CustomerEmail { get; set; }
        public int CustomerPhoneNr { get; set; }
        public Service CustomerService { get; set; }
        public Status CustomerStatus { get; set; }
    }

    public enum Service
    {
        Zestaw_1,
        Zestaw_2,
        Zestaw_3,
        Zestaw_4
    }

    public enum Status
    {
        Niezaakceptowany,
        Zaakceptowany
    }
}
