using CafeOtomasyon.Entities.Models;
using DevExpress.XtraBars.Customization.Helpers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeOtomasyonu.WinForms.WinTools
{
    public class DinamicTables
    {
        public static void MasalariGetir(CafeContext context, FlowLayoutPanel pnl)
        {
            var model = context.Masalar.ToList();
            for (int i = 0; i < model.Count; i++)
            {
                var  btn = new CheckButton();
                btn.Text = model[i].MasaAdi;
                btn.Name = model[i].Id.ToString();
                btn.Height = 64;
                btn.Width = 64;
                pnl.Controls.Add(btn);
                if (model[i].RezerveDurmu && !model[i].Durumu)
                {
                    btn.Appearance.BackColor = Color.DarkOrange;
                }
                else if (model[i].Durumu)
                {
                    btn.Appearance.BackColor = Color.Red;
                }
                else if (!model[i].Durumu)
                {
                    btn.Appearance.BackColor = Color.DarkGreen;
                }
                btn.Click += Btn_Click;
                //btn.Click += Btn_Click;
            }
        }

        private static void Btn_Click(object sender, EventArgs e)
        {
            var btn = sender as CheckButton;
            MessageBox.Show("Masa Adı : " + btn.Text+ " " +"Masa ID"+btn.Name);
        }

        //private void Btn_Click(object sender, EventArgs e)
        //{
        //    var btn = sender as CheckButton;
        //    MessageBox.Show(btn.Text);
        //}
    }
}
