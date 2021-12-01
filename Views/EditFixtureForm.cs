using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FixtureProject.Models;
using Sunny.UI;


namespace FixtureProject.Views
{
    public partial class EditFixtureForm : UIEditForm
    {
        private Fixture fixture;
        private int id;
        public EditFixtureForm()
        {
            InitializeComponent();
        }
        //public EditCustomerForm(string title) : base()
        //{
        //    this.Text = title;
        //}
        public void OpFixture(string title, Fixture _fixture,string operate)
        {
            
            this.Text = title;
            if (operate.Equals("update"))
            {
                this.rectColor = Color.FromArgb(225, 128, 0);
                this.tbSerialNo.Enabled = false;
            }
            if (operate.Equals("delete"))
            {
                this.rectColor = Color.Red;
                this.tbSerialNo.Enabled = false;
                this.tbFixtureName.Enabled = false;
                this.tbCeilingCount.Enabled = false;
                this.tbCycleCount.Enabled = false;
            }
            
            this.tbSerialNo.Text = _fixture.SerialNo;
            this.tbFixtureName.Text = _fixture.FixtureName;
            this.tbCeilingCount.Text = _fixture.CeilingCount.ToString();
            this.tbCycleCount.Text = _fixture.CycleCount.ToString();
            this.id = _fixture.Id;

        }
        //protected override bool CheckData()
        //{
        //    return CheckEmpty(tbFixtureName, "请输入客户名称"); ;
        //}
        public Fixture Fixture
        {
            get 
            {
                if (fixture == null)
                {
                    fixture = new Fixture();
                }
                fixture.SerialNo = this.tbSerialNo.Text;
                fixture.FixtureName = this.tbFixtureName.Text;
                fixture.CeilingCount = this.tbCeilingCount.Text.ToInt();
                fixture.CycleCount = this.tbCycleCount.Text.ToInt();
                fixture.Id = this.id;
                return fixture;
            }
            set 
            {
                fixture = value;
                fixture.SerialNo = value.SerialNo;
                fixture.FixtureName = value.FixtureName;
                fixture.CeilingCount = value.CeilingCount;
                fixture.CycleCount = value.CycleCount;
                fixture.Id = value.Id;
            }
        }
        
    }
}
