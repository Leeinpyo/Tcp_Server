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


        public Form1()
        {
            InitializeComponent();

            pic_i = 0; //움직이는 이미지 제어용

            image[0] = Properties.Resources.Client01_closed;
            image[1] = Properties.Resources.Client02_Linked_01;
            image[2] = Properties.Resources.Client02_Linked_02;
            image[3] = Properties.Resources.Client02_Linked_03;
            image[4] = Properties.Resources.Client02_Linked_04;
            image[5] = Properties.Resources.Client02_Linked_05;
            image[6] = Properties.Resources.Client02_Linked_06;   //사용할 이미지 리소스 미리 불러놓기


            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            PictureBox_Connect.Image = image[pic_i];

            if (pic_i >= 6 || pic_i == 0)
            {
                pic_i = 1;
            }
            else if (pic_i >= 1)
            {
                pic_i++;
            }
        }
    }
}
