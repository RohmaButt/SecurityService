//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Afiniti.GRM.SecurityService
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserRole_Rel
    {
        public int UserRoleRelId { get; set; }
        public System.Guid UserRoleRelKey { get; set; }
        public System.Guid UserKey { get; set; }
        public System.Guid RoleKey { get; set; }
        public bool IsActive { get; set; }
    }
}
