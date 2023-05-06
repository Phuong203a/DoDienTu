using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace DoDienTu
{
    public partial class FormLogin : Form
    {
        DataModel dm;
        public FormLogin()
        {
            InitializeComponent();
            LoadDataModel();
        }

        private void LoadDataModel()
        {
            dm = new DataModel();

        }

        static string salt = "AQWSDRW";
        public static string SaltedHash(string password)
        {
            return Hash(Hash(password) + salt);
        }
        public static string Hash(string input)
        {
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                var hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(input));
                var sb = new StringBuilder(hash.Length * 2);

                foreach (byte b in hash)
                {
                    // can be "x2" if you want lowercase
                    sb.Append(b.ToString("X2"));
                }

                return sb.ToString();
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLg_Click(object sender, EventArgs e)
        {
            string hashed = SaltedHash(txtPass.Text);
            //MessageBox.Show(hashed+" "+ txtUser.Text);
            List<Dictionary<string, string>> rows = dm.FetchAllRowUr();
            foreach (Dictionary<string, string> row in rows)
            {
                if(row["TenDangNhap"] == txtUser.Text)
                {
                    if (row["MatKhau"] == hashed)
                    {
                        MessageBox.Show("Đăng nhập thành công");
                        if(row["PhanQuyen"] == "admin")
                        {
                            FormHome fh = new FormHome();
                            fh.ShowDialog();
                            this.Close();
                            break;
                        }
                        else
                        {
                            FormPurchase fp = new FormPurchase();
                            fp.ShowDialog();
                            this.Close();
                            break;
                        }
                    }
                    else
                        MessageBox.Show("Mật khẩu không chính xác");
                }
            }
        }
    }
}
