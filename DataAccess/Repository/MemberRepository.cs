using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class MemberRepository : IMemberRepository
    {
        public Member CheckLogin(string email, string password) => MemberDAO.Instance.CheckLogin(email, password);
        public List<Member> GetMembers() => MemberDAO.Instance.GetMembers();
        public Member GetMemberById(int id) => MemberDAO.Instance.GetMemberById(id);
        public Member GetMemberByEmailAndPassword(string email, string password) => MemberDAO.Instance.GetMemberByEmailAndPassword(email, password);
        public void AddMember(Member member) => MemberDAO.Instance.AddMember(member);
        public void UpdateMember(Member member) => MemberDAO.Instance.UpdateMember(member);
        public void DeleteMember(Member member) => MemberDAO.Instance.DeleteMember(member);
    }
}
