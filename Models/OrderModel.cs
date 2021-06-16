using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;


namespace OrderManager.Models
{
    public enum CompanyEnum { 
        Ail,
        SM,
        SMN
    }
    public class OrderModel
    {
        public int OrderId { get; set; }
        [DisplayName("Treść")]
        public string Content { get; set; }
        [DisplayName("Zamawiający")]
        public string Purchaser { get; set; }
        [DisplayName("Komentarz")]
        public string Comments { get; set; }
        [DisplayName("Spółka")]
        public CompanyEnum Company { get; set; }
        [DisplayName("Data dodania")]
        public DateTime DateAdd { get; set; }
        [DisplayName("Zamówione?")]
        public bool Done { get; set; } = false;
    }
}