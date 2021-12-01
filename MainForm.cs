using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FixtureProject.Views;
using Sunny.UI;
namespace FixtureProject
{
    public partial class MainForm : UIAsideMainFrame
    {
        public MainForm()
        {
            InitializeComponent();
            int pageIndex = 1000;
            TreeNode parent = Aside.CreateNode("治具管理", 61451, 24, pageIndex);
            //通过设置PageIndex关联
            Aside.CreateChildNode(parent, 61640, 24, AddPage(new UseFixForm(), ++pageIndex));
            Aside.CreateChildNode(parent, 62141, 24, AddPage(new RegisterFixtureForm(), ++pageIndex));

            pageIndex = 2000;
            parent = Aside.CreateNode("查询", 61818, 24, pageIndex);
            //通过设置GUID关联，节点字体图标和大小由UIPage设置
            Aside.CreateChildNode(parent, AddPage(new InquiryForm(), Guid.NewGuid()));

            Aside.SelectFirst();
        }
        
    }
}
