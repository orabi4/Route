namespace TaskSession_P4.Interfaces;

public interface IAuthenticationService
{
   public bool AuthenticateUser(string username,string password);
   public bool AuthorizeUser(string username,string role);
}