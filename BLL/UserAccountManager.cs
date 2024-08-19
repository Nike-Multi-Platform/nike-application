using Nike_Shop_Management.DAL;
using Nike_Shop_Management.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nike_Shop_Management.BLL
{
    class UserAccountManager
    {
        private readonly UserAccountRepository _accountRepository;

        public UserAccountManager(UserAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        public void InsertUser(UserAccountDTO user)
        {
            // logic here!
            _accountRepository.Save(user);
        }

        // get account for auth
        public UserAccountDTO GetAccount(string mail, string password)
        {
            // hash here! update sau
            return _accountRepository.GetAccount(mail,password);
        }
        // get list users
        public List<UserAccountDTO> GetUserAccounts()
        {
            return _accountRepository.GetListAccounts();
        }

        // get user by id
        public UserAccountDTO GetUserByID(int id)
        {
            return _accountRepository.GetUser(id);
        }
        // edit user
        // result: 1 - successfull
        // result: 0 - failed
        // result: -1 - error logic
        public int EditUser(UserAccountDTO user)
        {
            return _accountRepository.Edit(user);
        }
        // delete user
        // result: 1 - successfull
        // result: 0 - failed
        public int DeleleUser(int id)
        {
            return _accountRepository.Delete(id);
        }
        // search - input
        public List<UserAccountDTO> SearchUser(string inputSearch)
        {       
            return _accountRepository.Search(inputSearch);
        }

    }
}
