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

    public partial class ChiTietDonHang : XPObject
    {
        DonHang fMaDH;
        [Association(@"ChiTietDonHangReferencesDonHang")]
        public DonHang MaDH
        {
            get { return fMaDH; }
            set { SetPropertyValue<DonHang>(nameof(MaDH), ref fMaDH, value); }
        }
        string fSoLuong;
        public string SoLuong
        {
            get { return fSoLuong; }
            set { SetPropertyValue<string>(nameof(SoLuong), ref fSoLuong, value); }
        }
        string fDonGia;
        public string DonGia
        {
            get { return fDonGia; }
            set { SetPropertyValue<string>(nameof(DonGia), ref fDonGia, value); }
        }
    }

}
