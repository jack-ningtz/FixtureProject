
namespace FixtureProject.Views
{
    partial class UseFixForm
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
            this.uiLine3 = new Sunny.UI.UILine();
            this.uiTitlePanel1 = new Sunny.UI.UITitlePanel();
            this.lbresult = new System.Windows.Forms.Label();
            this.txtag = new Sunny.UI.UITextBox();
            this.uiLine5 = new Sunny.UI.UILine();
            this.txdate = new Sunny.UI.UITextBox();
            this.uiLine4 = new Sunny.UI.UILine();
            this.txusecount = new Sunny.UI.UITextBox();
            this.uiLine2 = new Sunny.UI.UILine();
            this.txname = new Sunny.UI.UITextBox();
            this.uiLine1 = new Sunny.UI.UILine();
            this.txcycle = new Sunny.UI.UITextBox();
            this.uiLine6 = new Sunny.UI.UILine();
            this.btdone = new Sunny.UI.UISymbolButton();
            this.PagePanel.SuspendLayout();
            this.uiTitlePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PagePanel
            // 
            this.PagePanel.Controls.Add(this.uiTitlePanel1);
            this.PagePanel.Controls.Add(this.uiLine3);
            this.PagePanel.Controls.Add(this.txfixtag);
            this.PagePanel.Size = new System.Drawing.Size(800, 415);
            this.PagePanel.SizeChanged += new System.EventHandler(this.PagePanel_SizeChanged);
            // 
            // txfixtag
            // 
            this.txfixtag.ButtonSymbol = 61761;
            this.txfixtag.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txfixtag.FillColor = System.Drawing.Color.White;
            this.txfixtag.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txfixtag.Location = new System.Drawing.Point(5, 63);
            this.txfixtag.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txfixtag.Maximum = 2147483647D;
            this.txfixtag.Minimum = -2147483648D;
            this.txfixtag.MinimumSize = new System.Drawing.Size(1, 1);
            this.txfixtag.Name = "txfixtag";
            this.txfixtag.Padding = new System.Windows.Forms.Padding(5);
            this.txfixtag.Size = new System.Drawing.Size(299, 29);
            this.txfixtag.TabIndex = 65;
            this.txfixtag.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txfixtag.Watermark = "治具标签";
            this.txfixtag.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txfixtag_KeyPress);
            // 
            // uiLine3
            // 
            this.uiLine3.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLine3.Location = new System.Drawing.Point(0, 6);
            this.uiLine3.MinimumSize = new System.Drawing.Size(16, 16);
            this.uiLine3.Name = "uiLine3";
            this.uiLine3.Size = new System.Drawing.Size(797, 33);
            this.uiLine3.TabIndex = 66;
            this.uiLine3.Text = "使 用";
            // 
            // uiTitlePanel1
            // 
            this.uiTitlePanel1.Controls.Add(this.btdone);
            this.uiTitlePanel1.Controls.Add(this.txcycle);
            this.uiTitlePanel1.Controls.Add(this.uiLine6);
            this.uiTitlePanel1.Controls.Add(this.lbresult);
            this.uiTitlePanel1.Controls.Add(this.txtag);
            this.uiTitlePanel1.Controls.Add(this.uiLine5);
            this.uiTitlePanel1.Controls.Add(this.txdate);
            this.uiTitlePanel1.Controls.Add(this.uiLine4);
            this.uiTitlePanel1.Controls.Add(this.txusecount);
            this.uiTitlePanel1.Controls.Add(this.uiLine2);
            this.uiTitlePanel1.Controls.Add(this.txname);
            this.uiTitlePanel1.Controls.Add(this.uiLine1);
            this.uiTitlePanel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiTitlePanel1.Location = new System.Drawing.Point(1, 126);
            this.uiTitlePanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTitlePanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTitlePanel1.Name = "uiTitlePanel1";
            this.uiTitlePanel1.Padding = new System.Windows.Forms.Padding(0, 35, 0, 0);
            this.uiTitlePanel1.Size = new System.Drawing.Size(799, 332);
            this.uiTitlePanel1.TabIndex = 67;
            this.uiTitlePanel1.Text = "治具信息";
            this.uiTitlePanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbresult
            // 
            this.lbresult.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbresult.Location = new System.Drawing.Point(452, 61);
            this.lbresult.Name = "lbresult";
            this.lbresult.Size = new System.Drawing.Size(335, 182);
            this.lbresult.TabIndex = 75;
            this.lbresult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtag
            // 
            this.txtag.ButtonSymbol = 61761;
            this.txtag.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtag.Enabled = false;
            this.txtag.FillColor = System.Drawing.Color.White;
            this.txtag.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtag.Location = new System.Drawing.Point(140, 213);
            this.txtag.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtag.Maximum = 2147483647D;
            this.txtag.Minimum = -2147483648D;
            this.txtag.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtag.Name = "txtag";
            this.txtag.Padding = new System.Windows.Forms.Padding(5);
            this.txtag.Size = new System.Drawing.Size(272, 29);
            this.txtag.TabIndex = 74;
            this.txtag.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtag.Watermark = "标签";
            // 
            // uiLine5
            // 
            this.uiLine5.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLine5.Location = new System.Drawing.Point(11, 213);
            this.uiLine5.MinimumSize = new System.Drawing.Size(2, 2);
            this.uiLine5.Name = "uiLine5";
            this.uiLine5.Size = new System.Drawing.Size(122, 29);
            this.uiLine5.TabIndex = 73;
            this.uiLine5.Text = "标 签";
            // 
            // txdate
            // 
            this.txdate.ButtonSymbol = 61761;
            this.txdate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txdate.Enabled = false;
            this.txdate.FillColor = System.Drawing.Color.White;
            this.txdate.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txdate.Location = new System.Drawing.Point(140, 161);
            this.txdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txdate.Maximum = 2147483647D;
            this.txdate.Minimum = -2147483648D;
            this.txdate.MinimumSize = new System.Drawing.Size(1, 1);
            this.txdate.Name = "txdate";
            this.txdate.Padding = new System.Windows.Forms.Padding(5);
            this.txdate.Size = new System.Drawing.Size(272, 29);
            this.txdate.TabIndex = 72;
            this.txdate.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txdate.Watermark = "日期";
            // 
            // uiLine4
            // 
            this.uiLine4.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLine4.Location = new System.Drawing.Point(11, 161);
            this.uiLine4.MinimumSize = new System.Drawing.Size(2, 2);
            this.uiLine4.Name = "uiLine4";
            this.uiLine4.Size = new System.Drawing.Size(122, 29);
            this.uiLine4.TabIndex = 71;
            this.uiLine4.Text = "投入日期";
            // 
            // txusecount
            // 
            this.txusecount.ButtonSymbol = 61761;
            this.txusecount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txusecount.Enabled = false;
            this.txusecount.FillColor = System.Drawing.Color.White;
            this.txusecount.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txusecount.Location = new System.Drawing.Point(140, 110);
            this.txusecount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txusecount.Maximum = 2147483647D;
            this.txusecount.Minimum = -2147483648D;
            this.txusecount.MinimumSize = new System.Drawing.Size(1, 1);
            this.txusecount.Name = "txusecount";
            this.txusecount.Padding = new System.Windows.Forms.Padding(5);
            this.txusecount.Size = new System.Drawing.Size(272, 29);
            this.txusecount.TabIndex = 70;
            this.txusecount.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txusecount.Watermark = "数量";
            // 
            // uiLine2
            // 
            this.uiLine2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLine2.Location = new System.Drawing.Point(11, 110);
            this.uiLine2.MinimumSize = new System.Drawing.Size(2, 2);
            this.uiLine2.Name = "uiLine2";
            this.uiLine2.Size = new System.Drawing.Size(122, 29);
            this.uiLine2.TabIndex = 69;
            this.uiLine2.Text = "使用次数";
            // 
            // txname
            // 
            this.txname.ButtonSymbol = 61761;
            this.txname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txname.Enabled = false;
            this.txname.FillColor = System.Drawing.Color.White;
            this.txname.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txname.Location = new System.Drawing.Point(140, 60);
            this.txname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txname.Maximum = 2147483647D;
            this.txname.Minimum = -2147483648D;
            this.txname.MinimumSize = new System.Drawing.Size(1, 1);
            this.txname.Name = "txname";
            this.txname.Padding = new System.Windows.Forms.Padding(5);
            this.txname.Size = new System.Drawing.Size(272, 29);
            this.txname.TabIndex = 68;
            this.txname.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txname.Watermark = "治具名";
            // 
            // uiLine1
            // 
            this.uiLine1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLine1.Location = new System.Drawing.Point(11, 60);
            this.uiLine1.MinimumSize = new System.Drawing.Size(2, 2);
            this.uiLine1.Name = "uiLine1";
            this.uiLine1.Size = new System.Drawing.Size(122, 29);
            this.uiLine1.TabIndex = 67;
            this.uiLine1.Text = "治具名";
            // 
            // txcycle
            // 
            this.txcycle.ButtonSymbol = 61761;
            this.txcycle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txcycle.Enabled = false;
            this.txcycle.FillColor = System.Drawing.Color.White;
            this.txcycle.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txcycle.Location = new System.Drawing.Point(140, 257);
            this.txcycle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txcycle.Maximum = 2147483647D;
            this.txcycle.Minimum = -2147483648D;
            this.txcycle.MinimumSize = new System.Drawing.Size(1, 1);
            this.txcycle.Name = "txcycle";
            this.txcycle.Padding = new System.Windows.Forms.Padding(5);
            this.txcycle.Size = new System.Drawing.Size(272, 29);
            this.txcycle.TabIndex = 77;
            this.txcycle.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txcycle.Watermark = "数量";
            // 
            // uiLine6
            // 
            this.uiLine6.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLine6.Location = new System.Drawing.Point(11, 257);
            this.uiLine6.MinimumSize = new System.Drawing.Size(2, 2);
            this.uiLine6.Name = "uiLine6";
            this.uiLine6.Size = new System.Drawing.Size(122, 29);
            this.uiLine6.TabIndex = 76;
            this.uiLine6.Text = "周期保养次数";
            // 
            // btdone
            // 
            this.btdone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btdone.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btdone.Location = new System.Drawing.Point(447, 257);
            this.btdone.MinimumSize = new System.Drawing.Size(1, 1);
            this.btdone.Name = "btdone";
            this.btdone.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.btdone.Size = new System.Drawing.Size(141, 29);
            this.btdone.TabIndex = 78;
            this.btdone.Text = "保养完成";
            this.btdone.Click += new System.EventHandler(this.btdone_Click);
            // 
            // UseFixForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "UseFixForm";
            this.Text = "使用治具";
            this.PagePanel.ResumeLayout(false);
            this.uiTitlePanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UITextBox txfixtag;
        private Sunny.UI.UILine uiLine3;
        private Sunny.UI.UITitlePanel uiTitlePanel1;
        private Sunny.UI.UITextBox txusecount;
        private Sunny.UI.UILine uiLine2;
        private Sunny.UI.UITextBox txname;
        private Sunny.UI.UILine uiLine1;
        private Sunny.UI.UITextBox txtag;
        private Sunny.UI.UILine uiLine5;
        private Sunny.UI.UITextBox txdate;
        private Sunny.UI.UILine uiLine4;
        private System.Windows.Forms.Label lbresult;
        private Sunny.UI.UISymbolButton btdone;
        private Sunny.UI.UITextBox txcycle;
        private Sunny.UI.UILine uiLine6;
    }
}