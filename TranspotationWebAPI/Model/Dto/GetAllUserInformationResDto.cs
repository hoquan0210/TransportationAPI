﻿namespace TranspotationWebAPI.Model.Dto
{
    public class GetAllUserInformationResDto
    {
        public int accountId { get; set; }
        public String password { get; set; }
        public int roleId { get; set; }
        public String phoneNumber { get; set; }
        public String email { get; set; }
        public String name { get; set; }
        public String token { get; set; }
    }
}