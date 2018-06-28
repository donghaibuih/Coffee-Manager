using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace GUI
{
    public partial class TinhTien : MetroForm
    {
        double tienNhanVao = 0;
        double tienThoi = 0;
        double tienPhaiThanhToan;
        public TinhTien()
        {
            InitializeComponent();
        }
        public TinhTien(double tienPhaiThanhToan)
        {
            this.tienPhaiThanhToan = tienPhaiThanhToan;
            InitializeComponent();
        }

        private void TinhTien_Load(object sender, EventArgs e)
        {
            txt_tienPhaiThanhToan.Text = tienPhaiThanhToan.ToString();

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            tienNhanVao = double.Parse(txt_tienNhanVao.Text);
            tienThoi = tienNhanVao - tienPhaiThanhToan;
            txt_tienNhanVao.Text = tienNhanVao.ToString();
            txt_tienThoiLai.Text = tienThoi.ToString();



        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
