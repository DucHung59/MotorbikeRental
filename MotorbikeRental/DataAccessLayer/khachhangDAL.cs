using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorbikeRental.DataAccessLayer
{
    internal class khachhangDAL
    {
        public string constr = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
        public DataTable findAll()
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("Select * from tblKhachHang", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable("tblKhachHang"))
                        {
                            ad.Fill(dt);
                            return dt;
                        }
                    }
                }
            }
        }
        public bool insert(string PK_iMaKH, string sTenKH,string sSDT,string sGioiTinh,string sCCCD,string sDiaChi)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into tblKhachHang values(@PK_iMaKH, @sTenKH,@sSDT,@sGioiTinh,@sCCCD,@sDiaChi)";
                    cmd.Parameters.Add("@PK_iMaKH", PK_iMaKH);
                    cmd.Parameters.Add("@sTenKH", sTenKH);
                    cmd.Parameters.Add("@sSDT", sSDT);
                    cmd.Parameters.Add("@sGioiTinh", sGioiTinh);
                    cmd.Parameters.Add("@sCCCD", sCCCD);
                    cmd.Parameters.Add("@sDiaChi", sDiaChi);
                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();
                    return i > 0;
                }
            }
        }
        //"insert into tblAnhPT values(@id,@url)"

        public bool update(string PK_iMaKH, string sTenKH, string sSDT, string sGioiTinh, string sCCCD, string sDiaChi)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "update tblKhachHang SET sTenKH = @sTenKH ,sTenKH=@sTenKH,sSDT=@sSDT,sGioiTinh=@sGioiTinh,sCCCD=@sCCCD,sDiaChi=@sDiaChi where @PK_iMaKH = PK_iMaKH";
                    cmd.Parameters.Add("@PK_iMaKH", PK_iMaKH);
                    cmd.Parameters.Add("@sTenKH", sTenKH);
                    cmd.Parameters.Add("@sSDT", sSDT);
                    cmd.Parameters.Add("@sGioiTinh", sGioiTinh);
                    cmd.Parameters.Add("@sCCCD", sCCCD);
                    cmd.Parameters.Add("@sDiaChi", sDiaChi);

                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();

                    return i > 0;
                }
            }
        }
        public bool deleteById(string PK_iMaKH)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "Delete from tblKhachHang where PK_iMaKH=@PK_iMaKH) ";
                    cmd.Parameters.AddWithValue("@PK_iMaKH", PK_iMaKH);
                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();

                    return i > 0;
                }
            }
        }

        public DataTable search(string PK_iMaKH)
        {
            //byte[] b = ImageToByteArray(sUrl);
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_TimKH";
                    cmd.Parameters.AddWithValue("@PK_iMaKH", PK_iMaKH);
                    //cmd.Parameters.AddWithValue("@url", b);


                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            ad.Fill(dt);
                            return dt;
                        }
                    }
                }
            }
        }
    }
}
