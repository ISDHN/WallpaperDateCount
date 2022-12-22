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
using System.IO;

namespace WallpaperDateCounter
{
	public partial class Form1 : Form
	{
		private string registerlocation= @"SOFTWARE\WallpaperDateCounter";
		private string name;
		private DateTime date;
		private string background;
        private bool Needredraw = false;
		private Thread setthread;
		private Bitmap wallpaper = new Bitmap((int)System.Windows.SystemParameters.PrimaryScreenWidth, (int)System.Windows.SystemParameters.PrimaryScreenHeight);
		private const int SPI_SETDESKWALLPAPER = 0x0014;
		private const int SPIF_UPDATEINIFILE = 0x0001;
		private const int SPIF_SENDWININICHANGE = 0x0002;
		[DllImport("user32.dll",SetLastError = true)]
		private static extern int SystemParametersInfo(int uAction, int uParam, string lpvParam, int fuWinIni);
		public Form1()
		{
			InitializeComponent();
			this.ShowInTaskbar= false;
            RegistryKey key = Registry.CurrentUser.CreateSubKey(registerlocation, RegistryKeyPermissionCheck.ReadWriteSubTree);
			if (key != null)
			{
				name = (string)key.GetValue("EventName");
				EventTitle.Text = name;
				string _date = (string)key.GetValue("Date");
				if (_date != null)
				{
					date = DateTime.Parse(_date);
					Date.Value=date;
				}
                background = (string)key.GetValue("Background");
                File.FileName = background;
				key.Close();
            }
        }
		private void DrawAndSet()
		{		
			if (name != null && date != DateTime.MinValue)
			{
				int remains = (date - DateTime.Now).Days + 1;				
				Needredraw = true;
                while (true)
				{
					int _remain = (date - DateTime.Now).Days + 1;
					if(_remain!=remains)
					{
						remains= _remain;
						Needredraw= true;
					}
                    if (Needredraw)
					{
						Needredraw= false;
						Graphics container = Graphics.FromImage(wallpaper);
						try
						{
							Image backimg = new Bitmap(background);
							float k = Math.Min((float)wallpaper.Width / backimg.Width, (float)wallpaper.Height / backimg.Height);
							int height = (int)(backimg.Height * k);
							int width = (int)(backimg.Width * k);
							container.DrawImage(backimg, wallpaper.Width / 2 - width / 2, wallpaper.Height / 2 - height / 2, width, height);
							backimg.Dispose();
						}
						catch (Exception e)
						{
							container.FillRectangle(Brushes.Black, new Rectangle(0, 0, wallpaper.Width, wallpaper.Height));
							StreamWriter errdump = new StreamWriter(Application.StartupPath + "\\err.txt", true);
							errdump.WriteLine(e.Message); 
							errdump.Close();
						}
						container.PageUnit = GraphicsUnit.Pixel;
						string str1 = "离" + name + "还有";
						float size1 = wallpaper.Width / (str1.Length + 4);
						Font font1 = new Font(SystemFonts.DefaultFont.FontFamily, size1, FontStyle.Bold, GraphicsUnit.Pixel);
						string days = remains.ToString();
						string str2 = days + "天";
						float size2 = size1 * 1.5f;
						Font font2 = new Font(SystemFonts.DefaultFont.FontFamily, size2, GraphicsUnit.Pixel);
						container.DrawString(str1, font1, Brushes.Red, wallpaper.Width / 2 - container.MeasureString(str1, font1).Width / 2, wallpaper.Height / 2 - size1);
						container.DrawString(str2, font2, Brushes.Red, wallpaper.Width / 2 - container.MeasureString(str2, font2).Width / 2, wallpaper.Height / 2);
						wallpaper.Save(Application.StartupPath + "\\wallpaper.bmp", ImageFormat.Bmp);
						container.Dispose();
						font1.Dispose();
						font2.Dispose();
						SystemParametersInfo(SPI_SETDESKWALLPAPER, 0, Application.StartupPath + "\\wallpaper.bmp", SPIF_UPDATEINIFILE | SPIF_SENDWININICHANGE);
					}
				}
			}
		}
		private void Form1_Load(object sender, EventArgs e)
		{
				
			RegistryKey keyrun = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", RegistryKeyPermissionCheck.ReadWriteSubTree);
			keyrun.SetValue("WallpaperDateCounter", Application.ExecutablePath);
			setthread = new Thread(DrawAndSet);
			setthread.Start();
			keyrun.Close();
		}

		private void ShowSetting_Click(object sender, EventArgs e)
		{
			Show();
			BringToFront();
		}

		private void YesButton_Click(object sender, EventArgs e)
		{
			SaveProfile();
			CloseFrm();
		}
		private void SaveProfile()
		{
			RegistryKey key = Registry.CurrentUser.CreateSubKey(registerlocation, RegistryKeyPermissionCheck.ReadWriteSubTree);
			name = EventTitle.Text;
			date = Date.Value.Date;
			background = File.FileName;
            key.SetValue("EventName", name); ;
			key.SetValue("Date", date);
			key.SetValue("Background",background);
			key.Close();
			Needredraw= true;
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
			SaveProfile();
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
