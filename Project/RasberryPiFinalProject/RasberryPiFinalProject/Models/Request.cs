//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RasberryPiFinalProject.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Request
    {
        public int Request_ID { get; set; }
        public int Msl7a_ID { get; set; }
        public int Mostanad_ID { get; set; }
        public int No_of_copies { get; set; }
        public string Citizen_ID { get; set; }
        public bool Printed_or_not { get; set; }
        public Nullable<bool> toPrint { get; set; }
        public string Phone_Number { get; set; }
        public Nullable<bool> Msg_Sent_Or_Not { get; set; }
    
        public virtual Citizen Citizen { get; set; }
        public virtual Mostanadat Mostanadat { get; set; }
        public virtual Msale7 Msale7 { get; set; }
    }
}
