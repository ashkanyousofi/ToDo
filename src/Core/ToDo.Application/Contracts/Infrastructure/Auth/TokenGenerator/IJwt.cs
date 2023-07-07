
namespace ToDo.Application.Contracts.Infrastructure.Auth.TokenGenerator
{
    public interface IJwt
    {
        Task<string> GenerateToken(LoginDto loginDto);
    }
}
