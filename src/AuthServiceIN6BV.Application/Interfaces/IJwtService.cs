using AuthServiceIN6BV.Domain.Entities;

namespace AuthServiceIN6BV.Application.Interfaces;

public interface IJwtService
{
    string GenerateToken(User user);
    
}