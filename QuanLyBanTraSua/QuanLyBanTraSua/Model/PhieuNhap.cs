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
    
    public partial class PhieuNhap
    {
        public PhieuNhap()
        {
            this.CTPNs = new HashSet<CTPN>();
        }
    
        public string MaPN { get; set; }
        public string TenPN { get; set; }
        public Nullable<System.DateTime> NgayNhap { get; set; }
    
        public virtual ICollection<CTPN> CTPNs { get; set; }
    }
}
