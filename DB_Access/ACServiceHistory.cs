//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DB_Access
{
    using System;
    using System.Collections.Generic;
    
    public partial class ACServiceHistory
    {
        public int Id { get; set; }
        public System.DateTime ServiceDate { get; set; }
        public string Note { get; set; }
        public int PersonMasterId { get; set; }
        public int ACMasterId { get; set; }
    
        public virtual PersonMaster PersonMaster { get; set; }
        public virtual ACMaster ACMaster { get; set; }
    }
}
