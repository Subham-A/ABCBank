using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{


    public class Staff
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string PhoneNumber { get; set; }

        public ICollection<Request> requests { get; set; }

        public Staff()
        {
            requests = new HashSet<Request>();
        }

    }

    public class Request
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }
        public string AccountNumber { get; set; }
        public Services Service { get; set; }
        public bool IsFullfilled { get; set; }

    }

    public enum Gender
    {
        Male,
        Female
    }

    public enum Services
    {
        Enquiry,
        FundsTransfer,
        Deposit,
        Loans,
        Grievance,
        NewAccount
    }
}