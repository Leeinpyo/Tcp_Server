using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tcp_Client
{
    public partial class Form1 : Form
    {

        readonly Bitmap[] image = new Bitmap[7];    // 이미지 리소스 저장슬롯
        int pic_i;                                  // 움직이는 이미지 제어

        bool connecting;                            // 연결상태


        public Form1()
        {
            InitializeComponent();

            connecting = false;
            pic_i = 0; //움직이는 이미지 제어용

            image[0] = Properties.Resources.Client01_closed;
            image[1] = Properties.Resources.Client02_Linked_01;
            image[2] = Properties.Resources.Client02_Linked_02;
            image[3] = Properties.Resources.Client02_Linked_03;
            image[4] = Properties.Resources.Client02_Linked_04;
            image[5] = Properties.Resources.Client02_Linked_05;
            image[6] = Properties.Resources.Client02_Linked_06;   //사용할 이미지 리소스 미리 불러놓기


            PictureBox_Connect.Image = image[pic_i];

        }

        private void Timer_ConnectICO_Tick(object sender, EventArgs e)
        {
            if (pic_i >= 6 || pic_i == 0)
            {
                pic_i = 1;
            }
            else if (pic_i >= 1)
            {
                pic_i++;
            }
            PictureBox_Connect.Image = image[pic_i];
        }

        private void Button_Connect_Click(object sender, EventArgs e)
        {
            if (connecting==true)
            {
                Timer_ConnectICO.Stop();
                pic_i = 0;
                PictureBox_Connect.Image = image[pic_i];
                connecting = false;
            }
            else
            {
                Timer_ConnectICO.Start();
                connecting = true;
            }
        }
    }
}
