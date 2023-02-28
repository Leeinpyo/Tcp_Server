
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
            this.Label_ClientState = new System.Windows.Forms.Label();
            this.Label_ip = new System.Windows.Forms.Label();
            this.ConnectTextBox = new System.Windows.Forms.RichTextBox();
            this.TextBox_IPport = new System.Windows.Forms.TextBox();
            this.TextBox_IPadress = new System.Windows.Forms.TextBox();
            this.Label_port = new System.Windows.Forms.Label();
            this.PanelMain = new System.Windows.Forms.Panel();
            this.PictureBox_Client = new System.Windows.Forms.Panel();
            this.ButtonConnect = new System.Windows.Forms.Button();
            this.Label_connect = new System.Windows.Forms.Label();
            this.Timer_W = new System.Windows.Forms.Timer(this.components);
            this.Timer_H = new System.Windows.Forms.Timer(this.components);
            this.Timer_ONLINE = new System.Windows.Forms.Timer(this.components);
            this.Timer_Start = new System.Windows.Forms.Timer(this.components);
            this.PictureBox_Server = new System.Windows.Forms.PictureBox();
            this.PictureBox_Client3 = new System.Windows.Forms.PictureBox();
            this.PictureBox_Client2 = new System.Windows.Forms.PictureBox();
            this.PictureBox_Client1 = new System.Windows.Forms.PictureBox();
            this.Slot1 = new System.Windows.Forms.PictureBox();
            this.Slot2 = new System.Windows.Forms.PictureBox();
            this.Slot3 = new System.Windows.Forms.PictureBox();
            this.PictureBox_connect = new System.Windows.Forms.PictureBox();
            this.ServerSlot = new System.Windows.Forms.PictureBox();
            this.PictureBox_ClientState = new System.Windows.Forms.PictureBox();
            this.Button_SendText = new System.Windows.Forms.Button();
            this.Button_hide = new System.Windows.Forms.Button();
            this.ButtonMin = new System.Windows.Forms.Button();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.PanelUpper.SuspendLayout();
            this.PanelSide.SuspendLayout();
            this.PanelSlide_W.SuspendLayout();
            this.PanelMain.SuspendLayout();
            this.PictureBox_Client.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Server)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Client3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Client2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Client1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Slot1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Slot2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Slot3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_connect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServerSlot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_ClientState)).BeginInit();
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
            this.PanelUpper.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelUpper_MouseDown);
            this.PanelUpper.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelUpper_MouseMove);
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
            this.Label_upper.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Label_upper_MouseDown);
            this.Label_upper.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Label_upper_MouseMove);
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
            this.PanelSlide_W.Controls.Add(this.PictureBox_ClientState);
            this.PanelSlide_W.Controls.Add(this.Button_SendText);
            this.PanelSlide_W.Controls.Add(this.TextBox_SendText);
            this.PanelSlide_W.Controls.Add(this.Label_ClientState);
            this.PanelSlide_W.Controls.Add(this.Label_ip);
            this.PanelSlide_W.Controls.Add(this.ConnectTextBox);
            this.PanelSlide_W.Controls.Add(this.TextBox_IPport);
            this.PanelSlide_W.Controls.Add(this.TextBox_IPadress);
            this.PanelSlide_W.Controls.Add(this.Label_port);
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
            this.TextBox_SendText.TabIndex = 1;
            this.TextBox_SendText.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.TextBox_SendText_PreviewKeyDown);
            // 
            // Label_ClientState
            // 
            this.Label_ClientState.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_ClientState.AutoSize = true;
            this.Label_ClientState.Font = new System.Drawing.Font("D2Coding ligature", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Label_ClientState.ForeColor = System.Drawing.Color.Black;
            this.Label_ClientState.Location = new System.Drawing.Point(57, 334);
            this.Label_ClientState.Name = "Label_ClientState";
            this.Label_ClientState.Size = new System.Drawing.Size(92, 18);
            this.Label_ClientState.TabIndex = 2;
            this.Label_ClientState.Text = "Disconnected";
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
            this.ConnectTextBox.Enter += new System.EventHandler(this.ConnectTextBox_Enter);
            // 
            // TextBox_IPport
            // 
            this.TextBox_IPport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox_IPport.Font = new System.Drawing.Font("D2Coding ligature", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TextBox_IPport.Location = new System.Drawing.Point(272, 15);
            this.TextBox_IPport.Name = "TextBox_IPport";
            this.TextBox_IPport.Size = new System.Drawing.Size(35, 23);
            this.TextBox_IPport.TabIndex = 0;
            this.TextBox_IPport.TabStop = false;
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
            // Label_port
            // 
            this.Label_port.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_port.AutoSize = true;
            this.Label_port.Font = new System.Drawing.Font("D2Coding ligature", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Label_port.ForeColor = System.Drawing.Color.Black;
            this.Label_port.Location = new System.Drawing.Point(234, 17);
            this.Label_port.Name = "Label_port";
            this.Label_port.Size = new System.Drawing.Size(40, 18);
            this.Label_port.TabIndex = 3;
            this.Label_port.Text = "Port";
            this.Label_port.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // PanelMain
            // 
            this.PanelMain.Controls.Add(this.PictureBox_Server);
            this.PanelMain.Controls.Add(this.PictureBox_Client);
            this.PanelMain.Controls.Add(this.ButtonConnect);
            this.PanelMain.Controls.Add(this.PictureBox_connect);
            this.PanelMain.Controls.Add(this.Label_connect);
            this.PanelMain.Controls.Add(this.ServerSlot);
            this.PanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelMain.Location = new System.Drawing.Point(358, 44);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.Size = new System.Drawing.Size(442, 406);
            this.PanelMain.TabIndex = 4;
            // 
            // PictureBox_Client
            // 
            this.PictureBox_Client.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.PictureBox_Client.Controls.Add(this.PictureBox_Client3);
            this.PictureBox_Client.Controls.Add(this.PictureBox_Client2);
            this.PictureBox_Client.Controls.Add(this.PictureBox_Client1);
            this.PictureBox_Client.Controls.Add(this.Slot1);
            this.PictureBox_Client.Controls.Add(this.Slot2);
            this.PictureBox_Client.Controls.Add(this.Slot3);
            this.PictureBox_Client.Location = new System.Drawing.Point(320, 197);
            this.PictureBox_Client.Name = "PictureBox_Client";
            this.PictureBox_Client.Size = new System.Drawing.Size(60, 180);
            this.PictureBox_Client.TabIndex = 2;
            // 
            // ButtonConnect
            // 
            this.ButtonConnect.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ButtonConnect.Font = new System.Drawing.Font("D2Coding ligature", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ButtonConnect.ForeColor = System.Drawing.Color.Black;
            this.ButtonConnect.Location = new System.Drawing.Point(175, 165);
            this.ButtonConnect.Name = "ButtonConnect";
            this.ButtonConnect.Size = new System.Drawing.Size(106, 23);
            this.ButtonConnect.TabIndex = 0;
            this.ButtonConnect.Text = "AutoStart";
            this.ButtonConnect.UseVisualStyleBackColor = true;
            this.ButtonConnect.Click += new System.EventHandler(this.ButtonConnect_Click);
            // 
            // Label_connect
            // 
            this.Label_connect.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Label_connect.AutoSize = true;
            this.Label_connect.Font = new System.Drawing.Font("D2Coding ligature", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Label_connect.Location = new System.Drawing.Point(114, 134);
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
            // Timer_Start
            // 
            this.Timer_Start.Interval = 1000;
            this.Timer_Start.Tick += new System.EventHandler(this.Timer_Start_Tick);
            // 
            // PictureBox_Server
            // 
            this.PictureBox_Server.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.PictureBox_Server.Image = global::Tcp_Server.Properties.Resources.Free_Flat_Cloud_1_Icon;
            this.PictureBox_Server.Location = new System.Drawing.Point(80, 197);
            this.PictureBox_Server.Name = "PictureBox_Server";
            this.PictureBox_Server.Size = new System.Drawing.Size(60, 180);
            this.PictureBox_Server.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox_Server.TabIndex = 1;
            this.PictureBox_Server.TabStop = false;
            this.PictureBox_Server.Visible = false;
            // 
            // PictureBox_Client3
            // 
            this.PictureBox_Client3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.PictureBox_Client3.BackColor = System.Drawing.Color.Transparent;
            this.PictureBox_Client3.Image = global::Tcp_Server.Properties.Resources.Free_Flat_Cloud_2_Icon;
            this.PictureBox_Client3.Location = new System.Drawing.Point(0, 120);
            this.PictureBox_Client3.Name = "PictureBox_Client3";
            this.PictureBox_Client3.Size = new System.Drawing.Size(60, 60);
            this.PictureBox_Client3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox_Client3.TabIndex = 3;
            this.PictureBox_Client3.TabStop = false;
            this.PictureBox_Client3.Visible = false;
            // 
            // PictureBox_Client2
            // 
            this.PictureBox_Client2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.PictureBox_Client2.BackColor = System.Drawing.Color.Transparent;
            this.PictureBox_Client2.Image = global::Tcp_Server.Properties.Resources.Free_Flat_Cloud_2_Icon;
            this.PictureBox_Client2.Location = new System.Drawing.Point(0, 60);
            this.PictureBox_Client2.Name = "PictureBox_Client2";
            this.PictureBox_Client2.Size = new System.Drawing.Size(60, 60);
            this.PictureBox_Client2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox_Client2.TabIndex = 2;
            this.PictureBox_Client2.TabStop = false;
            this.PictureBox_Client2.Visible = false;
            // 
            // PictureBox_Client1
            // 
            this.PictureBox_Client1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.PictureBox_Client1.BackColor = System.Drawing.Color.Transparent;
            this.PictureBox_Client1.Image = global::Tcp_Server.Properties.Resources.Free_Flat_Cloud_2_Icon;
            this.PictureBox_Client1.Location = new System.Drawing.Point(0, 0);
            this.PictureBox_Client1.Name = "PictureBox_Client1";
            this.PictureBox_Client1.Size = new System.Drawing.Size(60, 60);
            this.PictureBox_Client1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox_Client1.TabIndex = 1;
            this.PictureBox_Client1.TabStop = false;
            this.PictureBox_Client1.Visible = false;
            // 
            // Slot1
            // 
            this.Slot1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Slot1.BackColor = System.Drawing.Color.Transparent;
            this.Slot1.Image = global::Tcp_Server.Properties.Resources.Free_Flat_Cloud_2_Icon_Disable;
            this.Slot1.Location = new System.Drawing.Point(0, 0);
            this.Slot1.Name = "Slot1";
            this.Slot1.Size = new System.Drawing.Size(60, 60);
            this.Slot1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Slot1.TabIndex = 4;
            this.Slot1.TabStop = false;
            // 
            // Slot2
            // 
            this.Slot2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Slot2.BackColor = System.Drawing.Color.Transparent;
            this.Slot2.Image = global::Tcp_Server.Properties.Resources.Free_Flat_Cloud_2_Icon_Disable;
            this.Slot2.Location = new System.Drawing.Point(0, 60);
            this.Slot2.Name = "Slot2";
            this.Slot2.Size = new System.Drawing.Size(60, 60);
            this.Slot2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Slot2.TabIndex = 5;
            this.Slot2.TabStop = false;
            // 
            // Slot3
            // 
            this.Slot3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Slot3.BackColor = System.Drawing.Color.Transparent;
            this.Slot3.Image = global::Tcp_Server.Properties.Resources.Free_Flat_Cloud_2_Icon_Disable;
            this.Slot3.Location = new System.Drawing.Point(0, 120);
            this.Slot3.Name = "Slot3";
            this.Slot3.Size = new System.Drawing.Size(60, 60);
            this.Slot3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Slot3.TabIndex = 6;
            this.Slot3.TabStop = false;
            // 
            // PictureBox_connect
            // 
            this.PictureBox_connect.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.PictureBox_connect.Image = global::Tcp_Server.Properties.Resources.Free_Flat_Signal_Up_Off_Icon;
            this.PictureBox_connect.Location = new System.Drawing.Point(175, 16);
            this.PictureBox_connect.Name = "PictureBox_connect";
            this.PictureBox_connect.Size = new System.Drawing.Size(106, 105);
            this.PictureBox_connect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox_connect.TabIndex = 0;
            this.PictureBox_connect.TabStop = false;
            // 
            // ServerSlot
            // 
            this.ServerSlot.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ServerSlot.Image = global::Tcp_Server.Properties.Resources.Free_Flat_Cloud_1_Icon_Disable;
            this.ServerSlot.Location = new System.Drawing.Point(80, 197);
            this.ServerSlot.Name = "ServerSlot";
            this.ServerSlot.Size = new System.Drawing.Size(60, 180);
            this.ServerSlot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ServerSlot.TabIndex = 3;
            this.ServerSlot.TabStop = false;
            // 
            // PictureBox_ClientState
            // 
            this.PictureBox_ClientState.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureBox_ClientState.BackColor = System.Drawing.Color.DarkRed;
            this.PictureBox_ClientState.Image = global::Tcp_Server.Properties.Resources.Free_Flat_Connection_0_Icon;
            this.PictureBox_ClientState.Location = new System.Drawing.Point(10, 337);
            this.PictureBox_ClientState.Name = "PictureBox_ClientState";
            this.PictureBox_ClientState.Size = new System.Drawing.Size(45, 45);
            this.PictureBox_ClientState.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox_ClientState.TabIndex = 5;
            this.PictureBox_ClientState.TabStop = false;
            // 
            // Button_SendText
            // 
            this.Button_SendText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_SendText.BackgroundImage = global::Tcp_Server.Properties.Resources.Free_Flat_Chat_2_Bars_Icon;
            this.Button_SendText.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Button_SendText.FlatAppearance.BorderSize = 0;
            this.Button_SendText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_SendText.Font = new System.Drawing.Font("D2Coding ligature", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Button_SendText.Location = new System.Drawing.Point(277, 309);
            this.Button_SendText.Name = "Button_SendText";
            this.Button_SendText.RightToLeft = System.Windows.Forms.RightToLeft.No;
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
            this.Button_hide.Location = new System.Drawing.Point(1, 1);
            this.Button_hide.Name = "Button_hide";
            this.Button_hide.Size = new System.Drawing.Size(40, 40);
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
            this.PictureBox_Client.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Server)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Client3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Client2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Client1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Slot1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Slot2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Slot3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_connect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServerSlot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_ClientState)).EndInit();
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
        private System.Windows.Forms.PictureBox PictureBox_ClientState;
        private System.Windows.Forms.Label Label_ClientState;
        private System.Windows.Forms.Timer Timer_Start;
        private System.Windows.Forms.PictureBox PictureBox_Server;
        private System.Windows.Forms.Panel PictureBox_Client;
        private System.Windows.Forms.PictureBox PictureBox_Client2;
        private System.Windows.Forms.PictureBox PictureBox_Client1;
        private System.Windows.Forms.PictureBox PictureBox_Client3;
        private System.Windows.Forms.PictureBox Slot1;
        private System.Windows.Forms.PictureBox Slot2;
        private System.Windows.Forms.PictureBox Slot3;
        private System.Windows.Forms.PictureBox ServerSlot;
    }
}

