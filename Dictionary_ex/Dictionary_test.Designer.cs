namespace Dictionary_ex
{
    partial class Dictionary_test
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
            this.btnCopy = new System.Windows.Forms.Button();
            this.listViewCopy = new System.Windows.Forms.ListView();
            this.ch2_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch2_phonenumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewDictionary = new System.Windows.Forms.ListView();
            this.ch1_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch1_phonenumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AddName = new System.Windows.Forms.TextBox();
            this.AddTel = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCopy
            // 
            this.btnCopy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopy.Location = new System.Drawing.Point(233, 106);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(75, 37);
            this.btnCopy.TabIndex = 1;
            this.btnCopy.Text = "복사 >>";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // listViewCopy
            // 
            this.listViewCopy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewCopy.BackColor = System.Drawing.SystemColors.Window;
            this.listViewCopy.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch2_name,
            this.ch2_phonenumber});
            this.listViewCopy.Cursor = System.Windows.Forms.Cursors.Default;
            this.listViewCopy.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listViewCopy.GridLines = true;
            this.listViewCopy.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewCopy.HideSelection = false;
            this.listViewCopy.Location = new System.Drawing.Point(314, 12);
            this.listViewCopy.Name = "listViewCopy";
            this.listViewCopy.Size = new System.Drawing.Size(215, 264);
            this.listViewCopy.TabIndex = 2;
            this.listViewCopy.TabStop = false;
            this.listViewCopy.UseCompatibleStateImageBehavior = false;
            this.listViewCopy.View = System.Windows.Forms.View.Details;
            // 
            // ch2_name
            // 
            this.ch2_name.Text = "이름(key)";
            this.ch2_name.Width = 70;
            // 
            // ch2_phonenumber
            // 
            this.ch2_phonenumber.Text = "전화번호(Value)";
            this.ch2_phonenumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ch2_phonenumber.Width = 125;
            // 
            // listViewDictionary
            // 
            this.listViewDictionary.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewDictionary.BackColor = System.Drawing.SystemColors.Window;
            this.listViewDictionary.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch1_name,
            this.ch1_phonenumber});
            this.listViewDictionary.Cursor = System.Windows.Forms.Cursors.Default;
            this.listViewDictionary.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listViewDictionary.GridLines = true;
            this.listViewDictionary.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewDictionary.HideSelection = false;
            this.listViewDictionary.Location = new System.Drawing.Point(12, 12);
            this.listViewDictionary.Name = "listViewDictionary";
            this.listViewDictionary.Size = new System.Drawing.Size(215, 237);
            this.listViewDictionary.TabIndex = 3;
            this.listViewDictionary.TabStop = false;
            this.listViewDictionary.UseCompatibleStateImageBehavior = false;
            this.listViewDictionary.View = System.Windows.Forms.View.Details;
            // 
            // ch1_name
            // 
            this.ch1_name.Text = "이름(key)";
            this.ch1_name.Width = 70;
            // 
            // ch1_phonenumber
            // 
            this.ch1_phonenumber.Text = "전화번호(Value)";
            this.ch1_phonenumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ch1_phonenumber.Width = 125;
            // 
            // AddName
            // 
            this.AddName.Location = new System.Drawing.Point(11, 255);
            this.AddName.Name = "AddName";
            this.AddName.Size = new System.Drawing.Size(71, 21);
            this.AddName.TabIndex = 4;
            // 
            // AddTel
            // 
            this.AddTel.Location = new System.Drawing.Point(86, 255);
            this.AddTel.Name = "AddTel";
            this.AddTel.Size = new System.Drawing.Size(122, 21);
            this.AddTel.TabIndex = 5;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(212, 254);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(16, 23);
            this.AddButton.TabIndex = 6;
            this.AddButton.Text = "+";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // Dictionary_test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 286);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.AddTel);
            this.Controls.Add(this.AddName);
            this.Controls.Add(this.listViewDictionary);
            this.Controls.Add(this.listViewCopy);
            this.Controls.Add(this.btnCopy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Dictionary_test";
            this.Text = "Dictionary_test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.ListView listViewCopy;
        private System.Windows.Forms.ColumnHeader ch2_name;
        private System.Windows.Forms.ColumnHeader ch2_phonenumber;
        private System.Windows.Forms.ListView listViewDictionary;
        private System.Windows.Forms.ColumnHeader ch1_name;
        private System.Windows.Forms.ColumnHeader ch1_phonenumber;
        private System.Windows.Forms.TextBox AddName;
        private System.Windows.Forms.TextBox AddTel;
        private System.Windows.Forms.Button AddButton;
    }
}

