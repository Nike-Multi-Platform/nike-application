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

        public void SaveAccount(UserAccountDTO user)
        {
            // logic here! nha
            _accountRepository.Save(user);
        }

        public UserAccountDTO GetAccount(string mail, string password)
        {
            return _accountRepository.GetAccount(mail,password);
        }
    }
}
