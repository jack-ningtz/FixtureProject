using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using FixtureProject.Controls;
using FixtureProject.DAL;
using FixtureProject.utils;
using Sunny.UI;

namespace FixtureProject.Views
{
    public partial class InquiryForm : UITitlePage
    {
        private readonly FixtureService fixtureService = new FixtureService(new FixtureDal());
        public InquiryForm()
        {
            InitializeComponent();
            new utils.DataGridViewStyle().ChangeStyle(this.dataGridView1);
        }

        private void btInquiry_Click(object sender, EventArgs e)
        {
            ShowWaitForm();
            SetWaitFormDescription(UILocalize.SystemProcessing + "50%");
            this.dataGridView1.DataSource = fixtureService.InqueryFixtures(this.txtag.Text);
            HideWaitForm();
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btcancel_Click(object sender, EventArgs e)
        {
            this.txtag.Text = "";
            this.dataGridView1.DataSource = null;
        }

        private void btexcel_Click(object sender, EventArgs e)
        {
            Boolean b = new 
                Excel().OutToExcelFromDataGridView("导出记录", this.dataGridView1, false);
            if (b)
            {
                this.HideWaitForm();
                Thread.Sleep(1000);
                this.ShowSuccessNotifier("导出成功！！");
            }
            else
            {
                this.ShowErrorNotifier("导出失败");
            }
        }

        private void PagePanel_Click(object sender, EventArgs e)
        {

        }
    }
}
