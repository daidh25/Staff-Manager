using De_On_Tap_Kttx2_Lan1.Models;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace De_On_Tap_Kttx2_Lan1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        QlthongTinContext db = new QlthongTinContext();
        private void HienThi()
        {
            dgNhanVien.ItemsSource = db.NhanViens.Select(x => new
            {
                x.MaNv,
                x.HoTen,
                x.GioiTinh,
                x.PhongBan,
                x.NgaySinh,
                Tuoi = DateTime.Now.Year - x.NgaySinh.Value.Year -
           (DateTime.Now.Date < x.NgaySinh.Value.Date ? 1 : 0)
            }).ToList();
        }

        private void HienThiCB()
        {
            cbbPhongBan.ItemsSource = db.NhanViens.Select(x => x).ToList();
            cbbPhongBan.DisplayMemberPath = "PhongBan";
            cbbPhongBan.SelectedValue = "PhongBan";
            cbbPhongBan.SelectedIndex = 0;
        }
        private bool Check()
        {
            if(txtMaNv.Text == "")
            {
                MessageBox.Show("Mã nhân viên không được để trống!!", "thông báo");
                return false;
            }else if(txtHoTen.Text == "")
            {
                MessageBox.Show("Ho ten nhân viên không được để trống!!", "thông báo");
                return false;
            }else if(DateTime.Now.Year - dpNS.SelectedDate.Value.Year -
           (DateTime.Now.Date < dpNS.SelectedDate.Value.Date ? 1 : 0) < 18 )
            {
                MessageBox.Show("Tuổi không được nhỏ hơn 18 ạ!!", "thông báo");
                return false;
            }else if(cbbPhongBan.SelectedItem == null)
            {
                MessageBox.Show("Phong ban viên không được để trống!!", "thông báo");
                return false;
            }else if(float.Parse(txtHSLuong.Text) < 0)
            {
                MessageBox.Show("He so luong nhân viên không được âm!!", "thông báo");
                return false;
            }
            return true;
        }
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            HienThi();
            HienThiCB();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(db.NhanViens.SingleOrDefault(x => x.MaNv == txtMaNv.Text) != null)
            {
                MessageBox.Show("Da co nhan vien do a!!!", "Thong bao");
                return;
            }
            try
            {
                if (Check())
                {
                    NhanVien nv = new NhanVien();
                    nv.MaNv = txtMaNv.Text;
                    nv.HoTen = txtHoTen.Text;
                    nv.NgaySinh = dpNS.SelectedDate;
                    if (rbNam.IsChecked == true)
                    {
                        nv.GioiTinh = "Nam";
                    }
                    else
                        nv.GioiTinh = "Nữ";
                    NhanVien x = cbbPhongBan.SelectedItem as NhanVien;
                    nv.PhongBan = x.PhongBan;
                    nv.Hsluong = float.Parse(txtHSLuong.Text);
                    db.Add(nv);
                    db.SaveChanges();
                    MessageBox.Show("Da them thanh cong a!!!", "Thong bao");
                    HienThi();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Thong bao");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window2 mh2 = new Window2();
            mh2.Show();
        }
    }
}
