
namespace FixtureProject.Views
{
    partial class RegisterFixtureForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txfixtag = new Sunny.UI.UITextBox();
            this.txfixname = new Sunny.UI.UITextBox();
            this.uiTbCount = new Sunny.UI.UITextBox();
            this.uiLine1 = new Sunny.UI.UILine();
            this.btnAdd = new Sunny.UI.UISymbolButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.uiLine3 = new Sunny.UI.UILine();
            this.txCycle = new Sunny.UI.UITextBox();
            this.uiLine2 = new Sunny.UI.UILine();
            this.btdelect = new Sunny.UI.UISymbolButton();
            this.btnEdit = new Sunny.UI.UISymbolButton();
            this.btInquiry = new Sunny.UI.UISymbolButton();
            this.PagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // PagePanel
            // 
            this.PagePanel.Controls.Add(this.btInquiry);
            this.PagePanel.Controls.Add(this.btdelect);
            this.PagePanel.Controls.Add(this.btnEdit);
            this.PagePanel.Controls.Add(this.txCycle);
            this.PagePanel.Controls.Add(this.uiLine2);
            this.PagePanel.Controls.Add(this.uiLine3);
            this.PagePanel.Controls.Add(this.dataGridView1);
            this.PagePanel.Controls.Add(this.btnAdd);
            this.PagePanel.Controls.Add(this.uiTbCount);
            this.PagePanel.Controls.Add(this.uiLine1);
            this.PagePanel.Controls.Add(this.txfixname);
            this.PagePanel.Controls.Add(this.txfixtag);
            this.PagePanel.Size = new System.Drawing.Size(800, 415);
            // 
            // txfixtag
            // 
            this.txfixtag.ButtonSymbol = 61761;
            this.txfixtag.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txfixtag.FillColor = System.Drawing.Color.White;
            this.txfixtag.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txfixtag.Location = new System.Drawing.Point(29, 49);
            this.txfixtag.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txfixtag.Maximum = 2147483647D;
            this.txfixtag.Minimum = -2147483648D;
            this.txfixtag.MinimumSize = new System.Drawing.Size(1, 1);
            this.txfixtag.Name = "txfixtag";
            this.txfixtag.Padding = new System.Windows.Forms.Padding(5);
            this.txfixtag.Size = new System.Drawing.Size(299, 29);
            this.txfixtag.TabIndex = 64;
            this.txfixtag.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txfixtag.Watermark = "治具标签";
            // 
            // txfixname
            // 
            this.txfixname.ButtonSymbol = 61761;
            this.txfixname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txfixname.FillColor = System.Drawing.Color.White;
            this.txfixname.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txfixname.Location = new System.Drawing.Point(29, 110);
            this.txfixname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txfixname.Maximum = 2147483647D;
            this.txfixname.Minimum = -2147483648D;
            this.txfixname.MinimumSize = new System.Drawing.Size(1, 1);
            this.txfixname.Name = "txfixname";
            this.txfixname.Padding = new System.Windows.Forms.Padding(5);
            this.txfixname.Size = new System.Drawing.Size(299, 29);
            this.txfixname.TabIndex = 65;
            this.txfixname.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txfixname.Watermark = "治具名称";
            // 
            // uiTbCount
            // 
            this.uiTbCount.ButtonSymbol = 61761;
            this.uiTbCount.CanEmpty = true;
            this.uiTbCount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTbCount.DoubleValue = 100000D;
            this.uiTbCount.FillColor = System.Drawing.Color.White;
            this.uiTbCount.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiTbCount.IntValue = 100000;
            this.uiTbCount.Location = new System.Drawing.Point(179, 158);
            this.uiTbCount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTbCount.Maximum = 9D;
            this.uiTbCount.Minimum = 0D;
            this.uiTbCount.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTbCount.Name = "uiTbCount";
            this.uiTbCount.Padding = new System.Windows.Forms.Padding(5);
            this.uiTbCount.Size = new System.Drawing.Size(149, 29);
            this.uiTbCount.TabIndex = 67;
            this.uiTbCount.Text = "100000";
            this.uiTbCount.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTbCount.Type = Sunny.UI.UITextBox.UIEditType.Integer;
            this.uiTbCount.Watermark = "数量";
            // 
            // uiLine1
            // 
            this.uiLine1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLine1.Location = new System.Drawing.Point(29, 158);
            this.uiLine1.MinimumSize = new System.Drawing.Size(2, 2);
            this.uiLine1.Name = "uiLine1";
            this.uiLine1.Size = new System.Drawing.Size(131, 29);
            this.uiLine1.TabIndex = 66;
            this.uiLine1.Text = "使用上限";
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnAdd.Location = new System.Drawing.Point(395, 209);
            this.btnAdd.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.btnAdd.Size = new System.Drawing.Size(98, 29);
            this.btnAdd.Symbol = 61543;
            this.btnAdd.TabIndex = 68;
            this.btnAdd.Text = "添加";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 248);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(800, 164);
            this.dataGridView1.TabIndex = 76;
            // 
            // uiLine3
            // 
            this.uiLine3.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLine3.Location = new System.Drawing.Point(0, 0);
            this.uiLine3.MinimumSize = new System.Drawing.Size(16, 16);
            this.uiLine3.Name = "uiLine3";
            this.uiLine3.Size = new System.Drawing.Size(797, 33);
            this.uiLine3.TabIndex = 77;
            this.uiLine3.Text = "添 加 治 具";
            // 
            // txCycle
            // 
            this.txCycle.ButtonSymbol = 61761;
            this.txCycle.CanEmpty = true;
            this.txCycle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txCycle.DoubleValue = 1000D;
            this.txCycle.FillColor = System.Drawing.Color.White;
            this.txCycle.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txCycle.IntValue = 1000;
            this.txCycle.Location = new System.Drawing.Point(179, 209);
            this.txCycle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txCycle.Maximum = 9D;
            this.txCycle.Minimum = 0D;
            this.txCycle.MinimumSize = new System.Drawing.Size(1, 1);
            this.txCycle.Name = "txCycle";
            this.txCycle.Padding = new System.Windows.Forms.Padding(5);
            this.txCycle.Size = new System.Drawing.Size(149, 29);
            this.txCycle.TabIndex = 79;
            this.txCycle.Text = "1000";
            this.txCycle.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txCycle.Type = Sunny.UI.UITextBox.UIEditType.Integer;
            this.txCycle.Watermark = "数量";
            // 
            // uiLine2
            // 
            this.uiLine2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLine2.Location = new System.Drawing.Point(29, 209);
            this.uiLine2.MinimumSize = new System.Drawing.Size(2, 2);
            this.uiLine2.Name = "uiLine2";
            this.uiLine2.Size = new System.Drawing.Size(131, 29);
            this.uiLine2.TabIndex = 78;
            this.uiLine2.Text = "周期保养次数";
            // 
            // btdelect
            // 
            this.btdelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btdelect.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btdelect.Location = new System.Drawing.Point(605, 209);
            this.btdelect.MinimumSize = new System.Drawing.Size(1, 1);
            this.btdelect.Name = "btdelect";
            this.btdelect.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.btdelect.Size = new System.Drawing.Size(100, 29);
            this.btdelect.Symbol = 61544;
            this.btdelect.TabIndex = 81;
            this.btdelect.Text = "删除";
            this.btdelect.Click += new System.EventHandler(this.btdelect_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnEdit.Location = new System.Drawing.Point(499, 209);
            this.btnEdit.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.btnEdit.Size = new System.Drawing.Size(100, 29);
            this.btnEdit.Symbol = 61508;
            this.btnEdit.TabIndex = 80;
            this.btnEdit.Text = "编辑";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btInquiry
            // 
            this.btInquiry.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btInquiry.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btInquiry.Location = new System.Drawing.Point(711, 209);
            this.btInquiry.MinimumSize = new System.Drawing.Size(1, 1);
            this.btInquiry.Name = "btInquiry";
            this.btInquiry.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.btInquiry.Size = new System.Drawing.Size(89, 29);
            this.btInquiry.Symbol = 61442;
            this.btInquiry.TabIndex = 82;
            this.btInquiry.Text = "查询";
            this.btInquiry.Click += new System.EventHandler(this.btInquiry_Click);
            // 
            // RegisterFixtureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "RegisterFixtureForm";
            this.Text = "添加治具";
            this.PagePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UITextBox txfixtag;
        private Sunny.UI.UITextBox txfixname;
        private Sunny.UI.UITextBox uiTbCount;
        private Sunny.UI.UILine uiLine1;
        private Sunny.UI.UISymbolButton btnAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Sunny.UI.UILine uiLine3;
        private Sunny.UI.UITextBox txCycle;
        private Sunny.UI.UILine uiLine2;
        private Sunny.UI.UISymbolButton btdelect;
        private Sunny.UI.UISymbolButton btnEdit;
        private Sunny.UI.UISymbolButton btInquiry;
    }
}