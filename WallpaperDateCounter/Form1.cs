using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Threading;

namespace WallpaperDateCounter
{
    public partial class Form1 : Form
    {
        private string registerlocation= @"SOFTWARE\WallpaperDateCounter";
        private Thread setstread;
        private Bitmap wallpaper = new Bitmap((int)System.Windows.SystemParameters.PrimaryScreenWidth, (int)System.Windows.SystemParameters.PrimaryScreenHeight);
        public Form1()
        {
            InitializeComponent();
        }
        private void Draw()
        {
            RegistryKey key = Registry.LocalMachine.CreateSubKey(registerlocation);
            string name = key.GetValue("EventName").ToString();
            DateTime date = DateTime.Parse(key.GetValue("Date").ToString());
            Graphics container =Graphics.FromImage(wallpaper);
            container.FillRectangle(Brushes.Black, new Rectangle(0,0,wallpaper.Width, wallpaper.Height));
            string str1 = "离" + name + "还有";
            string str2=(date - DateTime.Now.Days).Days + "天"
            container.DrawString(str1, new Font(SystemFonts.DefaultFont.FontFamily,64,GraphicsUnit.Pixel), Brushes.Red, wallpaper.Width / 2, wallpaper.Height / 2);
            wallpaper.Save(Application.StartupPath + "\\wallpaper.jpg");
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            RegistryKey key = Registry.LocalMachine.CreateSubKey(registerlocation);
            EventTitle.Text = key.GetValue("EventName").ToString();
            Date.Value = DateTime.Parse(key.GetValue("Date").ToString());
        }

        private void ShowSetting_Click(object sender, EventArgs e)
        {
            ShowInTaskbar = true;
            Show();
            BringToFront();
        }

        private void YesButton_Click(object sender, EventArgs e)
        {
            RegistryKey key = Registry.LocalMachine.CreateSubKey(registerlocation);
            key.SetValue("EventName", EventTitle.Text); ;
            key.SetValue("Date", Date.Value);
            CloseFrm();
        }
        private void CloseFrm()
        {
            this.Hide();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            CloseFrm();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            RegistryKey key = Registry.LocalMachine.CreateSubKey(registerlocation);
            key.SetValue("EventName", EventTitle.Text); ;
            key.SetValue("Date", Date.Value.Date);
            Draw();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            CloseFrm();
        }
    }
}
