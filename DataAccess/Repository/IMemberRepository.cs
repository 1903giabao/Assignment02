using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IMemberRepository
    {
        Member CheckLogin(string email, string password);
        List<Member> GetMembers();
        Member GetMemberById(int id);
        Member GetMemberByEmailAndPassword(string email, string password);
        void AddMember(Member member);
        void UpdateMember(Member member);
        void DeleteMember(Member member);
    }
}
