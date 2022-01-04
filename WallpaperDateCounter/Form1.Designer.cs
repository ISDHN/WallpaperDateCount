
namespace WallpaperDateCounter
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.WebAddress = new System.Windows.Forms.LinkLabel();
            this.Date = new System.Windows.Forms.DateTimePicker();
            this.EventTitle = new System.Windows.Forms.TextBox();
            this.YesBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.NotifyIconMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ShowSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.Choose = new System.Windows.Forms.Button();
            this.File = new System.Windows.Forms.OpenFileDialog();
            this.NotifyIconMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(95, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "事件名：";
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(95, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "事件日期：";
            // 
            // WebAddress
            // 
            this.WebAddress.Location = new System.Drawing.Point(35, 187);
            this.WebAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WebAddress.Name = "WebAddress";
            this.WebAddress.Size = new System.Drawing.Size(131, 22);
            this.WebAddress.TabIndex = 2;
            this.WebAddress.TabStop = true;
            this.WebAddress.Text = "在Github上访问";
            this.WebAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.WebAddress.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.WebAddress_LinkClicked);
            // 
            // Date
            // 
            this.Date.CalendarForeColor = System.Drawing.Color.White;
            this.Date.CalendarMonthBackground = System.Drawing.Color.Black;
            this.Date.CalendarTitleBackColor = System.Drawing.Color.Black;
            this.Date.CalendarTitleForeColor = System.Drawing.Color.White;
            this.Date.Location = new System.Drawing.Point(182, 92);
            this.Date.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(151, 21);
            this.Date.TabIndex = 3;
            // 
            // EventTitle
            // 
            this.EventTitle.Location = new System.Drawing.Point(182, 52);
            this.EventTitle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EventTitle.Name = "EventTitle";
            this.EventTitle.Size = new System.Drawing.Size(151, 21);
            this.EventTitle.TabIndex = 4;
            // 
            // YesBtn
            // 
            this.YesBtn.BackColor = System.Drawing.Color.Black;
            this.YesBtn.ForeColor = System.Drawing.Color.White;
            this.YesBtn.Location = new System.Drawing.Point(182, 177);
            this.YesBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.YesBtn.Name = "YesBtn";
            this.YesBtn.Size = new System.Drawing.Size(75, 32);
            this.YesBtn.TabIndex = 5;
            this.YesBtn.Text = "确定";
            this.YesBtn.UseVisualStyleBackColor = false;
            this.YesBtn.Click += new System.EventHandler(this.YesButton_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.BackColor = System.Drawing.Color.Black;
            this.CancelBtn.ForeColor = System.Drawing.Color.White;
            this.CancelBtn.Location = new System.Drawing.Point(273, 177);
            this.CancelBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 32);
            this.CancelBtn.TabIndex = 6;
            this.CancelBtn.Text = "取消";
            this.CancelBtn.UseVisualStyleBackColor = false;
            this.CancelBtn.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackColor = System.Drawing.Color.Black;
            this.SaveBtn.ForeColor = System.Drawing.Color.White;
            this.SaveBtn.Location = new System.Drawing.Point(355, 177);
            this.SaveBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 32);
            this.SaveBtn.TabIndex = 7;
            this.SaveBtn.Text = "应用";
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipText = "桌面壁纸倒计时";
            this.notifyIcon1.ContextMenuStrip = this.NotifyIconMenu;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "桌面壁纸倒计时";
            this.notifyIcon1.Visible = true;
            // 
            // NotifyIconMenu
            // 
            this.NotifyIconMenu.BackColor = System.Drawing.Color.Black;
            this.NotifyIconMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.NotifyIconMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowSetting});
            this.NotifyIconMenu.Name = "NotifyIconMenu";
            this.NotifyIconMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.NotifyIconMenu.Size = new System.Drawing.Size(101, 26);
            // 
            // ShowSetting
            // 
            this.ShowSetting.ForeColor = System.Drawing.Color.White;
            this.ShowSetting.Name = "ShowSetting";
            this.ShowSetting.Size = new System.Drawing.Size(100, 22);
            this.ShowSetting.Text = "设置";
            this.ShowSetting.Click += new System.EventHandler(this.ShowSetting_Click);
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(95, 127);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "背景图像：";
            // 
            // Choose
            // 
            this.Choose.AutoSize = true;
            this.Choose.BackColor = System.Drawing.Color.Black;
            this.Choose.ForeColor = System.Drawing.Color.White;
            this.Choose.Location = new System.Drawing.Point(182, 127);
            this.Choose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Choose.Name = "Choose";
            this.Choose.Size = new System.Drawing.Size(75, 24);
            this.Choose.TabIndex = 10;
            this.Choose.Text = "选择文件";
            this.Choose.UseVisualStyleBackColor = false;
            this.Choose.Click += new System.EventHandler(this.Choose_Click);
            // 
            // File
            // 
            this.File.Filter = "图像文件|*.jpg;*.bmp;*.png";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(463, 242);
            this.Controls.Add(this.Choose);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.YesBtn);
            this.Controls.Add(this.EventTitle);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.WebAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.NotifyIconMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion        
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel WebAddress;
        private System.Windows.Forms.DateTimePicker Date;
        private System.Windows.Forms.TextBox EventTitle;
        private System.Windows.Forms.Button YesBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip NotifyIconMenu;
        private System.Windows.Forms.ToolStripMenuItem ShowSetting;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Choose;
        private System.Windows.Forms.OpenFileDialog File;
    }
}

