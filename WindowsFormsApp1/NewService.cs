using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Model.Context;
using WindowsFormsApp1.Model.Entity;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        int mov;
        int movX;
        int movY;
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelBanner_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void panelBanner_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void panelBanner_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
            OtoContext otoContext = new OtoContext();
            UrunDetay urunDetay = new UrunDetay { UrunMarka="Deneme", UrunModel="Deneme", UrunUretimTarihi=DateTime.Now };
            Stok stok = new Stok { UrunDetayId = urunDetay, Adet = 10, Birimi = "Tane" };
            otoContext.UrunDetay.Add(urunDetay);
            otoContext.Stok.Add(stok);
            otoContext.SaveChanges();
        }
    }
}
