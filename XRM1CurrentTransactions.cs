//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SmartDataAnalyzer
{
    using System;
    using System.Collections.Generic;
    
    public partial class XRM1CurrentTransactions
    {
        public short PayrollNo { get; set; }
        public string EmployeeRef { get; set; }
        public string PayrollCode { get; set; }
        public System.DateTime TransactionDate { get; set; }
        public Nullable<double> TransactionQty { get; set; }
        public Nullable<decimal> TransactionAmount { get; set; }
        public string EnteredBy { get; set; }
        public Nullable<System.DateTime> DateEntered { get; set; }
    }
}
