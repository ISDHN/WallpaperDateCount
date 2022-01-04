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
			RegistryKey key = Registry.CurrentUser.CreateSubKey(registerlocation,RegistryKeyPermissionCheck.ReadWriteSubTree);
			if (key != null)
			{
				string name = (string)key.GetValue("EventName");
				string _date = (string)key.GetValue("Date");
				string background = (string)key.GetValue("Background");
				if (name != null && _date != null)
				{
					DateTime date = DateTime.Parse(_date);
					int width;
					int height;
					Graphics container;
					try
					{
						wallpaper = new Bitmap(background);
						container = Graphics.FromImage(wallpaper);
						width = wallpaper.Width;
						height = wallpaper.Height;
					}
					catch
					{
						width = (int)System.Windows.SystemParameters.PrimaryScreenWidth;
						height = (int)System.Windows.SystemParameters.PrimaryScreenHeight;
						wallpaper = new Bitmap(width, height);
						container = Graphics.FromImage(wallpaper);
						container.FillRectangle(Brushes.Black, new Rectangle(0, 0, wallpaper.Width, wallpaper.Height));
					}
					container.PageUnit = GraphicsUnit.Pixel;
					string str1 = "离" + name + "还有";
					float size1 = width / (str1.Length + 4);
					Font font1 = new Font(SystemFonts.DefaultFont.FontFamily, size1, FontStyle.Bold, GraphicsUnit.Pixel);
					string days = (date - DateTime.Now).Days.ToString();
					string str2 = days + "天";
					float size2 = size1 * 1.5f;
					Font font2 = new Font(SystemFonts.DefaultFont.FontFamily, size2, GraphicsUnit.Pixel);
					container.DrawString(str1, font1, Brushes.Red, width / 2 - container.MeasureString(str1,font1).Width/ 2, height / 2 - size1);
					container.DrawString(str2, font2 , Brushes.Red, width / 2 - container.MeasureString(str2, font2).Width / 2, height / 2);
					wallpaper.Save(Application.StartupPath + "\\wallpaper.bmp", ImageFormat.Bmp);
					container.Dispose();
					wallpaper.Dispose();
					SystemParametersInfo(SPI_SETDESKWALLPAPER, 0, Application.StartupPath + "\\wallpaper.bmp", SPIF_UPDATEINIFILE | SPIF_SENDWININICHANGE);
					Thread.Sleep(2000);
				}
			}
		}
		private void Form1_Load(object sender, EventArgs e)
		{
			RegistryKey keydata = Registry.CurrentUser.CreateSubKey(registerlocation, RegistryKeyPermissionCheck.ReadWriteSubTree);
			if (keydata != null)
			{
				EventTitle.Text = (string)keydata.GetValue("EventName");
				string date = (string)keydata.GetValue("Date");
				File.FileName= (string)keydata.GetValue("Background");
				if (date!= null)
					Date.Value = DateTime.Parse(date);
			}
			RegistryKey keyrun = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", RegistryKeyPermissionCheck.ReadWriteSubTree);
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
			Show();
			BringToFront();
		}

		private void YesButton_Click(object sender, EventArgs e)
		{
			RegistryKey key = Registry.CurrentUser.CreateSubKey(registerlocation, RegistryKeyPermissionCheck.ReadWriteSubTree);
			key.SetValue("EventName", EventTitle.Text); ;
			key.SetValue("Date", Date.Value);
			key.SetValue("Background", File.FileName);
			CloseFrm();
		}
		private void CloseFrm()
		{
			this.ShowInTaskbar = false;
			this.Hide();
		}

		private void CancelButton_Click(object sender, EventArgs e)
		{
			CloseFrm();
		}

		private void SaveButton_Click(object sender, EventArgs e)
		{
			RegistryKey key = Registry.CurrentUser.CreateSubKey(registerlocation, RegistryKeyPermissionCheck.ReadWriteSubTree);
			key.SetValue("EventName", EventTitle.Text); ;
			key.SetValue("Date", Date.Value.Date);
			key.SetValue("Background",File.FileName);
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = true;
			CloseFrm();
		}

		private void WebAddress_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start(@"https://github.com/ISDHN/WallpaperDateCounter");
		}

		private void Choose_Click(object sender, EventArgs e)
		{
			File.ShowDialog();
		}

		private void Form1_Shown(object sender, EventArgs e)
		{
			CloseFrm();
		}
	}
}
