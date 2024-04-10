using MotorbikeRental.BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotorbikeRental.QuanLyKhachHang
{
    public partial class khachHang : Form
    {

        private const string MS_001 = "Không được để trống";
        private const string MS_002 = "Thêm thành công";
        private const string MS_003 = "Thêm thất bại";
        private const string MS_004 = "Mã ảnh đã tồn tại";
        private const string MS_005 = "Sửa thành công";
        private const string MS_006 = "Sửa thất bại";
        private const string MS_007 = "Xóa thành công";
        private const string MS_008 = "Xóa thất bại";
        private const string MS_009 = "Vui lòng nhập mã ảnh muốn tìm";
        private const string MS_013 = "Không tìm thấy ảnh";
        private const string MS_Notify = "Thông báo";
        private const string MS_Error = "Lỗi";
        private const string MS_Confirm = "Bạn có chắc chắn xóa không?";
        private const string MS_Warn = "Cảnh báo";
        private const string MS_Action = "Không thể xóa";
        private const string MS_SQL = "Lỗi SQL";
        khachHangBLL khachHangBLL = new khachHangBLL();
        public khachHang()
        {
            InitializeComponent();
        }

        private void khachHang_Load(object sender, EventArgs e)
        {
            loadDataToDataGridView(dgvKH, khachHangBLL.findAll());
        }
        private void loadDataToDataGridView(DataGridView dgv, DataTable dt)
        {
            dgv.DataSource = dt;
            dgv.AutoResizeColumns();
        }
        
        private void dgvKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvKH.CurrentRow.Index;
            tbMaKH.Text = dgvKH.Rows[r].Cells[0].Value.ToString();
            tbHoTen.Text = dgvKH.Rows[r].Cells[1].Value.ToString();
            tbSDT.Text = dgvKH.Rows[r].Cells[2].Value.ToString();
            tbGioiTinh.Text = dgvKH.Rows[r].Cells[3].Value.ToString();
            tbCMND.Text = dgvKH.Rows[r].Cells[4].Value.ToString();
            tbDiaChi.Text = dgvKH.Rows[r].Cells[5].Value.ToString();
        }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            tbHoTen.Text = "";
            tbCMND.Text = "";
            tbMaKH.Text = "";
            tbSDT.Text = "";
            tbGioiTinh.Text = "";
            tbDiaChi.Text = "";
           errorProviderNV.Clear();
            loadDataToDataGridView(dgvKH, khachHangBLL.findAll());
        }
        private bool checkValid(object sender, EventArgs e)
        {
            //check trống
            bool check = true;

            if (tbMaKH.Text.Trim() == "")
            {
                errorProviderNV.SetError(tbMaKH, MS_001);
                check = false;
            }
            else
                errorProviderNV.SetError(tbMaKH, "");

            if (tbHoTen.Text.Trim() == "")
            {
                errorProviderNV.SetError(tbHoTen, MS_001);
                check = false;
            }
            else
                errorProviderNV.SetError(tbHoTen, "");

            if (tbSDT.Text.Trim() == "")
            {
                errorProviderNV.SetError(tbSDT, MS_001);
                check = false;
            }
            else
                errorProviderNV.SetError(tbSDT, "");

            if (tbGioiTinh.Text.Trim() == "")
            {
                errorProviderNV.SetError(tbGioiTinh, MS_001);
                check = false;
            }
            else
                errorProviderNV.SetError(tbGioiTinh, "");

            if (tbCMND.Text.Trim() == "")
            {
                errorProviderNV.SetError(tbCMND, MS_001);
                check = false;
            }
            else
                errorProviderNV.SetError(tbCMND, "");
            if (tbDiaChi.Text.Trim() == "")
            {
                errorProviderNV.SetError(tbDiaChi, MS_001);
                check = false;
            }
            else
                errorProviderNV.SetError(tbDiaChi, "");

            //**************
            //*************
            return check;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkValid(sender, e))
                {
                    if (khachHangBLL.checkExistsNameAndCategory(tbMaKH.Text))
                    {
                        if (khachHangBLL.insert(tbMaKH.Text, tbHoTen.Text, tbSDT.Text, tbGioiTinh.Text, tbCMND.Text, tbDiaChi.Text))
                        {
                            MessageBox.Show(MS_002, MS_Notify, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            errorProviderNV.Clear();
                            loadDataToDataGridView(dgvKH, khachHangBLL.findAll());
                            btnLamMoi_Click(sender, e);
                        }
                        else
                        {
                            MessageBox.Show(MS_003, MS_Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show(MS_004, MS_Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                if (error.Contains("40"))
                {
                    MessageBox.Show(MS_SQL, MS_Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(MS_Error, MS_Warn, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkValid(sender, e))
                {

                    if (khachHangBLL.update(tbMaKH.Text, tbHoTen.Text, tbSDT.Text,tbGioiTinh.Text,  tbCMND.Text,tbDiaChi.Text ))
                    {
                        MessageBox.Show(MS_005, MS_Notify, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadDataToDataGridView(dgvKH, khachHangBLL.findAll());
                        btnLamMoi_Click(sender, e);
                    }
                    else
                        MessageBox.Show(MS_006, MS_Error, MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                if (error.Contains("40"))
                {
                    MessageBox.Show(MS_SQL, MS_Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(MS_Error, MS_Warn, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show(MS_Confirm, MS_Warn, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (khachHangBLL.deleteById(tbMaKH.Text))
                    {
                        MessageBox.Show(MS_007, MS_Notify, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadDataToDataGridView(dgvKH, khachHangBLL.findAll());
                        btnLamMoi_Click(sender, e);
                    }
                    else
                        MessageBox.Show(MS_008, MS_Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                if (error.Contains("40"))
                {
                    MessageBox.Show(MS_SQL, MS_Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(MS_Action, MS_Warn, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


            }
        }
    }
}
