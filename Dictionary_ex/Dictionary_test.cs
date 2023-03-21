using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

using Svg;

//Dictionary 와 ListView를 학습하기 위해 전화번호부를 만들어 본 예제 프로젝트입니다.

//Dictionary는 Key와 Value로 구성되어 있습니다.

//Key는 중복될 수 없습니다.
//Value는 중복될 수 있습니다.
//그러나 편법을 사용하면 Key를 중복하여 사용 가능했었습니다.
//그것은 바로 <string, List<string>> 이렇게 사용하는 것입니다.

//Dictionary는 Key를 이용하여 Value를 찾을 수 있습니다.
//Dictionary는 Key를 이용하여 Value를 추가, 삭제, 수정할 수 있습니다.

//ListView에는 Dictionary를 사용하여 값을 넣을 수 있습니다.
//Dictionary를 사용하여 값을 넣을 때 Key와 Value를 구분하여 넣어야 합니다.
//중복된 key가 들어갈떄의 예외처리를 빼먹지 않도록 합니다.

//ListView를 제어할떄는 BeginUpdate() 와 EndUpdate() 를 사용하면 항목이 추가될 때마다 컨트롤을 출력하지 않으므로 성능을 향상시킬 수 있습니다.



//실습 진행간에 ColumnWidthChangingEvent가 호출되지 않는 문제가 있었습니다.
//이 문제는 결국 해결이 불가했습니다.

// +    ColumnWidthChangingEvent가 호출되지 않는 문제는 해결되었습니다.
//      ColumnWidthChangingEvent가 호출되지 않는 문제는 윈도우의 성능 옵션이 꺼져 있을때 발생하는 문제였습니다.
//      성능 옵션을 켜고 다시 실행하니 문제가 해결되었습니다.
// ++   이와 같은 문제는 Program.cs에서 Application.EnableVisualStyles();을 주석 처리하였을때도 발생합니다.



namespace Dictionary_ex
{
    public partial class Dictionary_test : Form
    {
        private readonly Dictionary<string, List<string>> myTable1 = new Dictionary<string, List<string>>();

        Dictionary<string, List<string>> myTable2;

        public Dictionary_test()
        {
            InitializeComponent();

            myTable1.Add("Hong Jin Ho"  , new List<string> { "222-222-2222" , "222-222-2222" });                    // 예제값
            myTable1.Add("Yeon"         , new List<string> { "123-456-7890" });
            myTable1.Add("Sheogorath"   , new List<string> { "555-555-5555" });
            myTable1.Add("Kim Doe"      , new List<string> { "010101010101" });
            myTable1.Add("Amy Rose"     , new List<string> { "111-111-1111" });
            myTable1.Add("Nico Belic"   , new List<string> { "321-123-4444" });
            myTable1.Add("Tom Riddle"   , new List<string> { "000000000000" });
            myTable1.Add("Ching Chong"  , new List<string> { "666-666-6666" });
            myTable1.Add("V"            , new List<string> { "000-000-0000" });
            myTable1.Add("Foxy"         , new List<string> { "666-666-5882" });
            myTable1.Add("James Raynor" , new List<string> { "555-555-9999" });
            myTable1.Add("Sasha"        , new List<string> { "777-777-7777" });
            myTable1.Add("Uriel Septim" , new List<string> { "555-222-1111" });

            ShowTable( listViewDictionary , myTable1 );

        }

        public void ShowTable( System.Windows.Forms.ListView lv , Dictionary<string, List<string>> a )              // 리스트뷰에 값 넣기
        {
            lv.BeginUpdate();

            lv.Items.Clear();
            foreach (KeyValuePair<string, List<string>> kvp in a)
            { 
                foreach (string s in kvp.Value)
                {
                    ListViewItem item = new ListViewItem(kvp.Key);
                    lv.Items.Add(item);
                    item.SubItems.Add(s);
                }
            }

            lv.EndUpdate();
        }
        
        public void CopyTable( Dictionary<string, List<string>> a )                                                 // 복사
        {
            myTable2 = new Dictionary<string, List<string>>( a );
        }

        private void btnCopy_Click(object sender, EventArgs e)                                                      // btnCopy 클릭
        {
            CopyTable(myTable1);
            ShowTable(listViewCopy, myTable2);
        }

        private void btnAdd_Click(object sender, EventArgs e)                                                       // btnAdd 클릭
        {
            string name = AddName.Text;
            string phone = AddTel.Text;

            if (myTable1.ContainsKey(name))
            {
                myTable1[name].Add(phone);
            }
            else
            {
                myTable1.Add(name, new List<string> { phone });
            }

            AddName.Clear();
            AddTel.Clear();

            ShowTable(listViewDictionary, myTable1);
        }

        private void listViewCopy_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)                // 호출안됨 이유불명
        {
            e.NewWidth = listViewCopy.Columns[e.ColumnIndex].Width;
            e.Cancel = true;
        }

        private void listViewDictionary_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)          // 호출안됨 이유불명
        {
            e.NewWidth = listViewDictionary.Columns[e.ColumnIndex].Width;
            e.Cancel = true;
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)                                      // 우클릭으로 제거하기 (중복인거 한꺼번에 안닐리게)
        {
            foreach (ListViewItem item in listViewDictionary.SelectedItems)
            {  
                foreach (KeyValuePair<string, List<string>> kvp in myTable1)
                {
                    foreach (string s in kvp.Value)
                    {
                        if (item.SubItems[0].Text == kvp.Key && item.SubItems[1].Text == s)
                        {
                            myTable1[kvp.Key].Remove(s);
                            break;
                        }
                    }
                }
            }
            ShowTable(listViewDictionary, myTable1);
        }
    }
}
