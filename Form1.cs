using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading; // 추가
using System.Net; // 추가
using System.Net.Sockets; // 추가
using System.IO; // 추가

namespace Tcp_Server
{
    public partial class Form1 : Form
    {
        readonly int panelWidth;                    // Hidden 메뉴 패널 폭 제어
        readonly int panalHeight;                   // Hidden 메뉴 패널 높이 제어
        bool Hidden;                                // Hidden 메뉴 상태
        bool Server_status;                         // 서버 상태
        bool connecting;                            // 클라이언트 연결상태

        Thread threadServer;                        // 쓰레드 : threadServer
        bool threadST = true;                       // 쓰레드 상태

        NetworkStream Stream;                       // 네트워크스트림
        TcpClient Client;


        private TcpListener tcpListener;            // 리스너 대기

        readonly Bitmap[] image = new Bitmap[9];    // 이미지 리소스 저장슬롯
        int pic_i;                                  // 움직이는 이미지 제어


        public Form1()
        {
            InitializeComponent();

            panelWidth = PanelSlide_W.Width;    // Hidden 메뉴 패널 폭 기본값 저장
            panalHeight = PanelSlide_H.Height;  // Hidden 메뉴 패널 높이 기본값 저장

            PanelSlide_W.Width = 0;
            PanelSlide_H.Height = 0;
            Hidden = true;              //메뉴 숨겨진 상태로 시작

            Server_status = false;  //연결 끊어진 상태로 시작

            pic_i = 0; //움직이는 이미지 제어용

            TextBox_IPadress.Text = GetLocalIP();// 폼 로드시 내 PC의 IP 주소 자동입력

            image[0] = Properties.Resources.Free_Flat_Signal_Up_0_Icon;
            image[1] = Properties.Resources.Free_Flat_Signal_Up_1_Icon;
            image[2] = Properties.Resources.Free_Flat_Signal_Up_2_Icon;
            image[3] = Properties.Resources.Free_Flat_Signal_Up_3_Icon;
            image[4] = Properties.Resources.Free_Flat_Signal_Up_011_Icon;
            image[5] = Properties.Resources.Free_Flat_Signal_Up_101_Icon;
            image[6] = Properties.Resources.Free_Flat_Signal_Up_Off_Icon;
            image[7] = Properties.Resources.Free_Flat_Connection_0_Icon;
            image[8] = Properties.Resources.Free_Flat_Connection_1_Icon;   //사용할 이미지 리소스 미리 불러놓기

        }


        private void Button_hide_Click(object sender, EventArgs e)
        {
            Timer_W.Start();
            Timer_H.Start(); // 버튼 클릭시 타이머 실행 및 동작
        }

        private void Timer_W_Tick(object sender, EventArgs e)
        {
            if (Hidden == true)
            {
                PanelSlide_W.Width = PanelSlide_W.Width + 10;
                if (PanelSlide_W.Width >= panelWidth)   //목표크기에 도달할때까지 반복
                {
                    Timer_W.Stop();
                    Hidden = false;
                    this.Refresh();
                }
            }
            else
            {
                PanelSlide_W.Width = PanelSlide_W.Width - 10;
                if (PanelSlide_W.Width <= 0)            //목표크기에 도달할때까지 반복
                {
                    Timer_W.Stop();
                    Hidden = true;
                    this.Refresh();
                }
            }
        }

        private void Timer_H_Tick(object sender, EventArgs e)
        {
            if (Hidden == true)
            {
                PanelSlide_H.Height = PanelSlide_H.Height + 1;
                if (PanelSlide_H.Height >= panalHeight) //목표크기에 도달할때까지 반복
                {
                    Timer_H.Stop();
                    this.Refresh();
                }
            }
            else
            {
                PanelSlide_H.Height = PanelSlide_H.Height - 1;
                if (PanelSlide_H.Height <= 0)           //목표크기에 도달할때까지 반복
                {
                    Timer_H.Stop();
                    this.Refresh();
                }
            }
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Timer_W.Stop();
            Timer_H.Stop();
            Timer_ONLINE.Stop();

            Application.Exit(); // 종료
        }

