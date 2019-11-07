using _7fotograf.Interfaces;
namespace _7fotograf.Models
{
    public class FacebookLogin : IFacebookLogin
    {
        public string UserFbId 
        {
            get;
            set;
        }
        public string UserName 
        {
            get;
            set;
        }
        public string UserEmail 
        {
            get;
            set;
        }
    }
}