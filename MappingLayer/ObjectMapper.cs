using Nike_Shop_Management.DAL;
using Nike_Shop_Management.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nike_Shop_Management.MappingLayer
{
    // auto mapper
    class ObjectMapper
    {
        private readonly DbContext _db;
        public user_account AccountMapperToLINQ(UserAccountDTO dto)
        {
            if (dto == null)
                throw new ArgumentNullException(nameof(dto));
            return new user_account
            {
                user_username = dto.Username,
                user_password = dto.Password,
                user_gender = dto.Gender,
                user_email = dto.Email,
                user_phone_number = dto.Phone_number,
                user_address = dto.Address,
                user_first_name = dto.First_name,
                user_last_name = dto.Last_name,
                user_member_tier = dto.Member_tier,
                user_point = dto.Point,
                user_url = dto.Url,
                user_id = dto.Id
            };
        }
        public UserAccountDTO AccountMapperToEnity(user_account user)
        {
            if (user == null)
                return null;
            return new UserAccountDTO
            {
                Username = user.user_username,
                Password = user.user_password,
                Gender = user.user_gender,
                Email = user.user_email,
                Phone_number = user.user_phone_number,
                Address = user.user_address,
                First_name = user.user_first_name,
                Last_name = user.user_last_name,
                Member_tier = user.user_member_tier != null ? Int32.Parse(user.user_member_tier.ToString()) : 0,
                Point = user.user_point != null ? Int32.Parse(user.user_member_tier.ToString()) : 0,
                Url = user.user_url,
                Id = user.user_id
            };
        }
        
        

    }
}
