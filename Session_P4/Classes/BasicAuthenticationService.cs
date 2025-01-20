using TaskSession_P4.Interfaces;

namespace TaskSession_P4.Classes;

public class BasicAuthenticationService:IAuthenticationService
{
    public bool AuthenticateUser(string username, string password)
    {
       if(username == "adel" && password == "kassem123") return true;
       return false;
    }

    public bool AuthorizeUser(string username, string role)
    {
        if(username == "adel" && (role == "admin"||role=="user")) return true;
        return false;
    }
}