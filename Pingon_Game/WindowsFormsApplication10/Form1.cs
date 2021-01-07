using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
namespace WindowsFormsApplication10
{
    public partial class Form1 : Form
    {
        public int hız_sol = 4;
        public int top_hız = 4;
        public int puan = 0;
        public Form1()
        {
            InitializeComponent();

            label1.Visible = false;
            timer1.Enabled = true;
            Cursor.Hide(); 
            this.FormBorderStyle = FormBorderStyle.None; 
            this.TopMost = true;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            raket.Top = arkaplan.Bottom - (arkaplan.Bottom / 10);  
            oyunbitti.Left = (arkaplan.Width / 2) - (oyunbitti.Width / 2);  
            oyunbitti.Top = (arkaplan.Height / 2) - (oyunbitti.Height / 2);
            oyunbitti.Visible = false;
   
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            raket.Left = Cursor.Position.X - (raket.Width / 2); 

            top.Left += hız_sol ; 
            top.Top += top_hız;
            
            if (top.Bottom >= raket.Top && top.Bottom <= raket.Bottom && top.Left >= raket.Left && top.Right <= raket.Right) //raket çarpışması
            {
                top_hız += 2;
                hız_sol += 2;
                top_hız = -top_hız; 
                puan += 1; 
                skorsay.Text = puan.ToString();
                int x, y, z;
                Random rnd = new Random(); 
                x = rnd.Next(255);
                y = rnd.Next(255);
                z = rnd.Next(255);
                arkaplan.BackColor = Color.FromArgb(x, y, z); 
                SoundPlayer ses = new SoundPlayer();
                string dizin = Application.StartupPath + "\\song.wav";  
                ses.SoundLocation = dizin;
                ses.Play();


            }
            if (top.Left <= arkaplan.Left)
            {
                hız_sol = -hız_sol;
            }
            if (top.Right >= arkaplan.Right)
            {
                hız_sol = -hız_sol;
            }
            if (top.Top <= arkaplan.Top)
            {
                top_hız = -top_hız;
            }
            if (top.Bottom >= arkaplan.Bottom)  
            {
                timer1.Enabled = false;  
                oyunbitti.Visible = true;
                label1.Visible = true;
                if (puan <= 1)
                {

                    label1.Text = "Çok Kötüsün";
                }
                if (puan == 1)
                {

                    label1.Text = "Çok Kötüsün";
                }
                if (puan >= 4)
                {

                    label1.Text = "İdare Eder Bir Yeteneğin Var";
                }
                if (puan >= 7)
                {

                    label1.Text = "Hmm Fena Değil";
                }
                if (puan >= 9)
                {
                    label1.Text = "Cidden Bu Konuda Yeteneklisin";
                }
                if (puan >= 15)
                {
                    label1.Text = "Mükemmel";
                }
                if (puan >= 20)
                {
                    label1.Text = "Rekor Sende";
                }

            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) 
            {
                this.Close();
            }
            if (e.KeyCode == Keys.F1) 
            {
                top.Top = 100;
                top.Left = 100;
                hız_sol = 4;
                top_hız = 4;
                puan = 0;
                skorsay.Text = "0";
                timer1.Enabled = true;
                oyunbitti.Visible = false;
                arkaplan.BackColor = Color.White;
                label1.Visible = false;
            }
        }
        
        private void oyunbitti_Click(object sender, EventArgs e)
        {

        }

        private void arkaplan_Paint(object sender, PaintEventArgs e)
        {

        }        
    }
}
