//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Budget
{
    using System;
    using System.Collections.Generic;
    
    public partial class Account
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Cash { get; set; }
        public int Credit_Cards { get; set; }
        public int Bank { get; set; }
        public int investment { get; set; }
    
        public virtual Expens Expens { get; set; }
        public virtual Income Income { get; set; }
        public virtual Transaction Transaction { get; set; }
    }
}
