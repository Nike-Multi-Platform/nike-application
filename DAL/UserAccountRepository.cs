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
        public List<UserAccountDTO> GetListAccounts()
        {
            return _db.user_accounts
               .Select(user => objectMapper.AccountMapperToEnity(user))
               .ToList();
        }
        public UserAccountDTO GetUser(int id)
        {
            return objectMapper.AccountMapperToEnity(_db.user_accounts.Where(user => user.user_id == id).FirstOrDefault());
        }

        public int Edit(UserAccountDTO user)
        {
            try
            {
                var existingUser = _db.user_accounts.FirstOrDefault(u => u.user_id == user.Id);
                if (existingUser != null)
                {
                    existingUser.user_first_name = user.Username;
                    existingUser.user_last_name = user.Email;
                    existingUser.user_password = user.Password;
                    existingUser.user_point = user.Point;
                    existingUser.user_member_tier = user.Member_tier;
                    existingUser.user_gender = user.Gender;
                    existingUser.user_address = user.Address;
                    existingUser.user_url = user.Url;
                    _db.SubmitChanges();
                    return 1;
                }
                return 0;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public int Delete(int id)
        {
            try
            {
                var userTemp = _db.user_accounts.Where(o => o.user_id == id).FirstOrDefault();
                _db.user_accounts.DeleteOnSubmit(userTemp);
                _db.SubmitChanges();
                return 1;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public List<UserAccountDTO> Search(string inputSearch)
        {
            try
            {
                bool isNumericSearch = int.TryParse(inputSearch, out int numericSearch);
                List<UserAccountDTO> result = _db.user_accounts
                    .Where(user => user.user_username.Contains(inputSearch) ||
                                            user.user_email.Contains(inputSearch) ||
                                            user.user_phone_number.Contains(inputSearch) ||
                                            user.user_address.Contains(inputSearch) ||
                                            user.user_first_name.Contains(inputSearch) ||
                                            user.user_last_name.Contains(inputSearch) ||
                                            (isNumericSearch && user.user_member_tier == numericSearch) ||
                                            (isNumericSearch && user.user_point == numericSearch)
                                            ).ToList().Select(o=>objectMapper.AccountMapperToEnity(o)).ToList();

                if (result != null)
                {
                    return result;
                }

                return null;
            }
            catch (Exception)
            {
                return null; 
            }
        }


    }
}