        private void ButtonMin_Click(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized; // 최소화
        }

        private void ButtonConnect_Click(object sender, EventArgs e)
        {
            if (Server_status == true)
            {
                threadST = false;
                connecting = false;
                Server_status = false;

                if (Stream != null)
                    Stream.Close();

                if (Client != null)
                    Client.Close();

                if (tcpListener != null)
                    tcpListener.Stop();

                PictureBox_connect.Image = image[6];
                PictureBox_ClientState.Image = image[7];
                Label_connect.Text = "TCP Server OFFLINE";
                ButtonConnect.Text = "Connect";
                Label_ClientState.Text = "Disonnected";
                Timer_ONLINE.Stop();
                this.Refresh();
            }
            else
            {
                if (!IPAddress.TryParse(TextBox_IPadress.Text, out _))
                {
                    MessageBoxEx.Show(this, "올바르지 않은 IP주소를 입력하였습니다. \nIP 주소 형식에 맞는 값을 입력하여 주십시오.","오류");
                    return;
                }

                if (!int.TryParse(TextBox_IPport.Text, out _))
                {
                    MessageBoxEx.Show(this, "올바르지 않은 포트 번호를 입력하였습니다. \n포트 번호는 숫자만 입력하여 주십시오.","오류");
                    return;
                }
                
                threadServer = new Thread(connect);// Form과는 별도 쓰레드에서 connect 함수가 실행됨.
                threadServer.IsBackground = true; // Form이 종료되면 threadServer 쓰레드도 종료.
                threadServer.Start(); // threadServer 시작.

                threadST = true;
                Server_status = true;

                Label_connect.Text = "TCP Server ONLINE";
                ButtonConnect.Text = "Disconnect";
                pic_i = 0;
                Timer_ONLINE.Start();
            }
        }

        private void Timer_ONLINE_Tick(object sender, EventArgs e)
        {
            if (pic_i<2)
            {
                    PictureBox_connect.Image = image[pic_i];
                    pic_i++;
            }
            else if (pic_i >= 2)
            {
                    PictureBox_connect.Image = image[pic_i];
                    pic_i++;

                    if (pic_i >= 6)
                    {
                        pic_i = 2;
                    }
            }
        }


