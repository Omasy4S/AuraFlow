namespace AuraFlow.Application.Services
{
    public interface ITokenService
    {
        string GenerateToken(string userId);
    }
}
