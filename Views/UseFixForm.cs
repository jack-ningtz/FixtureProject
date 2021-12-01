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
using Sunny.UI;
namespace FixtureProject.Views
{
    public partial class UseFixForm : UITitlePage
    {
        private readonly FixtureService fixtureService = new FixtureService(new FixtureDal());
        public UseFixForm()
        {
            InitializeComponent();
            this.btdone.Visible = false;
            this.clearTest += ClearTx;
        }

        private void PagePanel_SizeChanged(object sender, EventArgs e)
        {
            this.uiTitlePanel1.Width = this.Width;
            this.uiTitlePanel1.Height = this.PagePanel.Height - 140;
        }

        private void txfixtag_KeyPress(object sender, KeyPressEventArgs e)
        {
            char a = Convert.ToChar(Keys.Enter);
            if (e.KeyChar.Equals(a))
            {
                btInquiry_Click(sender, e);
            }
        }

        private void btInquiry_Click(object sender, EventArgs e)
        {
            var fix = this.fixtureService.ScanFixture(this.txfixtag.Text);
            if (fix == null)
            {
                this.txname.Text = "";
                this.txtag.Text = "";
                this.txdate.Text = "";
                this.txfixtag.Text = "";
                this.txusecount.Text = "";
                this.txcycle.Text = "";
                this.lbresult.Text = "";
                this.lbresult.BackColor = Color.White;
                return;
            }
            this.txname.Text = fix.FixtureName;
            this.txusecount.Text = fix.UseCount.ToString();
            this.txdate.Text = fix.InvestmentDate.ToString();
            this.txtag.Text = fix.SerialNo.ToString();
            this.txcycle.Text = fix.CycleCount.ToString();



            if (fix.UseCount < fix.CeilingCount)
            {
                if (fix.UseCount > 0)
                {
                    if (fix.UseCount % fix.CycleCount == 0)
                    {
                        this.lbresult.Text = "  周期保养";
                        this.lbresult.BackColor = Color.Red;
                        this.btdone.Show();
                    }
                    else
                    {
                        this.lbresult.Text = "OK";
                        this.lbresult.BackColor = Color.GreenYellow;
                        FixtureDal dal = new FixtureDal();
                        dal.UpdateFixture(this.txtag.Text);
                        this.Refresh();
                        //this.Invoke(this.clearTest);
                        this.clearTest();

                    }
                }
                else
                {
                    this.lbresult.Text = "OK";
                    this.lbresult.BackColor = Color.GreenYellow;
                    FixtureDal dal = new FixtureDal();
                    dal.UpdateFixture(this.txtag.Text);
                    this.Refresh();
                    this.clearTest();
                }
            }
            else             
            {
                this.lbresult.Text = "已超使用上限";
                this.lbresult.BackColor = Color.Red;
            }

        }
        public Action clearTest;
        public void ClearTx()
        {
            Thread.Sleep(1000);
            this.txname.Text = "";
            this.txtag.Text = "";
            this.txdate.Text = "";
            this.txfixtag.Text = "";
            this.txusecount.Text = "";
            this.txcycle.Text = "";
            this.lbresult.Text = "";
            this.lbresult.BackColor = Color.White;
            this.Refresh();
        }

        private void btdone_Click(object sender, EventArgs e)
        {
            this.lbresult.Text = "OK";
            this.lbresult.BackColor = Color.GreenYellow;
            FixtureDal dal = new FixtureDal();
            dal.UpdateFixture(this.txtag.Text);

            this.txname.Text = "";
            this.txtag.Text = "";
            this.txdate.Text = "";
            this.txfixtag.Text = "";
            this.txusecount.Text = "";
            this.txcycle.Text = "";
            this.lbresult.Text = "";
            this.lbresult.BackColor = Color.White;
            this.btdone.Visible = false;
            this.txfixtag.Select();
            this.txfixtag.Focus();
        }

        //private void btuse_Click(object sender, EventArgs e)
        //{
        //    if (String.IsNullOrEmpty(this.txtag.Text))
        //    {
        //        return;
        //    }
        //    var r = ShowAskDialog("是否使用?");

        //    if (r)
        //    {
        //        FixtureDal dal = new FixtureDal();
        //        dal.UpdateFixture(this.txtag.Text);
        //        this.txname.Text = "";
        //        this.txtag.Text = "";
        //        this.txdate.Text = "";
        //        this.txfixtag.Text = "";
        //        this.txusecount.Text = "";
        //        this.lbresult.Text = "";
        //        this.lbresult.BackColor = Color.White;
        //        ShowSuccessDialog("已使用！");
        //    }
        //}
    }
}
