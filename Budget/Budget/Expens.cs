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
    
    public partial class Expens
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int household { get; set; }
        public int transport { get; set; }
        public int finance { get; set; }
        public int leisure { get; set; }
        public int regularBills { get; set; }
        public int insurance { get; set; }
        public int children { get; set; }
        public int otherBills { get; set; }
        public int totalExpenses { get; set; }
        public string Month { get; set; }
    
        public virtual Account Account { get; set; }
    }
}
