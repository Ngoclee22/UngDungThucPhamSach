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

    public partial class DanhGia : XPObject
    {
        string fSoSao;
        public string SoSao
        {
            get { return fSoSao; }
            set { SetPropertyValue<string>(nameof(SoSao), ref fSoSao, value); }
        }
        string fNdDanhGia;
        public string NdDanhGia
        {
            get { return fNdDanhGia; }
            set { SetPropertyValue<string>(nameof(NdDanhGia), ref fNdDanhGia, value); }
        }
        string fNgayDanhGia;
        public string NgayDanhGia
        {
            get { return fNgayDanhGia; }
            set { SetPropertyValue<string>(nameof(NgayDanhGia), ref fNgayDanhGia, value); }
        }
        SanPham fMaSP;
        [Association(@"DanhGiaReferencesSanPham")]
        public SanPham MaSP
        {
            get { return fMaSP; }
            set { SetPropertyValue<SanPham>(nameof(MaSP), ref fMaSP, value); }
        }
        NguoiDung fMaNgD;
        [Association(@"DanhGiaReferencesNguoiDung")]
        public NguoiDung MaNgD
        {
            get { return fMaNgD; }
            set { SetPropertyValue<NguoiDung>(nameof(MaNgD), ref fMaNgD, value); }
        }
    }

}
