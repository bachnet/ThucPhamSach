//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace thuc_pham_sach_hd.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class PhanQuyen
    {
        public int Id { get; set; }
        public Nullable<int> Id_User { get; set; }
        public Nullable<int> Id_Quyen { get; set; }
    
        public virtual QuanTri QuanTri { get; set; }
    }
}
