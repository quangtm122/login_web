using LoginMvc;

namespace LoginWeb.Models
{
    public interface IAccountModel
    {
        User CheckLogin(string userName, string passWord);
    }
}