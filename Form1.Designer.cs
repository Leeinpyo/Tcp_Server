
namespace Tcp_Server
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
            this.Label_upper = new System.Windows.Forms.Label();
            this.PanelSide = new System.Windows.Forms.Panel();
            this.PanelSlide_H = new System.Windows.Forms.Panel();
            this.PanelSlide_W = new System.Windows.Forms.Panel();
            this.TextBox_SendText = new System.Windows.Forms.TextBox();
            this.Label_port = new System.Windows.Forms.Label();
            this.Label_ip = new System.Windows.Forms.Label();
            this.ConnectTextBox = new System.Windows.Forms.RichTextBox();
            this.TextBox_IPport = new System.Windows.Forms.TextBox();
            this.TextBox_IPadress = new System.Windows.Forms.TextBox();
            this.PanelMain = new System.Windows.Forms.Panel();
            this.ButtonConnect = new System.Windows.Forms.Button();
            this.Label_connect = new System.Windows.Forms.Label();
            this.Timer_W = new System.Windows.Forms.Timer(this.components);
            this.Timer_H = new System.Windows.Forms.Timer(this.components);
            this.Timer_ONLINE = new System.Windows.Forms.Timer(this.components);
            this.PictureBox_connect = new System.Windows.Forms.PictureBox();
            this.Button_SendText = new System.Windows.Forms.Button();
            this.Button_hide = new System.Windows.Forms.Button();
            this.ButtonMin = new System.Windows.Forms.Button();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.PanelUpper.SuspendLayout();
            this.PanelSide.SuspendLayout();
            this.PanelSlide_W.SuspendLayout();
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
            this.PanelSlide_W.Controls.Add(this.Button_SendText);
            this.PanelSlide_W.Controls.Add(this.TextBox_SendText);
            this.PanelSlide_W.Controls.Add(this.Label_port);
            this.PanelSlide_W.Controls.Add(this.Label_ip);
            this.PanelSlide_W.Controls.Add(this.ConnectTextBox);
            this.PanelSlide_W.Controls.Add(this.TextBox_IPport);
            this.PanelSlide_W.Controls.Add(this.TextBox_IPadress);
            this.PanelSlide_W.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelSlide_W.Location = new System.Drawing.Point(42, 44);
            this.PanelSlide_W.Name = "PanelSlide_W";
            this.PanelSlide_W.Size = new System.Drawing.Size(316, 406);
            this.PanelSlide_W.TabIndex = 3;
            // 
            // TextBox_SendText
            // 
            this.TextBox_SendText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox_SendText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TextBox_SendText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox_SendText.Location = new System.Drawing.Point(10, 311);
            this.TextBox_SendText.Name = "TextBox_SendText";
            this.TextBox_SendText.Size = new System.Drawing.Size(263, 19);
            this.TextBox_SendText.TabIndex = 3;
            // 
            // Label_port
            // 
            this.Label_port.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_port.AutoSize = true;
            this.Label_port.Font = new System.Drawing.Font("D2Coding ligature", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Label_port.ForeColor = System.Drawing.Color.Black;
            this.Label_port.Location = new System.Drawing.Point(235, 17);
            this.Label_port.Name = "Label_port";
            this.Label_port.Size = new System.Drawing.Size(40, 18);
            this.Label_port.TabIndex = 2;
            this.Label_port.Text = "Port";
            this.Label_port.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // Label_ip
            // 
            this.Label_ip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_ip.AutoSize = true;
            this.Label_ip.Font = new System.Drawing.Font("D2Coding ligature", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Label_ip.ForeColor = System.Drawing.Color.Black;
            this.Label_ip.Location = new System.Drawing.Point(11, 17);
            this.Label_ip.Name = "Label_ip";
            this.Label_ip.Size = new System.Drawing.Size(88, 18);
            this.Label_ip.TabIndex = 2;
            this.Label_ip.Text = "IP address";
            this.Label_ip.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // ConnectTextBox
            // 
            this.ConnectTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ConnectTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ConnectTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ConnectTextBox.Font = new System.Drawing.Font("D2Coding ligature", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ConnectTextBox.Location = new System.Drawing.Point(10, 48);
            this.ConnectTextBox.Name = "ConnectTextBox";
            this.ConnectTextBox.ReadOnly = true;
            this.ConnectTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.ConnectTextBox.Size = new System.Drawing.Size(296, 256);
            this.ConnectTextBox.TabIndex = 1;
            this.ConnectTextBox.TabStop = false;
            this.ConnectTextBox.Text = "";
            // 
            // TextBox_IPport
            // 
            this.TextBox_IPport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox_IPport.Font = new System.Drawing.Font("D2Coding ligature", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TextBox_IPport.Location = new System.Drawing.Point(279, 15);
            this.TextBox_IPport.Name = "TextBox_IPport";
            this.TextBox_IPport.Size = new System.Drawing.Size(28, 23);
            this.TextBox_IPport.TabIndex = 0;
            this.TextBox_IPport.Text = "666";
            this.TextBox_IPport.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBox_IPadress
            // 
            this.TextBox_IPadress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox_IPadress.Font = new System.Drawing.Font("D2Coding ligature", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TextBox_IPadress.Location = new System.Drawing.Point(103, 15);
            this.TextBox_IPadress.Name = "TextBox_IPadress";
            this.TextBox_IPadress.ReadOnly = true;
            this.TextBox_IPadress.Size = new System.Drawing.Size(123, 23);
            this.TextBox_IPadress.TabIndex = 0;
            this.TextBox_IPadress.TabStop = false;
            this.TextBox_IPadress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PanelMain
            // 
            this.PanelMain.Controls.Add(this.ButtonConnect);
            this.PanelMain.Controls.Add(this.PictureBox_connect);
            this.PanelMain.Controls.Add(this.Label_connect);
            this.PanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelMain.Location = new System.Drawing.Point(358, 44);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.Size = new System.Drawing.Size(442, 406);
            this.PanelMain.TabIndex = 4;
            // 
            // ButtonConnect
            // 
            this.ButtonConnect.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ButtonConnect.Font = new System.Drawing.Font("D2Coding ligature", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ButtonConnect.ForeColor = System.Drawing.Color.Black;
            this.ButtonConnect.Location = new System.Drawing.Point(175, 218);
            this.ButtonConnect.Name = "ButtonConnect";
            this.ButtonConnect.Size = new System.Drawing.Size(106, 23);
            this.ButtonConnect.TabIndex = 1;
            this.ButtonConnect.Text = "Connect";
            this.ButtonConnect.UseVisualStyleBackColor = true;
            this.ButtonConnect.Click += new System.EventHandler(this.ButtonConnect_Click);
            // 
            // Label_connect
            // 
            this.Label_connect.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Label_connect.AutoSize = true;
            this.Label_connect.Font = new System.Drawing.Font("D2Coding ligature", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Label_connect.Location = new System.Drawing.Point(114, 186);
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
            // PictureBox_connect
            // 
            this.PictureBox_connect.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.PictureBox_connect.Image = global::Tcp_Server.Properties.Resources.Free_Flat_Signal_Up_Off_Icon;
            this.PictureBox_connect.Location = new System.Drawing.Point(175, 61);
            this.PictureBox_connect.Name = "PictureBox_connect";
            this.PictureBox_connect.Size = new System.Drawing.Size(106, 105);
            this.PictureBox_connect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox_connect.TabIndex = 0;
            this.PictureBox_connect.TabStop = false;
            // 
            // Button_SendText
            // 
            this.Button_SendText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_SendText.BackgroundImage = global::Tcp_Server.Properties.Resources.Free_Flat_Chat_2_Bars_Icon;
            this.Button_SendText.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Button_SendText.FlatAppearance.BorderSize = 0;
            this.Button_SendText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_SendText.ForeColor = System.Drawing.Color.White;
            this.Button_SendText.Location = new System.Drawing.Point(277, 309);
            this.Button_SendText.Name = "Button_SendText";
            this.Button_SendText.Size = new System.Drawing.Size(29, 22);
            this.Button_SendText.TabIndex = 4;
            this.Button_SendText.TabStop = false;
            this.Button_SendText.UseVisualStyleBackColor = false;
            this.Button_SendText.Click += new System.EventHandler(this.Button_SendText_Click);
            // 
            // Button_hide
            // 
            this.Button_hide.BackgroundImage = global::Tcp_Server.Properties.Resources.Free_Flat_Menu_2_Icon;
            this.Button_hide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Button_hide.FlatAppearance.BorderSize = 0;
            this.Button_hide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_hide.Location = new System.Drawing.Point(0, 10);
            this.Button_hide.Name = "Button_hide";
            this.Button_hide.Size = new System.Drawing.Size(42, 24);
            this.Button_hide.TabIndex = 0;
            this.Button_hide.TabStop = false;
            this.Button_hide.UseVisualStyleBackColor = true;
            this.Button_hide.Click += new System.EventHandler(this.Button_hide_Click);
            // 
            // ButtonMin
            // 
            this.ButtonMin.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ButtonMin.BackgroundImage = global::Tcp_Server.Properties.Resources.Free_Flat_Hyphen_Icon;
            this.ButtonMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonMin.FlatAppearance.BorderSize = 0;
            this.ButtonMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonMin.Location = new System.Drawing.Point(736, 10);
            this.ButtonMin.Name = "ButtonMin";
            this.ButtonMin.Size = new System.Drawing.Size(22, 22);
            this.ButtonMin.TabIndex = 0;
            this.ButtonMin.TabStop = false;
            this.ButtonMin.UseVisualStyleBackColor = true;
            this.ButtonMin.Click += new System.EventHandler(this.ButtonMin_Click);
            // 
            // ButtonClose
            // 
            this.ButtonClose.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ButtonClose.BackgroundImage = global::Tcp_Server.Properties.Resources.Free_Flat_Button_Blank_Cross_Icon;
            this.ButtonClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonClose.FlatAppearance.BorderSize = 0;
            this.ButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonClose.Location = new System.Drawing.Point(767, 10);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(22, 22);
            this.ButtonClose.TabIndex = 0;
            this.ButtonClose.TabStop = false;
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
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
            this.PanelSlide_W.ResumeLayout(false);
            this.PanelSlide_W.PerformLayout();
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
        private System.Windows.Forms.TextBox TextBox_IPadress;
        private System.Windows.Forms.TextBox TextBox_IPport;
        private System.Windows.Forms.RichTextBox ConnectTextBox;
        private System.Windows.Forms.Label Label_port;
        private System.Windows.Forms.Label Label_ip;
        private System.Windows.Forms.Button Button_SendText;
        private System.Windows.Forms.TextBox TextBox_SendText;
    }
}

