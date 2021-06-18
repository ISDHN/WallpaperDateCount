
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
            this.NotifyIconMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(146, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "事件名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(146, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "事件日期：";
            // 
            // WebAddress
            // 
            this.WebAddress.AutoSize = true;
            this.WebAddress.Location = new System.Drawing.Point(69, 235);
            this.WebAddress.Name = "WebAddress";
            this.WebAddress.Size = new System.Drawing.Size(115, 15);
            this.WebAddress.TabIndex = 2;
            this.WebAddress.TabStop = true;
            this.WebAddress.Text = "在Github上访问";
            // 
            // Date
            // 
            this.Date.CalendarForeColor = System.Drawing.Color.White;
            this.Date.CalendarMonthBackground = System.Drawing.Color.Black;
            this.Date.CalendarTitleBackColor = System.Drawing.Color.Black;
            this.Date.CalendarTitleForeColor = System.Drawing.Color.White;
            this.Date.Location = new System.Drawing.Point(234, 134);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(200, 25);
            this.Date.TabIndex = 3;
            // 
            // EventTitle
            // 
            this.EventTitle.Location = new System.Drawing.Point(234, 91);
            this.EventTitle.Name = "EventTitle";
            this.EventTitle.Size = new System.Drawing.Size(200, 25);
            this.EventTitle.TabIndex = 4;
            // 
            // YesBtn
            // 
            this.YesBtn.Location = new System.Drawing.Point(220, 216);
            this.YesBtn.Name = "YesBtn";
            this.YesBtn.Size = new System.Drawing.Size(86, 34);
            this.YesBtn.TabIndex = 5;
            this.YesBtn.Text = "确定";
            this.YesBtn.UseVisualStyleBackColor = true;
            this.YesBtn.Click += new System.EventHandler(this.YesButton_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(341, 216);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(86, 34);
            this.CancelBtn.TabIndex = 6;
            this.CancelBtn.Text = "取消";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(451, 216);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(86, 34);
            this.SaveBtn.TabIndex = 7;
            this.SaveBtn.Text = "应用";
            this.SaveBtn.UseVisualStyleBackColor = true;
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
            this.NotifyIconMenu.Size = new System.Drawing.Size(109, 28);
            // 
            // ShowSetting
            // 
            this.ShowSetting.ForeColor = System.Drawing.Color.White;
            this.ShowSetting.Name = "ShowSetting";
            this.ShowSetting.Size = new System.Drawing.Size(108, 24);
            this.ShowSetting.Text = "设置";
            this.ShowSetting.Click += new System.EventHandler(this.ShowSetting_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(585, 262);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.YesBtn);
            this.Controls.Add(this.EventTitle);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.WebAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "设置";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
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
    }
}

