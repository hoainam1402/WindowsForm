//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyBanTraSua.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class CTHD
    {
        public string MaHD { get; set; }
        public string MaMon { get; set; }
        public Nullable<int> SoLuong { get; set; }
        public Nullable<decimal> GiaBan { get; set; }
    
        public virtual HoaDon HoaDon { get; set; }
        public virtual MonAn MonAn { get; set; }
    }
}
