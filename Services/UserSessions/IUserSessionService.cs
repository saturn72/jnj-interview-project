namespace interview_challenge.Services.UserSessions;

public interface IUserSessionService
{
    Task<bool> HasActiveSession(string phoneNumber);
}
