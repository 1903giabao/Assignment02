using BusinessObjects.Models;

namespace DataAccess
{
    public class MemberDAO
    {
        private static MemberDAO instance = null;
        private static object lockObject = new object();
        private MemberDAO() { }
        public static MemberDAO Instance 
        { 
            get
            {
                if (instance == null)
                {
                    instance = new MemberDAO();
                }
                return instance;
            }
        }
        public Member CheckLogin(string email, string password)
        {
            using var db = new SaleManagementContext();
            return db.Members.SingleOrDefault(m => m.Email.Equals(email) && m.Password.Equals(password));
        }
        public List<Member> GetMembers()
        {
            using var db = new SaleManagementContext();
            return db.Members.ToList();
        }
        public Member GetMemberById(int id)
        {
            var tmp = GetMembers()
                .SingleOrDefault(m => m.MemberId == id);
            return tmp;
        }
        public Member GetMemberByEmailAndPassword(string email, string password)
        {
            var tmp = GetMembers()
                .SingleOrDefault(m => m.Email.Equals(email) && m.Password.Equals(password));
            return tmp;
        }
        public void AddMember (Member member)
        {
            using var db = new SaleManagementContext();
            db.Members.Add(member);
            db.SaveChanges();
        }
        public void UpdateMember (Member member)
        {
            using var db = new SaleManagementContext();
            db.Members.Update(member);
            db.SaveChanges();
        }
        public void DeleteMember (Member member)
        {
            using var db = new SaleManagementContext();
            var memberDel = db.Members.SingleOrDefault(m => m.MemberId == member.MemberId);
            db.Members.Remove(memberDel);
            db.SaveChanges();
        }
    }
}