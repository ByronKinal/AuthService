namespace AuthServiceIN6BV.Application.Interfaces;

public interface IPasswordHashService
{
    
    String hashPassword(string password);
    bool verifyPassword(string password, string hashedPassword);
}