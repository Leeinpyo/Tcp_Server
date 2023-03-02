
namespace Tcp_Client
{
    partial class Client
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
            this.Timer_ConnectICO = new System.Windows.Forms.Timer(this.components);
            this.Button_Connect = new System.Windows.Forms.Button();
            this.RichTextBox_Client = new System.Windows.Forms.RichTextBox();
            this.TextBox_SendText = new System.Windows.Forms.TextBox();
            this.PictureBox_Connect = new System.Windows.Forms.PictureBox();
            this.Button_Close = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Connect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_Close)).BeginInit();
            this.SuspendLayout();
            // 
            // Timer_ConnectICO
            // 
            this.Timer_ConnectICO.Interval = 200;
            this.Timer_ConnectICO.Tick += new System.EventHandler(this.Timer_ConnectICO_Tick);
            // 
            // Button_Connect
            // 
            this.Button_Connect.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Button_Connect.BackColor = System.Drawing.Color.White;
            this.Button_Connect.Location = new System.Drawing.Point(237, 174);
            this.Button_Connect.Name = "Button_Connect";
            this.Button_Connect.Size = new System.Drawing.Size(75, 23);
            this.Button_Connect.TabIndex = 1;
            this.Button_Connect.Text = "Connect";
            this.Button_Connect.UseVisualStyleBackColor = false;
            this.Button_Connect.Click += new System.EventHandler(this.Button_Connect_Click);
            // 
            // RichTextBox_Client
            // 
            this.RichTextBox_Client.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RichTextBox_Client.Location = new System.Drawing.Point(12, 203);
            this.RichTextBox_Client.Name = "RichTextBox_Client";
            this.RichTextBox_Client.ReadOnly = true;
            this.RichTextBox_Client.Size = new System.Drawing.Size(300, 225);
            this.RichTextBox_Client.TabIndex = 2;
            this.RichTextBox_Client.Text = "";
            this.RichTextBox_Client.Enter += new System.EventHandler(this.RichTextBox_Client_Enter);
            // 
            // TextBox_SendText
            // 
            this.TextBox_SendText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox_SendText.Location = new System.Drawing.Point(12, 433);
            this.TextBox_SendText.Name = "TextBox_SendText";
            this.TextBox_SendText.Size = new System.Drawing.Size(300, 21);
            this.TextBox_SendText.TabIndex = 3;
            this.TextBox_SendText.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.TextBox_SendText_PreviewKeyDown);
            // 
            // PictureBox_Connect
            // 
            this.PictureBox_Connect.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PictureBox_Connect.Location = new System.Drawing.Point(85, 12);
            this.PictureBox_Connect.Name = "PictureBox_Connect";
            this.PictureBox_Connect.Size = new System.Drawing.Size(155, 155);
            this.PictureBox_Connect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox_Connect.TabIndex = 0;
            this.PictureBox_Connect.TabStop = false;
            this.PictureBox_Connect.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox_Connect_MouseDown);
            this.PictureBox_Connect.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBox_Connect_MouseMove);
            // 
            // Button_Close
            // 
            this.Button_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Close.Image = global::Tcp_Client.Properties.Resources.Free_Flat_Button_Solid_Cross_Icon;
            this.Button_Close.Location = new System.Drawing.Point(290, 12);
            this.Button_Close.Name = "Button_Close";
            this.Button_Close.Size = new System.Drawing.Size(22, 22);
            this.Button_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Button_Close.TabIndex = 4;
            this.Button_Close.TabStop = false;
            this.Button_Close.Click += new System.EventHandler(this.Button_Close_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(324, 466);
            this.Controls.Add(this.Button_Close);
            this.Controls.Add(this.TextBox_SendText);
            this.Controls.Add(this.RichTextBox_Client);
            this.Controls.Add(this.Button_Connect);
            this.Controls.Add(this.PictureBox_Connect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Connect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_Close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBox_Connect;
        private System.Windows.Forms.Timer Timer_ConnectICO;
        private System.Windows.Forms.Button Button_Connect;
        private System.Windows.Forms.RichTextBox RichTextBox_Client;
        private System.Windows.Forms.TextBox TextBox_SendText;
        private System.Windows.Forms.PictureBox Button_Close;
    }
}

