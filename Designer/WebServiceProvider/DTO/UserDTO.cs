using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Design.WebServiceProvider.DTO
{
    // Login Request Data
    public class LoginRequest
    {
        [JsonProperty("userName")]
        public string UserName { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("deviceID")]
        public string DeviceID { get; set; }

        [JsonProperty("osName")]
        public string OsName { get; set; }

        [JsonProperty("osVersion")]
        public string OsVersion { get; set; }

        [JsonProperty("modelName")]
        public string ModelName { get; set; }

        [JsonProperty("devicetoken")]
        public string DeviceToken { get; set; }
    }

    // Login Request Data
    public class LoginResponse : ResponseBase
    {
        [JsonProperty("access_token")]
        public string AccessToken { get; set; }

        [JsonProperty("token_type")]
        public string TokenType { get; set; }

        [JsonProperty("expires_in")]

        public int ExpiresIn { get; set; }

        [JsonProperty("userName")]
        public string UserName { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("UserID")]
        public string UserID { get; set; }

        [JsonProperty("roleID")]
        public string RoleID { get; set; }

        [JsonProperty("roleName")]
        public string RoleName { get; set; }

        [JsonProperty("deviceID")]
        public string DeviceID { get; set; }

        [JsonProperty("icID")]
        public string ICID { get; set; }

        [JsonProperty("sbgID")]
        public string SBGID { get; set; }

        [JsonProperty("buID")]
        public string BUID { get; set; }

        [JsonProperty("clusterIDtype")]
        public string ClusterID { get; set; }

        [JsonProperty("projectID")]
        public string ProjectID { get; set; }

        [JsonProperty("ProjectName")]
        public string ProjectName { get; set; }

        [JsonProperty("isChangePassword")]
        public string IsChangePassword { get; set; }

        [JsonProperty(".issued")]
        public string Issued { get; set; }

        [JsonProperty(".expires")]
        public string Expires { get; set; }

        [JsonProperty("mobileNo")]
        public string MobileNo { get; set; }

        [JsonProperty("emailID")]
        public string EmailID { get; set; }

        [JsonProperty("projectCode")]
        public string ProjectCode { get; set; }

    }

    // Forgot Password Request Data
    public class ForgotPasswordRequest
    {
        [JsonProperty("loginID")]
        public string LoginID { get; set; }
    }

    // Change Password Request Data
    public class ChangePasswordRequest
    {
        [JsonProperty("oldPassword")]
        public string OldPassword { get; set; }

        [JsonProperty("newPassword")]
        public string NewPassword { get; set; }
    }

}
