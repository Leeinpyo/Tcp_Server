
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
            this.PictureBox_Connect = new System.Windows.Forms.PictureBox();
            this.Timer_ConnectICO = new System.Windows.Forms.Timer(this.components);
            this.Button_Connect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Connect)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBox_Connect
            // 
            this.PictureBox_Connect.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PictureBox_Connect.Location = new System.Drawing.Point(92, 12);
            this.PictureBox_Connect.Name = "PictureBox_Connect";
            this.PictureBox_Connect.Size = new System.Drawing.Size(155, 155);
            this.PictureBox_Connect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox_Connect.TabIndex = 0;
            this.PictureBox_Connect.TabStop = false;
            // 
            // Timer_ConnectICO
            // 
            this.Timer_ConnectICO.Interval = 200;
            this.Timer_ConnectICO.Tick += new System.EventHandler(this.Timer_ConnectICO_Tick);
            // 
            // Button_Connect
            // 
            this.Button_Connect.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Button_Connect.Location = new System.Drawing.Point(132, 173);
            this.Button_Connect.Name = "Button_Connect";
            this.Button_Connect.Size = new System.Drawing.Size(75, 23);
            this.Button_Connect.TabIndex = 1;
            this.Button_Connect.Text = "Connect";
            this.Button_Connect.UseVisualStyleBackColor = true;
            this.Button_Connect.Click += new System.EventHandler(this.Button_Connect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(324, 466);
            this.Controls.Add(this.Button_Connect);
            this.Controls.Add(this.PictureBox_Connect);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Connect)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBox_Connect;
        private System.Windows.Forms.Timer Timer_ConnectICO;
        private System.Windows.Forms.Button Button_Connect;
    }
}

