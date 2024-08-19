using Nike_Shop_Management.DTO;
using Nike_Shop_Management.MappingLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nike_Shop_Management.DAL
{
    class UserAccountRepository
    {
        private readonly DbContext _db;

        public UserAccountRepository(DbContext db)
        {
            _db = db;
        }
        public void Save(UserAccountDTO user)
        {

            // logic ở đây
            // if(user)
            ObjectMapper objectMapper = new ObjectMapper();
            _db.user_accounts.InsertOnSubmit(objectMapper.AccountMapperToLINQ(user));
        }
        public UserAccountDTO GetAccount(string email, string password)
        {
            ObjectMapper objectMapper = new ObjectMapper();
            return objectMapper.AccountMapperToEnity(_db.user_accounts.Where(o => o.user_email==email && o.user_password == password).FirstOrDefault());
        }
        public List<UserAccountDTO> GetAccounts()
        {
            ObjectMapper objectMapper = new ObjectMapper();
            return _db.user_accounts
               .Select(user => objectMapper.AccountMapperToEnity(user))
               .ToList();
        }

        //public int EditAccount(int id)
        //{

        //}
    }
}
