//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BackendFinal.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class filled_contents
    {
        public int id { get; set; }
        public string photo { get; set; }
        public string Content_user_name { get; set; }
        public string text { get; set; }
        public System.DateTime dates { get; set; }
        public Nullable<int> user_id { get; set; }
    }
}