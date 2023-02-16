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
        bool Connection_status;                     // 연결 상태

        Thread threadServer;                        // 쓰레드 : threadServer
        bool threadST = true;                      // 쓰레드 상태
        bool connecting;


        private TcpListener tcpListener;            //리스너 대기

        readonly Bitmap[] image = new Bitmap[7];    // 이미지 리소스 저장슬롯
        int pic_i;                                  // 움직이는 이미지 제어


        public Form1()
        {
            InitializeComponent();

            panelWidth = PanelSlide_W.Width;    //Hidden 메뉴 패널 폭 기본값 저장
            panalHeight = PanelSlide_H.Height;  //Hidden 메뉴 패널 높이 기본값 저장

            PanelSlide_W.Width = 0;
            PanelSlide_H.Height = 0;
            Hidden = true;              //메뉴 숨겨진 상태로 시작

            Connection_status = false;  //연결 끊어진 상태로 시작

            pic_i = 0; //움직이는 이미지 제어용

            TextBox_IPadress.Text = GetLocalIP();// 폼 로드시 내 PC의 IP 주소 자동입력

            image[0] = Properties.Resources.Free_Flat_Signal_Up_0_Icon;
            image[1] = Properties.Resources.Free_Flat_Signal_Up_1_Icon;
            image[2] = Properties.Resources.Free_Flat_Signal_Up_2_Icon;
            image[3] = Properties.Resources.Free_Flat_Signal_Up_3_Icon;
            image[4] = Properties.Resources.Free_Flat_Signal_Up_011_Icon;
            image[5] = Properties.Resources.Free_Flat_Signal_Up_101_Icon;
            image[6] = Properties.Resources.Free_Flat_Signal_Up_Off_Icon;     //사용할 이미지 리소스 미리 불러놓기

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
            if (Connection_status == true)
            {
                threadST = false;
                tcpListener.Stop();

                while (threadServer.IsAlive) { Thread.Sleep(100); }
                //if (threadServer.IsAlive)
                //    threadServer.Abort();// threadServer 강제 종료.


                Connection_status = false;
                PictureBox_connect.Image = image[6];
                Label_connect.Text = "TCP Server OFFLINE";
                ButtonConnect.Text = "Connect";
                Timer_ONLINE.Stop();
                this.Refresh();
            }
            else
            {
                if (!IPAddress.TryParse(TextBox_IPadress.Text, out _))
                {
                    MessageBox.Show("올바르지 않은 IP주소를 입력하였습니다. IP 주소 형식에 맞는 값을 입력하여 주십시오.", "오류");
                    return;
                }

                if (!int.TryParse(TextBox_IPport.Text, out _))
                {
                    MessageBox.Show("올바르지 않은 포트 번호를 입력하였습니다. 포트 번호는 숫자만 입력하여 주십시오.", "오류");
                    return;
                }
                
                threadServer = new Thread(connect);// Form과는 별도 쓰레드에서 connect 함수가 실행됨.
                threadServer.IsBackground = true; // Form이 종료되면 threadServer 쓰레드도 종료.
                threadServer.Start(); // threadServer 시작.

                Connection_status = true;
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


        private void connect()  // thread1에 연결된 함수. 메인폼과는 별도로 동작한다.
        {
            try
            {
                tcpListener = new TcpListener(IPAddress.Parse(TextBox_IPadress.Text), int.Parse(TextBox_IPport.Text)); // 서버 객체 생성 및 IP주소와 Port번호를 할당
                tcpListener.Start();  // 서버 시작

                byte[] buff = new byte[1024];

                while (threadST)
                {
                    TcpClient client = tcpListener.AcceptTcpClient(); //클라이언트 연결 대기

                    NetworkStream stream = client.GetStream(); // 클라이언트에서 네트워크 스트림 받기

                    int nbytes;
                    connecting = true;

                    while (connecting)
                    {
                        stream.Read(buff, 0, buff.Length);
                        while ((nbytes=stream.Read(buff,0,buff.Length))>0)              //데이터 수신
                        {
                            string output = Encoding.ASCII.GetString(buff, 0, nbytes);  //받은거 string으로 디코딩
                            ConnectTextBox.Text += output + "\r\n";                     //ConnectTextBox에 출력, 개행
                            ConnectTextBox.ScrollToCaret();                             //최근 입력한 캐럿으로 스크롤 내리기
                        }
                    }

                    stream.Close();
                    client.Close();
                }

            }

            catch (IOException)
            {
                
            }
            catch (FormatException)
            {
                
            }
            catch (SocketException)
            {
                
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
    }
}