//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ChatGPT.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class EmployeeChatroom
    {
        public int Id { get; set; }
        public Nullable<int> EmployeeId { get; set; }
        public Nullable<int> ChatroomId { get; set; }
    
        public virtual Chatroom Chatroom { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
