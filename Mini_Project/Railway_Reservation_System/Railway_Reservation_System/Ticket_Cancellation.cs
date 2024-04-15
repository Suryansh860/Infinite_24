//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Railway_Reservation_System
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ticket_Cancellation
    {
        public decimal Cancel_Id { get; set; }
        public Nullable<decimal> Train_No { get; set; }
        public string Passenger_Name { get; set; }
        public Nullable<decimal> Age { get; set; }
        public Nullable<decimal> User_Id { get; set; }
        public string Berth { get; set; }
        public Nullable<decimal> Paid_Amount { get; set; }
        public Nullable<decimal> PNR_No { get; set; }
        public Nullable<System.DateTime> Cancel_Date { get; set; }
        public string Cancel_Status { get; set; }
    
        public virtual Ticket_Confirmation Ticket_Confirmation { get; set; }
        public virtual Train Train { get; set; }
        public virtual User_LogIn User_LogIn { get; set; }
    }
}