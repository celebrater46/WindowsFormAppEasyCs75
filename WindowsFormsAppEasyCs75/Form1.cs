using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppEasyCs75
{
    public partial class Form1 : Form
    {
        private Label lb;
        private MenuStrip ms;
        private ToolStripMenuItem[] mi = new ToolStripMenuItem[10];
        public Form1()
        {
            InitializeComponent();
            this.Text = "Menu Test";
            this.Width = 250;
            this.Height = 200;

            lb = new Label();
            lb.Text = "Welcome.";
            lb.Dock = DockStyle.Bottom;

            ms = new MenuStrip();
            mi[0] = new ToolStripMenuItem("Main 1");
            mi[1] = new ToolStripMenuItem("Main 2");
            mi[2] = new ToolStripMenuItem("Car");
            mi[3] = new ToolStripMenuItem("Truck");
            mi[4] = new ToolStripMenuItem("F1");
            mi[5] = new ToolStripMenuItem("Taxi");
            mi[6] = new ToolStripMenuItem("Sub 1");
            mi[7] = new ToolStripMenuItem("Sub 2");
            mi[8] = new ToolStripMenuItem("Mini");
            mi[9] = new ToolStripMenuItem("Benz");

            mi[0].DropDownItems.Add(mi[4]);
            mi[0].DropDownItems.Add(mi[5]);
            
            mi[1].DropDownItems.Add(mi[2]);
            mi[1].DropDownItems.Add(new ToolStripSeparator());
            mi[1].DropDownItems.Add(mi[3]);
            mi[2].DropDownItems.Add(mi[6]);
            mi[2].DropDownItems.Add(mi[7]);
            mi[3].DropDownItems.Add(mi[8]);
            mi[3].DropDownItems.Add(mi[9]);

            ms.Items.Add(mi[0]);
            ms.Items.Add(mi[1]);

            this.MainMenuStrip = ms;

            ms.Parent = this;
            lb.Parent = this;

            for (int i = 4; i < mi.Length; i++)
            {
                mi[i].Click += new EventHandler(MiClick);
            }
        }

        public void MiClick(Object sender, EventArgs e)
        {
            ToolStripMenuItem mi = (ToolStripMenuItem) sender;
            lb.Text = String.Format("{0} やで！", mi.Text);
        }
    }
}