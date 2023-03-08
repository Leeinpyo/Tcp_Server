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

namespace Dictionary_ex
{
    public partial class Dictionary_test : Form
    {
        private readonly Dictionary<string, List<string>> myTable1 = new Dictionary<string, List<string>>();

        Dictionary<string, List<string>> myTable2;

        public Dictionary_test()
        {
            InitializeComponent();

            myTable1.Add("Hong Jin Ho"  , new List<string> { "222-222-2222" , "222-222-2222" });                          // 예제값
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

    }
}
