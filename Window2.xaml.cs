using De_On_Tap_Kttx2_Lan1.Models;
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
using System.Windows.Shapes;

namespace De_On_Tap_Kttx2_Lan1
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }
        QlthongTinContext db = new QlthongTinContext();

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            int max = db.NhanViens.Max(x => DateTime.Now.Year - x.NgaySinh.Value.Year -
           (DateTime.Now.Date < x.NgaySinh.Value.Date ? 1 : 0));
            dgNhanVien.ItemsSource = db.NhanViens.Where(x => DateTime.Now.Year - x.NgaySinh.Value.Year -
           (DateTime.Now.Date < x.NgaySinh.Value.Date ? 1 : 0) == max).Select(x => new
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
    }
}
