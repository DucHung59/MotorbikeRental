using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorbikeRental.DataAccessLayer
{
    class phieuNhapDAL
    {
        public string constr = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;

        public DataTable findAll()
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("Select * from tblPhieuNhap", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable("tblPhieuNhap"))
                        {
                            ad.Fill(dt);
                            return dt;
                        }
                    }
                }
            }
        }
        public bool insert(string iPhieuN, string iTTrongTai, string iTongSLN, string iTongGiaN, string iNCC, string sCMND, string iPhieuThu, string iSoLuongN, string iLoaiPT)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_ThemPhieuNhap";
                    cmd.Parameters.Add("@PK_iPhieuN", iPhieuN);
                    cmd.Parameters.Add("@iTTrongTai", iTTrongTai);
                    cmd.Parameters.Add("@iTongSLN", iTongSLN);
                    cmd.Parameters.Add("@fTongGiaN", iTongGiaN);
                    cmd.Parameters.Add("@FK_iNCC", iNCC);
                    cmd.Parameters.Add("@FK_sCMNDnv", sCMND);
                    cmd.Parameters.Add("@FK_iPhieuX", iPhieuThu);

                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();
                    return i > 0;
                }
            }
        }
        public bool deleteById(string iMaPhieuN)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_XoaPhieuNhap";
                    cmd.Parameters.AddWithValue("@PK_iPhieuN", iMaPhieuN);
                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();

                    return i > 0;
                }
            }
        }
        public bool update(string iPhieuN, string iTTrongTai, string iTongSLN, string iTongGiaN, string iNCC, string sCMND, string iPhieuThu, string iSoLuongN, string iLoaiPT)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_SuaPhieuNhap";
                    cmd.Parameters.Add("@PK_iPhieuN", iPhieuN);
                    cmd.Parameters.Add("@iTTrongTai", iTTrongTai);
                    cmd.Parameters.Add("@iTongSLN", iTongSLN);
                    cmd.Parameters.Add("@fTongGiaN", iTongGiaN);
                    cmd.Parameters.Add("@FK_iNCC", iNCC);
                    cmd.Parameters.Add("@FK_sCMNDnv", sCMND);
                    cmd.Parameters.Add("@FK_iPhieuX", iPhieuThu);


                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();

                    return i > 0;
                }
            }
        }


    }
}
