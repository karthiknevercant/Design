using System;
using Xamarin.Essentials;

namespace Design.Session
{
    // For Reducing Code Using Xamarin.Essential
    public class SessionHandler
    {
        // Keys 
        public const string USERNAME_KEY = "Username";
        public const string PASSWORD_KEY = "Password";
        public const string USER_ID_KEY = "User ID";
        public const string USER_TOKEN = "User Token";

        private static SessionHandler sessionHandler2;

        // SingleTon 
        public static SessionHandler GetInstance()
        {
            if (sessionHandler2 == null)
            {
                sessionHandler2 = new SessionHandler();
            }
            return sessionHandler2;
        }

        // Store Username
        public void PutUsername(string username)
        {
            Preferences.Set(USERNAME_KEY, username);
        }

        // Retrive Username
        public string GetUsername()
        {
            return Preferences.Get(USERNAME_KEY, string.Empty);
        }


        // Store Password
        public void PutPassword(string password)
        {
            Preferences.Set(PASSWORD_KEY, password);
        }

        // Retrive UserID
        public string GetUserID()
        {
            return Preferences.Get(PASSWORD_KEY, string.Empty);
        }

        // Store UserID
        public void PutUserID(string userId)
        {
            Preferences.Set(USER_ID_KEY, userId);
        }

        // Retrive Password
        public string GetPassword()
        {
            return Preferences.Get(PASSWORD_KEY, string.Empty);
        }


        // Store User Login Token
        public void PutToken(string token)
        {
            Preferences.Set(USER_TOKEN, token);
        }

        // Retrive User Login Token
        public string GetToken()
        {
            return Preferences.Get(USER_TOKEN, string.Empty);
        }

        // Delete User Login Token
        public void DeleteToken()
        {
            Preferences.Remove(USER_TOKEN);
        }

        // Clear Local Session Data
        public void ClearAll()
        {
            Preferences.Clear();
        }
    }
}
