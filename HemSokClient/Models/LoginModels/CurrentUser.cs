﻿/*
 Author: Marcus Karlsson
 */
namespace HemSokClient.Models.LoginModels
{
    public class CurrentUser
    {
        public string? AgentId { get; set; }
        public LoginResponse loginResponse { get; set; }
        public string? Role { get; set; }
        public string? AgencyId { get; set; }
    }
}
