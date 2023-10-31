using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class frmMain : Form
    {
        public Member mem { get; set; }
        public String role { get; set; }
        int counter = 1;
        public frmMain()
        {
            InitializeComponent();
        }

        public void CreateMyMainMenu()
        {
            MenuStrip mainMenu = new MenuStrip();
            this.Controls.Add(mainMenu);
            this.MainMenuStrip = mainMenu;
            ToolStripMenuItem menuFile = new ToolStripMenuItem("&Management");
            ToolStripMenuItem menuMember = new ToolStripMenuItem("&Member Management");
            ToolStripMenuItem menuOrder = new ToolStripMenuItem("&Order Management");
            ToolStripMenuItem menuProduct = new ToolStripMenuItem("&Product Management");
            ToolStripMenuItem menuLogout = new ToolStripMenuItem("&Logout");
            ToolStripMenuItem menuExit = new ToolStripMenuItem("&Exit");
            ToolStripMenuItem menuWindow = new ToolStripMenuItem("&Window");

            //mainMenu
            mainMenu.Items.AddRange(new ToolStripItem[] { menuFile, menuWindow });
            mainMenu.MdiWindowListItem = menuWindow;

            //menuFile
            if (role.Equals("Admin"))
            {
                menuFile.DropDownItems.AddRange(new ToolStripItem[] { menuMember, menuOrder, menuProduct, menuLogout, menuExit });
            }
            else
            {
                menuFile.DropDownItems.AddRange(new ToolStripItem[] { menuMember, menuOrder, menuLogout, menuExit });
            }

            //menuMember
            menuMember.Click += new EventHandler(menuMember_Click);

            //menuOrder
            menuOrder.Click += new EventHandler(menuOrder_Click);

            //menuProduct
            menuProduct.Click += new EventHandler(menuProduct_Click);

            //menuLogout
            menuLogout.Click += new EventHandler(menuLogout_Click);

            //menuExit
            menuExit.Click += new EventHandler(menuExit_Click);
        }

        private void menuMember_Click(object sender, EventArgs e)
        {
            frmMember f = new frmMember();
            f.Text = $"Form Member Management {counter++:D2}";
            f.MdiParent = this;
            f.role = role;
            f.mem = mem;
            f.Show();
        }

        private void menuOrder_Click(object sender, EventArgs e)
        {
            frmOrders f = new frmOrders();
            f.Text = $"Form Order Management {counter++:D2}";
            f.MdiParent = this;
            f.role = role;
            f.mem = mem;
            f.Show();
        }

        private void menuProduct_Click(object sender, EventArgs e)
        {
            frmProducts f = new frmProducts();
            f.Text = $"Form Product Management {counter++:D2}";
            f.MdiParent = this;
            f.role = role;
            f.mem = mem;
            f.Show();
        }

        private void menuLogout_Click(object sender, EventArgs e)
        {
            frmLogin f = new frmLogin();
            DialogResult d;
            d = MessageBox.Show("Do you really want to logout?", "Logout", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (d == DialogResult.OK)
            {
                f.Show();
                this.Hide();
            }
        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMem_Click(object sender, EventArgs e)
        {
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            CreateMyMainMenu();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("Do you really want to exit?", "Quit", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (d == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
    }
}
