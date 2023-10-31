using BusinessObjects.Models;
using DataAccess.Repository;
using Microsoft.Extensions.Configuration;
using static System.Net.WebRequestMethods;

namespace SalesWinApp
{
    public partial class frmLogin : Form
    {
        IMemberRepository memberRepository = new MemberRepository();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            IConfiguration config = new ConfigurationBuilder()
            .SetBasePath("D:\\FPT\\Term 5\\Code\\DemoCSharp\\Ass2\\Ass02Solution\\BusinessObjects")
            .AddJsonFile("appsettings.json", true, true)
            .Build();
            var adminEmail = config["AdminAccount:Email"];
            var adminPassword = config["AdminAccount:Password"];
            if (txtEmail.Text.Equals(adminEmail) && txtPassword.Text.Equals(adminPassword))
            {
                frmMain f = new frmMain();
                f.role = "Admin";
                f.Show();
                this.Hide();
            }
            else
            {
                var mem = memberRepository.CheckLogin(txtEmail.Text, txtPassword.Text);
                if (mem != null)
                {
                    frmMain f = new frmMain();
                    f.role = "Member";
                    f.mem = mem;
                    f.Show();
                    this.Hide();
                } else
                {
                    MessageBox.Show("Incorrect Email or Password", "Error");
                }
            }
        }
    }
}