//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order()
        {
            this.Payments = new HashSet<Payment>();
            this.ProductOrders = new HashSet<ProductOrder>();
        }
    
        public int OrderID { get; set; }
        public string ID { get; set; }
        public string ReceiverName { get; set; }
        public string ReceiverSurname { get; set; }
        public string ReceiverEmail { get; set; }
        public string ReceiverCellNumber { get; set; }
        public string StreetAddress { get; set; }
        public string Suburb { get; set; }
        public System.DateTime DeliveryDate { get; set; }
        public string PostalCode { get; set; }
        public System.DateTime OrderDate { get; set; }
        public string OrderStatus { get; set; }
        public string City { get; set; }
        public Nullable<decimal> totalAmount { get; set; }
    
        public virtual Customer Customer { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Payment> Payments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductOrder> ProductOrders { get; set; }
    }
}
