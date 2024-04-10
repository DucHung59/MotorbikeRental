using MotorbikeRental.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorbikeRental.BusinessLogicLayer
{
    internal class khachHangBLL
    {
        khachhangDAL khachhangDAL= new khachhangDAL();
        public DataTable findAll()
        {
            return khachhangDAL.findAll();
        }

        public bool insert(string PK_iMaKH, string sTenKH, string sSDT, string sGioiTinh, string sCCCD, string sDiaChi)
        {
            if (string.IsNullOrEmpty(PK_iMaKH))
                return false;
            else
                return khachhangDAL.insert(PK_iMaKH, sTenKH, sSDT, sGioiTinh, sCCCD, sDiaChi);
        }
        public bool checkExistsNameAndCategory(string PK_iMaKH)
        {
            DataTable dt = khachhangDAL.findAll();

            foreach (DataRow dr in dt.Rows)
            {
                if (String.Equals(dr["PK_iMaKH"].ToString(), PK_iMaKH, StringComparison.InvariantCultureIgnoreCase))
                    return false;
                else if (!string.IsNullOrEmpty(PK_iMaKH))
                    if (!int.TryParse(PK_iMaKH, out _) || int.Parse(PK_iMaKH) <= 0)
                        return false;
            }

            return true;
        }
        public bool update(string PK_iMaKH, string sTenKH, string sSDT, string sGioiTinh, string sCCCD, string sDiaChi)
        {

            if (string.IsNullOrEmpty(PK_iMaKH))
                return false;

            else
                return khachhangDAL.update(PK_iMaKH, sTenKH, sSDT, sGioiTinh, sCCCD, sDiaChi);
        }
        public bool deleteById(string PK_iMaKH)
        {
            if (string.IsNullOrEmpty(PK_iMaKH))
            {
                return false;
            }
            return khachhangDAL.deleteById(PK_iMaKH);
        }
        public DataTable search(string PK_iMaKH)
        {

            if (string.IsNullOrEmpty(PK_iMaKH))
                return null;
            return khachhangDAL.search(PK_iMaKH);
        }

    }
}

