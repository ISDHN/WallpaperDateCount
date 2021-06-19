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
using System.Runtime.InteropServices;
using System.Drawing.Imaging;
using System.Diagnostics;

namespace WallpaperDateCounter
{
	public partial class Form1 : Form
	{
		private string registerlocation= @"SOFTWARE\WallpaperDateCounter";
		private Thread setthread;
		private Bitmap wallpaper;
		
		private const int SPI_SETDESKWALLPAPER = 0x0014;
		private const int SPIF_UPDATEINIFILE = 0x0001;
		private const int SPIF_SENDWININICHANGE = 0x0002;
		[DllImport("user32.dll",SetLastError = true)]
		private static extern int SystemParametersInfo(int uAction, int uParam, string lpvParam, int fuWinIni);
		public Form1()
		{
			InitializeComponent();
		}
		private void DrawAndSet()
		{
			RegistryKey key = Registry.LocalMachine.CreateSubKey(registerlocation);
			if (key != null)
			{
				string name = (string)key.GetValue("EventName");
				string _date = (string)key.GetValue("Date");
				if (name != null && _date != null)
				{
					DateTime date = DateTime.Parse(_date);
					int width = (int)System.Windows.SystemParameters.PrimaryScreenWidth;
					int height = (int)System.Windows.SystemParameters.PrimaryScreenHeight;
					wallpaper = new Bitmap(width, height);
					Graphics container = Graphics.FromImage(wallpaper);
					container.FillRectangle(Brushes.Black, new Rectangle(0, 0, wallpaper.Width, wallpaper.Height));
					string str1 = "离" + name + "还有";
					int size1 = width / (str1.Length + 4);
					string str2 = (date - DateTime.Now.Date).Days + "天";
					int size2 = (int)(size1 * 1.5);
					container.DrawString(str1, new Font(SystemFonts.DefaultFont.FontFamily, size1, GraphicsUnit.Pixel), Brushes.Red, width / 2 - (str1.Length * size1) / 2, height / 2 - size1);
					container.DrawString(str2, new Font(SystemFonts.DefaultFont.FontFamily, size2, GraphicsUnit.Pixel), Brushes.Red, width / 2 - (str2.Length * size2) / 2, height / 2);
					wallpaper.Save(Application.StartupPath + "\\wallpaper.bmp", ImageFormat.Bmp);
					SystemParametersInfo(SPI_SETDESKWALLPAPER, 0, Application.StartupPath + "\\wallpaper.bmp", SPIF_UPDATEINIFILE | SPIF_SENDWININICHANGE);
					Thread.Sleep(2000);
				}
			}
		}
		private void Form1_Load(object sender, EventArgs e)
		{
			RegistryKey keydata = Registry.LocalMachine.CreateSubKey(registerlocation);
			if (keydata != null)
			{
				EventTitle.Text = (string)keydata.GetValue("EventName");
				string date = (string)keydata.GetValue("Date");
				if (date!= null)
					Date.Value = DateTime.Parse(date);
			}
			RegistryKey keyrun = Registry.LocalMachine.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run");
			keyrun.SetValue("WallpaperDateCounter", Application.ExecutablePath);
			setthread = new Thread(() =>
			{
				while (true)
					DrawAndSet();
			});
			setthread.Start();
			
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
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			CloseFrm();
		}

        private void WebAddress_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
			Process.Start(@"https://github.com/ISDHN/WallpaperDateCounter");
        }
    }
}
