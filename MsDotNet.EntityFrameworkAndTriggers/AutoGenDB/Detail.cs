//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AutoGenDB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Detail
    {
        public int Id { get; set; }
        public int MasterId { get; set; }
        public string AutoGenPrefix { get; set; }
        public Nullable<int> AutoGenNumber { get; set; }
    
        public virtual Master Master { get; set; }
    }
}
