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
using FixtureProject.Models;
using Sunny.UI;
namespace FixtureProject.Views
{
    public partial class RegisterFixtureForm : UITitlePage
    {
        private readonly FixtureService fixtureService = new FixtureService(new FixtureDal());
        public RegisterFixtureForm()
        {
            InitializeComponent();
            new utils.DataGridViewStyle().ChangeStyle(this.dataGridView1);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.txfixtag.Text))
            {
                this.txfixtag.Select();
                this.txfixtag.Focus();
                return;
            }
            if (String.IsNullOrEmpty(this.txfixname.Text))
            {
                this.txfixname.Select();
                this.txfixname.Focus();
                return;
            }
            if (string.IsNullOrEmpty(this.txCycle.Text))
            {
                this.txCycle.Select();
                this.txCycle.Focus();
                return;
            }
            ShowWaitForm();
            SetWaitFormDescription(UILocalize.SystemProcessing + "50%");
            var fix = this.FindFixture(this.txfixtag.Text);
            if (fix != null)
            {
                if (!string.IsNullOrEmpty(fix.SerialNo))
                {
                    this.ShowErrorDialog("已存在该治具--");
                    HideWaitForm();
                    return;
                }
            }
            AddFixture(this.txfixtag.Text,this.txfixname.Text);
            HideWaitForm();
            Thread.Sleep(1000);
            this.ShowSuccessDialog("添加成功");
            this.dataGridView1.DataSource = this.fixtureService.SearchFixtures(this.txfixtag.Text);
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.ClearText();
        }

        private void AddFixture(string tag, string name)
        {

            Fixture fixture = new Fixture {
                SerialNo = tag,
                FixtureName = name,
                CeilingCount = String.IsNullOrEmpty(this.uiTbCount.Text) ? 0 : this.uiTbCount.Text.ToInt(),
                InvestmentDate = DateTime.Now,
                CycleCount = this.txCycle.Text.ToInt(),
                Status = false,
                UseCount = 0
            };
            try
            {
                
                fixtureService.AddFixture(fixture);
            }
            catch (Exception e)
            {

                this.ShowErrorDialog(e.ToString());
            }

        }
        public Fixture FindFixture(string serialno)
        {
            return fixtureService.ScanFixture(serialno);
        }
        public void ClearText()
        {
            this.txfixtag.Text = "";
            this.txfixname.Text = "";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.DataSource != null)
            {
                if (this.dataGridView1.Rows.Count > 0)
                {
                    Fixture fixture = new Fixture()
                    {
                        Id = this.dataGridView1.CurrentRow.Cells[0].Value.ToString().ToInt(),
                        SerialNo = this.dataGridView1.CurrentRow.Cells[1].Value.ToString(),
                        FixtureName = this.dataGridView1.CurrentRow.Cells[2].Value.ToString(),
                        CeilingCount = this.dataGridView1.CurrentRow.Cells[4].Value.ToString().ToInt(),
                        CycleCount = this.dataGridView1.CurrentRow.Cells[5].Value.ToString().ToInt()

                    };
                    EditFixtureForm editFixtureForm = new EditFixtureForm();
                    editFixtureForm.OpFixture("更改治具",fixture,"update");
                    editFixtureForm.ShowDialog();
                    if (editFixtureForm.IsOK)
                    {
                        fixtureService.UpdateFixture(editFixtureForm.Fixture);
                        this.ShowSuccessDialog("update success");
                        this.btInquiry_Click(sender, e);
                    }

                }
            }
        }

        private void btdelect_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.DataSource != null)
            {
                if (this.dataGridView1.Rows.Count > 0)
                {
                    Fixture fixture = new Fixture()
                    {
                        Id = this.dataGridView1.CurrentRow.Cells[0].Value.ToString().ToInt(),
                        SerialNo = this.dataGridView1.CurrentRow.Cells[1].Value.ToString(),
                        FixtureName = this.dataGridView1.CurrentRow.Cells[2].Value.ToString(),
                        CeilingCount = this.dataGridView1.CurrentRow.Cells[4].Value.ToString().ToInt(),
                        CycleCount = this.dataGridView1.CurrentRow.Cells[5].Value.ToString().ToInt()

                    };
                    EditFixtureForm editFixtureForm = new EditFixtureForm();
                    editFixtureForm.OpFixture("删除治具", fixture, "delete");
                    editFixtureForm.ShowDialog();
                    if (editFixtureForm.IsOK)
                    {
                        fixtureService.DeleteFixture(editFixtureForm.Fixture);
                        this.ShowSuccessDialog("update success");
                        this.btInquiry_Click(sender, e);
                    }

                }
            }
        }

        private void btInquiry_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = this.fixtureService.SearchFixtures(this.txfixtag.Text);
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
