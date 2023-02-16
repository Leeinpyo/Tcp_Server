using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tcp_Client
{
    public partial class Form1 : Form
    {
        readonly int panelWidth;         // Hidden 메뉴 패널 폭 제어
        readonly int panalHeight;        // Hidden 메뉴 패널 높이 제어
        bool Hidden;            // Hidden 메뉴 상태
        bool Connection_status; // 연결 상태

        readonly Bitmap[] image = new Bitmap[7]; // 이미지 리소스 저장슬롯
        int pic_i;              // 움직이는 이미지 제어

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
                Connection_status = false;
                PictureBox_connect.Image = image[6];
                Label_connect.Text = "TCP Server OFFLINE";
                ButtonConnect.Text = "Connect";
                Timer_ONLINE.Stop();
                this.Refresh();
            }
            else
            {
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

        private void




    }
}