        private void connect()  // thread에 연결된 함수. 메인폼과는 별도로 동작한다.
        {
            tcpListener = new TcpListener(IPAddress.Parse(TextBox_IPadress.Text), int.Parse(TextBox_IPport.Text)); // 서버 객체 생성 및 IP주소와 Port번호를 할당
            tcpListener.Start();  // 서버 시작

            byte[] buff = new byte[1024];

            while (threadST)
            {
                try
                {
                    Client = tcpListener.BeginAcceptTcpClient(); //클라이언트 연결 대기
                    tcpListener.EndAcceptTcpClient();

                    Stream = Client.GetStream(); // 클라이언트에서 네트워크 스트림 받기

                    int nbytes;
                    connecting = true;
                    PictureBox_ClientState.Image = image[8];
                    ChangeText(Label_ClientState, "Connected");

                    while (connecting)
                    {
                        try
                        {
                            nbytes = Stream.Read(buff, 0, buff.Length);                 //들어오는거 기다리다가 받기
                            string output = Encoding.UTF8.GetString(buff, 0, nbytes);   //받은거 디코딩 UTF8형식으로
                            WriteMsg(output);                                           //출력 (크로스쓰레드 회피 포함)
                        }
                        catch { connecting = false; }
                    }
                    //클라랑 연결 끊김
                    Stream.Close();
                    Client.Close();
                    Label_ClientState.Text = "Disonnected";
                    PictureBox_ClientState.Image = image[7];
                    connecting = false;

                }
                catch (IOException)
                {
                    ChangePicture(PictureBox_ClientState, image[7]);
                    ChangeText(Label_ClientState, "Disconnected");
                    connecting = false;

                    MethodInvoker methodInvokerDelegate = delegate ()
                    { MessageBoxEx.Show(this, "클라이언트와의 연결이 끊겼습니다.", "연결"); };

                    if (this.InvokeRequired)
                        this.Invoke(methodInvokerDelegate);
                    else
                        methodInvokerDelegate();

                }
                catch (FormatException)
                {
                    ChangePicture(PictureBox_ClientState, image[7]);
                    ChangeText(Label_ClientState, "Disconnected");
                    connecting = false;

                    MethodInvoker methodInvokerDelegate = delegate ()
                    { MessageBoxEx.Show(this, "FormatException", "오류"); };

                    if (this.InvokeRequired)
                        this.Invoke(methodInvokerDelegate);
                    else
                        methodInvokerDelegate();
                }
                catch (SocketException)
                {
                    ChangePicture(PictureBox_ClientState, image[7]);
                    ChangeText(Label_ClientState, "Disconnected");
                    connecting = false;

                    //MethodInvoker methodInvokerDelegate = delegate ()
                    //{ MessageBoxEx.Show(this, s1.ToString(), "오류"); };

                    //if (this.InvokeRequired)
                    //    this.Invoke(methodInvokerDelegate);
                    //else
                    //    methodInvokerDelegate();
                }
            }




        }


        public static string GetLocalIP() // 내 ip 주소 찾기
        {
            IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());
            string LocalIP = string.Empty;

            for (int i = 0; i < host.AddressList.Length; i++)
            {
                if (host.AddressList[i].AddressFamily == AddressFamily.InterNetwork)
                {
                    LocalIP = host.AddressList[i].ToString();
                    break;
                }
            }
            return LocalIP;
        }

        private void Button_SendText_Click(object sender, EventArgs e)  // Button_SendText 버튼이 눌렸을때 작동
        {
            if (connecting)                                             // 클라이언트 연결시
            {
                string sendMsg = TextBox_SendText.Text;                 // TextBox_SendText 텍스트 박스에 있는 string을
                byte[] buff = Encoding.UTF8.GetBytes(sendMsg);          // 바이트 아스키코드 형식으로 인코딩해주기

                Stream.Write(buff, 0, buff.Length);                     // 그걸 클라로 쏴주기
            }
            else if (!connecting)                                       // 클라.... 없다?
            {
                MessageBoxEx.Show(this, "연결된 클라이언트가 없어 수신이 불가능합니다.", "알림");
            }
        }

        private void ChangeText(Button button, string text)
        {
            if (button.InvokeRequired)
            {
                button.Invoke(new MethodInvoker(delegate ()
                {
                    button.Text = text;
                }));
            }
            else
                button.Text = text;
        }

        private void ChangeText(Label label, string text)
        {
            if (label.InvokeRequired)
            {
                label.Invoke(new MethodInvoker(delegate ()
                {
                    label.Text = text;
                }));
            }
            else
                label.Text = text;
        }

        private void WriteMsg(string msg)
        {
            if (ConnectTextBox.InvokeRequired)
            {
                ConnectTextBox.Invoke(new MethodInvoker(delegate ()
                {
                    ConnectTextBox.AppendText($"{msg}\n");
                    ConnectTextBox.ScrollToCaret();
                }));
            }
            else
            {
                ConnectTextBox.AppendText($"{msg}\n");
                ConnectTextBox.ScrollToCaret();
            }
        }

        private void ChangePicture(PictureBox picBox, Image image)
        {
            if (picBox.InvokeRequired)
            {
                picBox.Invoke(new MethodInvoker(delegate ()
                {
                    picBox.Image = image;
                }));
            }
            else
                picBox.Image = image;
        }
    }
}