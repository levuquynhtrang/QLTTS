//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLySinhVienThucTap.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblNoiDungDaoTao
    {
        public int MaNoiDungDaoTao { get; set; }
        public string MaKhoaDaoTao { get; set; }
        public string NoiDung { get; set; }
        public string Video { get; set; }
    
        public virtual tblKhoaDaoTao tblKhoaDaoTao { get; set; }
    }
}
