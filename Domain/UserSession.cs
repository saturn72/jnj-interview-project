namespace interview_challenge.Domain;

public class UserSession
{
    public required string PhoneNumber { get; init; }
    public required ulong SessionExpiresOnUtc { get; init; }
}
