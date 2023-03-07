using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictionary_ex
{
    public partial class Dictionary_test : Form
    {
        private readonly Dictionary<string, string> myTable1 = new Dictionary<string, string>();

        Dictionary<string, string> myTable2;

        public Dictionary_test()
        {
            InitializeComponent();

            myTable1.Add("John" , "555-555-5555");
            myTable1.Add("Mary" , "555-555-5556");
            myTable1.Add("Bob"  , "555-555-5557");
            myTable1.Add("Sueji", "555-555-5558");
            myTable1.Add("Joe"  , "555-555-5559");
            myTable1.Add("Tom"  , "555-555-5560");
            myTable1.Add("Tim"  , "555-555-5561");
            myTable1.Add("Sasha", "555-555-5562");
            myTable1.Add("Choi" , "555-555-5563");

            ShowTable( listViewDictionary , myTable1 );

        }

        public void ShowTable( ListView lv , Dictionary<string, string> a )                                         // 리스트뷰에 값 넣기
        {
            lv.Items.Clear();
            foreach (KeyValuePair<string, string> kvp in a)
            {
                ListViewItem lvi = new ListViewItem(kvp.Key);
                lvi.SubItems.Add(kvp.Value);
                lv.Items.Add(lvi);
            }
        }
        
        public void CopyTable( Dictionary<string, string> a )                                                       // 복사
        {
            myTable2 = new Dictionary<string, string>( a );
        }

        private void btnCopy_Click(object sender, EventArgs e)                                                      // 버튼클릭
        {
            CopyTable(myTable1);
            ShowTable(listViewCopy, myTable2);
        }
    }
}
