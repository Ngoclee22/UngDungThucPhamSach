﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace ThucPhamSach_NVT_.Module.BusinessObjects.ORMDataModel1
{

    public partial class NguoiDung : XPObject
    {
        string fMaNgD;
        public string MaNgD
        {
            get { return fMaNgD; }
            set { SetPropertyValue<string>(nameof(MaNgD), ref fMaNgD, value); }
        }
        string fTen;
        public string Ten
        {
            get { return fTen; }
            set { SetPropertyValue<string>(nameof(Ten), ref fTen, value); }
        }
        string fSDT;
        public string SDT
        {
            get { return fSDT; }
            set { SetPropertyValue<string>(nameof(SDT), ref fSDT, value); }
        }
        string fDiaChi;
        public string DiaChi
        {
            get { return fDiaChi; }
            set { SetPropertyValue<string>(nameof(DiaChi), ref fDiaChi, value); }
        }
        string fPhanQuyen;
        public string PhanQuyen
        {
            get { return fPhanQuyen; }
            set { SetPropertyValue<string>(nameof(PhanQuyen), ref fPhanQuyen, value); }
        }
        string fEmail;
        public string Email
        {
            get { return fEmail; }
            set { SetPropertyValue<string>(nameof(Email), ref fEmail, value); }
        }
        [Association(@"DanhGiaReferencesNguoiDung")]
        public XPCollection<DanhGia> DanhGias { get { return GetCollection<DanhGia>(nameof(DanhGias)); } }
        [Association(@"DonHangReferencesNguoiDung")]
        public XPCollection<DonHang> DonHangs { get { return GetCollection<DonHang>(nameof(DonHangs)); } }
    }

}
