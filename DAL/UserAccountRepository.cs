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
        private String heelo;
        ObjectMapper objectMapper = new ObjectMapper();
        public UserAccountRepository(DbContext db)
        {
            _db = db;
        }
        public void Save(UserAccountDTO user)
        {
            // logic ở đây
            // if(user)
            _db.user_accounts.InsertOnSubmit(objectMapper.AccountMapperToLINQ(user));
        }
        public UserAccountDTO GetAccount(string email, string password)
        {
            return objectMapper.AccountMapperToEnity(_db.user_accounts.Where(o => o.user_email == email && o.user_password == password).FirstOrDefault());
        }
        public List<UserAccountDTO> GetAccounts()
        {
            return _db.user_accounts
               .Select(user => objectMapper.AccountMapperToEnity(user))
               .ToList();
        }
        public UserAccountDTO GetUserByID(int id)
        {
            return objectMapper.AccountMapperToEnity(_db.user_accounts.Where(user => user.user_id == id).FirstOrDefault());
        }

        public int EditUser(UserAccountDTO user)
        {
            // Retrieve the existing user from the database
            var existingUser = _db.user_accounts.FirstOrDefault(u => u.user_id == user.Id);

            if (existingUser != null)
            {
                existingUser.user_first_name = user.Username;
                existingUser.user_last_name = user.Email;
                existingUser.user_password = user.Password;
                existingUser.user_point = user.Point;
                existingUser.user_url = user.Url;
                existingUser.user_member_tier = user.Member_tier;
                existingUser.user_gender = user.Gender;
                existingUser.user_address = user.Address;
                //existingUser.user_phone_number = user.Phone_number;

                return _db.SubmitChanges();
            }
            return 0;
        }
    }
}
