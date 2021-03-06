//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BroadcastSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Web.Mvc;

    public partial class Message
    {
        public int ID { get; set; }
        public Nullable<int> AuthorID { get; set; }
        [DisplayName("Message title")]
        public string Title { get; set; }
        [DisplayName("Message content")]
        [AllowHtml]
        public string Content { get; set; }
        [DisplayName("Broadcasts from")]
        public Nullable<System.DateTime> From { get; set; }
        [DisplayName("Broadcasts to")]
        public Nullable<System.DateTime> To { get; set; }
        public Nullable<bool> IsBroadcasting { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedOn { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<bool> IsActived { get; set; }

        public virtual Author Author { get; set; }
    }
}
