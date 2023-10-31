using BusinessObjects.Models;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SalesWinApp
{
    public partial class frmMemberDetails : Form
    {
        public IMemberRepository MemberRepository { get; set; }
        public bool InsertOrUpdate { get; set; }
        public Member Member { get; set; }
        public String role { get; set; }

        public frmMemberDetails()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var mem = new Member
                {
                    MemberId = int.Parse(txtMemID.Text),
                    Email = txtEmail.Text,
                    Password = txtPassword.Text,
                    CompanyName = txtCompany.Text,
                    City = txtCity.Text,
                    Country = txtCountry.Text,
                };
                DialogResult d;
                if (!string.IsNullOrEmpty(mem.Email) && !string.IsNullOrEmpty(mem.Password) && !string.IsNullOrEmpty(mem.CompanyName) &&
                    !string.IsNullOrEmpty(mem.City) && !string.IsNullOrEmpty(mem.Country))
                {
                    string check = "";
                    if (!InsertOrUpdate)
                    {
                        MemberRepository.AddMember(mem);
                        check = "Insert";
                    }
                    else
                    {
                        MemberRepository.UpdateMember(mem);
                        Member = mem;
                        check = "Update";
                    }
                    d = MessageBox.Show(check + " successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (d == DialogResult.OK)
                    {
                        this.Close();
                    }
                }
                else
                {
                    d = MessageBox.Show("Please fill all the blank", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add a new member" : "Update a member");
            }
        }

        private void frmMemberDetails_Load(object sender, EventArgs e)
        {
            txtMemID.Enabled = !InsertOrUpdate;
            if (InsertOrUpdate)
            {
                txtMemID.Text = Member.MemberId.ToString();
                txtEmail.Text = Member.Email;
                txtPassword.Text = Member.Password;
                txtCompany.Text = Member.CompanyName;
                txtCity.Text = Member.City;
                txtCountry.Text = Member.Country;
            }
        }
    }
}
