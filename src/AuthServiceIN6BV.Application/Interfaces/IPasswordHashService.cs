namespace AuthServiceIN6BV.Application.Interfaces;

public interface IPasswordHashService
{
    
    String HashPassword(string password);
    bool VerifyPassword(string password, string hashedPassword);
}