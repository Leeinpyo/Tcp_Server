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

            myTable1.Add("John" , new List<string> { "555-555-5555" });
            myTable1.Add("Mary" , new List<string> { "555-555-5556" });
            myTable1.Add("Bob"  , new List<string> { "555-555-5557" });
            myTable1.Add("Sueji", new List<string> { "555-555-5558" });
            myTable1.Add("Joe"  , new List<string> { "555-555-5559" });
            myTable1.Add("Tom"  , new List<string> { "555-555-5560" });
            myTable1.Add("Tim"  , new List<string> { "555-555-5561" });
            myTable1.Add("Sasha", new List<string> { "555-555-5562" });
            myTable1.Add("Choi" , new List<string> { "555-555-5563" });

            ShowTable( listViewDictionary , myTable1 );

        }

        public void ShowTable( System.Windows.Forms.ListView lv , Dictionary<string, List<string>> a )                                         // 리스트뷰에 값 넣기
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
        
        public void CopyTable( Dictionary<string, List<string>> a )                                                       // 복사
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

        private void listViewCopy_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.NewWidth = listViewCopy.Columns[e.ColumnIndex].Width;
            e.Cancel = true;
        }

        private void listViewDictionary_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.NewWidth = listViewDictionary.Columns[e.ColumnIndex].Width;
            e.Cancel = true;
        }

    }
}
