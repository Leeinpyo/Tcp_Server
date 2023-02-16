﻿
namespace Tcp_Client
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PanelUpper = new System.Windows.Forms.Panel();
            this.ButtonMin = new System.Windows.Forms.Button();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.Label_upper = new System.Windows.Forms.Label();
            this.PanelSide = new System.Windows.Forms.Panel();
            this.Button_hide = new System.Windows.Forms.Button();
            this.PanelSlide_H = new System.Windows.Forms.Panel();
            this.PanelSlide_W = new System.Windows.Forms.Panel();
            this.PanelMain = new System.Windows.Forms.Panel();
            this.ButtonConnect = new System.Windows.Forms.Button();
            this.PictureBox_connect = new System.Windows.Forms.PictureBox();
            this.Label_connect = new System.Windows.Forms.Label();
            this.Timer_W = new System.Windows.Forms.Timer(this.components);
            this.Timer_H = new System.Windows.Forms.Timer(this.components);
            this.Timer_ONLINE = new System.Windows.Forms.Timer(this.components);
            this.PanelUpper.SuspendLayout();
            this.PanelSide.SuspendLayout();
            this.PanelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_connect)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelUpper
            // 
            this.PanelUpper.Controls.Add(this.ButtonMin);
            this.PanelUpper.Controls.Add(this.ButtonClose);
            this.PanelUpper.Controls.Add(this.Label_upper);
            this.PanelUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelUpper.Location = new System.Drawing.Point(0, 0);
            this.PanelUpper.Name = "PanelUpper";
            this.PanelUpper.Size = new System.Drawing.Size(800, 42);
            this.PanelUpper.TabIndex = 0;
            // 
            // ButtonMin
            // 
            this.ButtonMin.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ButtonMin.BackgroundImage = global::Tcp_Client.Properties.Resources.Free_Flat_Hyphen_Icon;
            this.ButtonMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonMin.FlatAppearance.BorderSize = 0;
            this.ButtonMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonMin.Location = new System.Drawing.Point(736, 10);
            this.ButtonMin.Name = "ButtonMin";
            this.ButtonMin.Size = new System.Drawing.Size(22, 22);
            this.ButtonMin.TabIndex = 0;
            this.ButtonMin.UseVisualStyleBackColor = true;
            this.ButtonMin.Click += new System.EventHandler(this.ButtonMin_Click);
            // 
            // ButtonClose
            // 
            this.ButtonClose.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ButtonClose.BackgroundImage = global::Tcp_Client.Properties.Resources.Free_Flat_Button_Blank_Cross_Icon;
            this.ButtonClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonClose.FlatAppearance.BorderSize = 0;
            this.ButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonClose.Location = new System.Drawing.Point(767, 10);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(22, 22);
            this.ButtonClose.TabIndex = 0;
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // Label_upper
            // 
            this.Label_upper.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_upper.AutoSize = true;
            this.Label_upper.Location = new System.Drawing.Point(300, 12);
            this.Label_upper.Name = "Label_upper";
            this.Label_upper.Size = new System.Drawing.Size(200, 18);
            this.Label_upper.TabIndex = 0;
            this.Label_upper.Text = "TCP Server Control Panel";
            this.Label_upper.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelSide
            // 
            this.PanelSide.BackColor = System.Drawing.Color.DimGray;
            this.PanelSide.Controls.Add(this.Button_hide);
            this.PanelSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelSide.Location = new System.Drawing.Point(0, 42);
            this.PanelSide.Name = "PanelSide";
            this.PanelSide.Size = new System.Drawing.Size(42, 408);
            this.PanelSide.TabIndex = 1;
            // 
            // Button_hide
            // 
            this.Button_hide.BackgroundImage = global::Tcp_Client.Properties.Resources.Free_Flat_Menu_2_Icon;
            this.Button_hide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Button_hide.FlatAppearance.BorderSize = 0;
            this.Button_hide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_hide.Location = new System.Drawing.Point(0, 10);
            this.Button_hide.Name = "Button_hide";
            this.Button_hide.Size = new System.Drawing.Size(42, 24);
            this.Button_hide.TabIndex = 0;
            this.Button_hide.UseVisualStyleBackColor = true;
            this.Button_hide.Click += new System.EventHandler(this.Button_hide_Click);
            // 
            // PanelSlide_H
            // 
            this.PanelSlide_H.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PanelSlide_H.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSlide_H.Location = new System.Drawing.Point(42, 42);
            this.PanelSlide_H.Name = "PanelSlide_H";
            this.PanelSlide_H.Size = new System.Drawing.Size(758, 2);
            this.PanelSlide_H.TabIndex = 2;
            // 
            // PanelSlide_W
            // 
            this.PanelSlide_W.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PanelSlide_W.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelSlide_W.Location = new System.Drawing.Point(42, 44);
            this.PanelSlide_W.Name = "PanelSlide_W";
            this.PanelSlide_W.Size = new System.Drawing.Size(172, 406);
            this.PanelSlide_W.TabIndex = 3;
            // 
            // PanelMain
            // 
            this.PanelMain.Controls.Add(this.ButtonConnect);
            this.PanelMain.Controls.Add(this.PictureBox_connect);
            this.PanelMain.Controls.Add(this.Label_connect);
            this.PanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelMain.Location = new System.Drawing.Point(214, 44);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.Size = new System.Drawing.Size(586, 406);
            this.PanelMain.TabIndex = 4;
            // 
            // ButtonConnect
            // 
            this.ButtonConnect.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ButtonConnect.Font = new System.Drawing.Font("D2Coding ligature", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ButtonConnect.ForeColor = System.Drawing.Color.Black;
            this.ButtonConnect.Location = new System.Drawing.Point(240, 218);
            this.ButtonConnect.Name = "ButtonConnect";
            this.ButtonConnect.Size = new System.Drawing.Size(106, 23);
            this.ButtonConnect.TabIndex = 1;
            this.ButtonConnect.Text = "Connect";
            this.ButtonConnect.UseVisualStyleBackColor = true;
            this.ButtonConnect.Click += new System.EventHandler(this.ButtonConnect_Click);
            // 
            // PictureBox_connect
            // 
            this.PictureBox_connect.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.PictureBox_connect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureBox_connect.Image = global::Tcp_Client.Properties.Resources.Free_Flat_Signal_Up_Off_Icon;
            this.PictureBox_connect.Location = new System.Drawing.Point(240, 61);
            this.PictureBox_connect.Name = "PictureBox_connect";
            this.PictureBox_connect.Size = new System.Drawing.Size(106, 105);
            this.PictureBox_connect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox_connect.TabIndex = 0;
            this.PictureBox_connect.TabStop = false;
            // 
            // Label_connect
            // 
            this.Label_connect.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Label_connect.AutoSize = true;
            this.Label_connect.Font = new System.Drawing.Font("D2Coding ligature", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Label_connect.Location = new System.Drawing.Point(179, 186);
            this.Label_connect.Name = "Label_connect";
            this.Label_connect.Size = new System.Drawing.Size(228, 28);
            this.Label_connect.TabIndex = 0;
            this.Label_connect.Text = "TCP Server OFFLINE";
            this.Label_connect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Timer_W
            // 
            this.Timer_W.Interval = 2;
            this.Timer_W.Tick += new System.EventHandler(this.Timer_W_Tick);
            // 
            // Timer_H
            // 
            this.Timer_H.Interval = 14;
            this.Timer_H.Tick += new System.EventHandler(this.Timer_H_Tick);
            // 
            // Timer_ONLINE
            // 
            this.Timer_ONLINE.Interval = 260;
            this.Timer_ONLINE.Tick += new System.EventHandler(this.Timer_ONLINE_Tick);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PanelMain);
            this.Controls.Add(this.PanelSlide_W);
            this.Controls.Add(this.PanelSlide_H);
            this.Controls.Add(this.PanelSide);
            this.Controls.Add(this.PanelUpper);
            this.Font = new System.Drawing.Font("D2Coding ligature", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.PanelUpper.ResumeLayout(false);
            this.PanelUpper.PerformLayout();
            this.PanelSide.ResumeLayout(false);
            this.PanelMain.ResumeLayout(false);
            this.PanelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_connect)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelUpper;
        private System.Windows.Forms.Label Label_upper;
        private System.Windows.Forms.Panel PanelSide;
        private System.Windows.Forms.Button ButtonMin;
        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.Button Button_hide;
        private System.Windows.Forms.Panel PanelSlide_H;
        private System.Windows.Forms.Panel PanelSlide_W;
        private System.Windows.Forms.Panel PanelMain;
        private System.Windows.Forms.Label Label_connect;
        private System.Windows.Forms.Timer Timer_W;
        private System.Windows.Forms.PictureBox PictureBox_connect;
        private System.Windows.Forms.Timer Timer_H;
        private System.Windows.Forms.Timer Timer_ONLINE;
        private System.Windows.Forms.Button ButtonConnect;
    }
}
