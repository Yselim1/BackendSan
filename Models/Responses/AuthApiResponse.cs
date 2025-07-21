using System;
using BackendSan.Models.Common;
using BackendSan.Models.Responses;

namespace BackendSan.Models.Response
{
    public class AuthApiResponse
    {
        public AuthResponseBody Body { get; set; }
        public HeaderDto Header { get; set; }
    }

    public class AuthResponseBody
    {
        public string Token { get; set; }
        public string ExpiresOn { get; set; }
        public int TokenId { get; set; }
        public UserInfo UserInfo { get; set; } 
        public bool LoggedInWithMasterKey { get; set; }
    }
    
    
    public class UserInfo
    {
    }

    public class AuthTokenInfo 
    {
        public string AccessToken { get; set; }
        public string ExpiresOn { get; set; }
    }
}