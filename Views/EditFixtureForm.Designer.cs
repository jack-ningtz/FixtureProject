
namespace FixtureProject.Views
{
    partial class EditFixtureForm
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
            this.tbFixtureName = new Sunny.UI.UITextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSerialNo = new Sunny.UI.UITextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCeilingCount = new Sunny.UI.UITextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbCycleCount = new Sunny.UI.UITextBox();
            this.pnlBtm.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBtm
            // 
            this.pnlBtm.Size = new System.Drawing.Size(599, 55);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(471, 12);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(356, 12);
            // 
            // tbFixtureName
            // 
            this.tbFixtureName.ButtonSymbol = 61761;
            this.tbFixtureName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbFixtureName.FillColor = System.Drawing.Color.White;
            this.tbFixtureName.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.tbFixtureName.Location = new System.Drawing.Point(190, 143);
            this.tbFixtureName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbFixtureName.Maximum = 2147483647D;
            this.tbFixtureName.Minimum = -2147483648D;
            this.tbFixtureName.MinimumSize = new System.Drawing.Size(1, 1);
            this.tbFixtureName.Name = "tbFixtureName";
            this.tbFixtureName.Padding = new System.Windows.Forms.Padding(5);
            this.tbFixtureName.Size = new System.Drawing.Size(181, 29);
            this.tbFixtureName.TabIndex = 28;
            this.tbFixtureName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(51, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 28);
            this.label1.TabIndex = 27;
            this.label1.Text = "治具名";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbSerialNo
            // 
            this.tbSerialNo.ButtonSymbol = 61761;
            this.tbSerialNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSerialNo.FillColor = System.Drawing.Color.White;
            this.tbSerialNo.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.tbSerialNo.Location = new System.Drawing.Point(190, 74);
            this.tbSerialNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbSerialNo.Maximum = 2147483647D;
            this.tbSerialNo.Minimum = -2147483648D;
            this.tbSerialNo.MinimumSize = new System.Drawing.Size(1, 1);
            this.tbSerialNo.Name = "tbSerialNo";
            this.tbSerialNo.Padding = new System.Windows.Forms.Padding(5);
            this.tbSerialNo.Size = new System.Drawing.Size(181, 29);
            this.tbSerialNo.TabIndex = 26;
            this.tbSerialNo.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(51, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 28);
            this.label2.TabIndex = 25;
            this.label2.Text = "治具标签";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(51, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 28);
            this.label3.TabIndex = 29;
            this.label3.Text = "使用上限";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbCeilingCount
            // 
            this.tbCeilingCount.ButtonSymbol = 61761;
            this.tbCeilingCount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbCeilingCount.FillColor = System.Drawing.Color.White;
            this.tbCeilingCount.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.tbCeilingCount.Location = new System.Drawing.Point(190, 192);
            this.tbCeilingCount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbCeilingCount.Maximum = 2147483647D;
            this.tbCeilingCount.Minimum = -2147483648D;
            this.tbCeilingCount.MinimumSize = new System.Drawing.Size(1, 1);
            this.tbCeilingCount.Name = "tbCeilingCount";
            this.tbCeilingCount.Padding = new System.Windows.Forms.Padding(5);
            this.tbCeilingCount.Size = new System.Drawing.Size(181, 29);
            this.tbCeilingCount.TabIndex = 30;
            this.tbCeilingCount.Text = "0";
            this.tbCeilingCount.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbCeilingCount.Type = Sunny.UI.UITextBox.UIEditType.Integer;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(51, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 28);
            this.label5.TabIndex = 31;
            this.label5.Text = "保养周期次数";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbCycleCount
            // 
            this.tbCycleCount.ButtonSymbol = 61761;
            this.tbCycleCount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbCycleCount.FillColor = System.Drawing.Color.White;
            this.tbCycleCount.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.tbCycleCount.Location = new System.Drawing.Point(190, 243);
            this.tbCycleCount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbCycleCount.Maximum = 2147483647D;
            this.tbCycleCount.Minimum = -2147483648D;
            this.tbCycleCount.MinimumSize = new System.Drawing.Size(1, 1);
            this.tbCycleCount.Name = "tbCycleCount";
            this.tbCycleCount.Padding = new System.Windows.Forms.Padding(5);
            this.tbCycleCount.Size = new System.Drawing.Size(181, 29);
            this.tbCycleCount.TabIndex = 32;
            this.tbCycleCount.Text = "0";
            this.tbCycleCount.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbCycleCount.Type = Sunny.UI.UITextBox.UIEditType.Integer;
            // 
            // EditFixtureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 450);
            this.Controls.Add(this.tbCycleCount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbCeilingCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbFixtureName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSerialNo);
            this.Controls.Add(this.label2);
            this.Name = "EditFixtureForm";
            this.Text = "EditCustomerForm";
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.tbSerialNo, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.tbFixtureName, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.tbCeilingCount, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.tbCycleCount, 0);
            this.Controls.SetChildIndex(this.pnlBtm, 0);
            this.pnlBtm.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UITextBox tbFixtureName;
        private System.Windows.Forms.Label label1;
        private Sunny.UI.UITextBox tbSerialNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Sunny.UI.UITextBox tbCeilingCount;
        private System.Windows.Forms.Label label5;
        private Sunny.UI.UITextBox tbCycleCount;
    }
}