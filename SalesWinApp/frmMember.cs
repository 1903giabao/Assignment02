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

namespace SalesWinApp
{
    public partial class frmMember : Form
    {
        public Member mem { get; set; }
        public string role { get; set; }
        BindingSource BindingSource;
        IMemberRepository memberRepository = new MemberRepository();

        public frmMember()
        {
            InitializeComponent();
        }

        private void ClearText()
        {
            txtMemID.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtCompany.Text = string.Empty;
            txtCity.Text = string.Empty;
            txtCountry.Text = string.Empty;
        }

        private Member GetMemberObject()
        {
            Member member = null;
            try
            {
                member = memberRepository.GetMemberById(int.Parse(txtMemID.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Member");
            }
            return member;
        }

        private void LoadMemberList()
        {
            try
            {
                var mems = memberRepository.GetMembers().Select(m => new
                {
                    m.MemberId,
                    m.Email,
                    m.Password,
                    m.CompanyName,
                    m.City,
                    m.Country
                }).ToList();

                BindingSource = new BindingSource();
                BindingSource.DataSource = mems;

                txtMemID.DataBindings.Clear();
                txtEmail.DataBindings.Clear();
                txtPassword.DataBindings.Clear();
                txtCompany.DataBindings.Clear();
                txtCity.DataBindings.Clear();
                txtCountry.DataBindings.Clear();

                txtMemID.DataBindings.Add("Text", BindingSource, "MemberId");
                txtEmail.DataBindings.Add("Text", BindingSource, "Email");
                txtPassword.DataBindings.Add("Text", BindingSource, "Password");
                txtCompany.DataBindings.Add("Text", BindingSource, "CompanyName");
                txtCity.DataBindings.Add("Text", BindingSource, "City");
                txtCountry.DataBindings.Add("Text", BindingSource, "Country");

                dgvMember.DataSource = null;
                dgvMember.DataSource = BindingSource;

                if (mems.Count() == 0)
                {
                    ClearText();
                    btnUpdate.Enabled = false;
                    btnDelete.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Member List");
            }
        }

        private void LoadMember()
        {
            try
            {
                var bindMember = new
                {
                    mem.MemberId,
                    mem.Email,
                    mem.Password,
                    mem.CompanyName,
                    mem.City,
                    mem.Country
                };
                BindingSource = new BindingSource();
                BindingSource.DataSource = bindMember;

                txtMemID.DataBindings.Clear();
                txtEmail.DataBindings.Clear();
                txtPassword.DataBindings.Clear();
                txtCompany.DataBindings.Clear();
                txtCity.DataBindings.Clear();
                txtCountry.DataBindings.Clear();

                txtMemID.DataBindings.Add("Text", BindingSource, "MemberId");
                txtEmail.DataBindings.Add("Text", BindingSource, "Email");
                txtPassword.DataBindings.Add("Text", BindingSource, "Password");
                txtCompany.DataBindings.Add("Text", BindingSource, "CompanyName");
                txtCity.DataBindings.Add("Text", BindingSource, "City");
                txtCountry.DataBindings.Add("Text", BindingSource, "Country");

                dgvMember.DataSource = null;
                dgvMember.DataSource = BindingSource;

                btnDelete.Enabled = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Member List");
            }
        }

        private void frmMember_Load(object sender, EventArgs e)
        {
            if (role.Equals("Admin"))
            {
                LoadMemberList();
            }
            else
            {
                btnDelete.Enabled = false;
                LoadMember();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //frmMain f = new frmMain();
            //f.role = role;
            //f.mem = mem;
            this.Hide();
            //f.Show();
        }

        private void frmMember_FormClosing(object sender, FormClosingEventArgs e)
        {
            //DialogResult d;
            //d = MessageBox.Show("Do you really want to exit?", "Quit", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            //if (d == DialogResult.Cancel)
            //{
            //    e.Cancel = true;
            //}
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var mem = GetMemberObject();
                DialogResult d;
                d = MessageBox.Show("Do you really want to delete this member?", "Delete Member",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (d == DialogResult.OK)
                {
                    memberRepository.DeleteMember(mem);
                }
                LoadMemberList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete member");
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            frmMemberDetails frmMemberDetails = new frmMemberDetails
            {
                Text = "Add member",
                InsertOrUpdate = false,
                MemberRepository = memberRepository
            };
            if (frmMemberDetails.ShowDialog() == DialogResult.OK)
            {
                BindingSource.Position = BindingSource.Count - 1;
            }
            if (role.Equals("Admin")) { 
                LoadMemberList();
            } 
            else
            {
                LoadMember();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmMemberDetails frmMemberDetails = new frmMemberDetails
            {
                Text = "Update member",
                InsertOrUpdate = true,
                Member = GetMemberObject(),
                MemberRepository = memberRepository
            };
            frmMemberDetails.ShowDialog();
            mem = frmMemberDetails.Member;
            if (role.Equals("Admin"))
            {
                LoadMemberList();
            }
            else
            {
                if (mem.Email != txtEmail.Text || mem.Password != txtPassword.Text)
                {
                    frmLogin f = new frmLogin();
                    f.Show();
                    this.Hide();
                }
                LoadMember();
            }
        }
    }
}
