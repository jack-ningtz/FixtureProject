
namespace FixtureProject.Views
{
    partial class InquiryForm
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
            this.txtag = new Sunny.UI.UITextBox();
            this.uiLine3 = new Sunny.UI.UILine();
            this.btInquiry = new Sunny.UI.UISymbolButton();
            this.btcancel = new Sunny.UI.UISymbolButton();
            this.btexcel = new Sunny.UI.UISymbolButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // PagePanel
            // 
            this.PagePanel.Controls.Add(this.dataGridView1);
            this.PagePanel.Controls.Add(this.btInquiry);
            this.PagePanel.Controls.Add(this.btcancel);
            this.PagePanel.Controls.Add(this.btexcel);
            this.PagePanel.Controls.Add(this.uiLine3);
            this.PagePanel.Controls.Add(this.txtag);
            this.PagePanel.Size = new System.Drawing.Size(800, 415);
            this.PagePanel.Click += new System.EventHandler(this.PagePanel_Click);
            // 
            // txtag
            // 
            this.txtag.ButtonSymbol = 61761;
            this.txtag.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtag.FillColor = System.Drawing.Color.White;
            this.txtag.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtag.Location = new System.Drawing.Point(13, 46);
            this.txtag.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtag.Maximum = 2147483647D;
            this.txtag.Minimum = -2147483648D;
            this.txtag.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtag.Name = "txtag";
            this.txtag.Padding = new System.Windows.Forms.Padding(5);
            this.txtag.Size = new System.Drawing.Size(275, 29);
            this.txtag.TabIndex = 63;
            this.txtag.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtag.Watermark = "治具标签";
            // 
            // uiLine3
            // 
            this.uiLine3.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLine3.Location = new System.Drawing.Point(0, 3);
            this.uiLine3.MinimumSize = new System.Drawing.Size(16, 16);
            this.uiLine3.Name = "uiLine3";
            this.uiLine3.Size = new System.Drawing.Size(797, 33);
            this.uiLine3.TabIndex = 64;
            this.uiLine3.Text = "查  询";
            // 
            // btInquiry
            // 
            this.btInquiry.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btInquiry.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btInquiry.Location = new System.Drawing.Point(485, 101);
            this.btInquiry.MinimumSize = new System.Drawing.Size(1, 1);
            this.btInquiry.Name = "btInquiry";
            this.btInquiry.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.btInquiry.Size = new System.Drawing.Size(100, 35);
            this.btInquiry.Symbol = 61442;
            this.btInquiry.TabIndex = 74;
            this.btInquiry.Text = "查询";
            this.btInquiry.Click += new System.EventHandler(this.btInquiry_Click);
            // 
            // btcancel
            // 
            this.btcancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btcancel.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btcancel.Location = new System.Drawing.Point(697, 101);
            this.btcancel.MinimumSize = new System.Drawing.Size(1, 1);
            this.btcancel.Name = "btcancel";
            this.btcancel.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.btcancel.Size = new System.Drawing.Size(100, 35);
            this.btcancel.Symbol = 61453;
            this.btcancel.TabIndex = 73;
            this.btcancel.Text = "取消";
            this.btcancel.Click += new System.EventHandler(this.btcancel_Click);
            // 
            // btexcel
            // 
            this.btexcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btexcel.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btexcel.Location = new System.Drawing.Point(591, 101);
            this.btexcel.MinimumSize = new System.Drawing.Size(1, 1);
            this.btexcel.Name = "btexcel";
            this.btexcel.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.btexcel.Size = new System.Drawing.Size(100, 35);
            this.btexcel.Symbol = 61639;
            this.btexcel.TabIndex = 72;
            this.btexcel.Text = "导出";
            this.btexcel.Click += new System.EventHandler(this.btexcel_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 142);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(800, 273);
            this.dataGridView1.TabIndex = 75;
            // 
            // InquiryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "InquiryForm";
            this.Text = "查询";
            this.PagePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UITextBox txtag;
        private Sunny.UI.UILine uiLine3;
        private Sunny.UI.UISymbolButton btInquiry;
        private Sunny.UI.UISymbolButton btcancel;
        private Sunny.UI.UISymbolButton btexcel;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}