using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class EditViewModel
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string AccountNumber { get; set; }
        public bool ActionTaken { get; set; }
        public Services Service { get; set; }
    }
}