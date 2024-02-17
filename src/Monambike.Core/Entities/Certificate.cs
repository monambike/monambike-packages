namespace Monambike.Core.Entities
{
    internal class Certificate
    {
        internal required string Name { get; init; }

        internal required string Organization { get; init; }

        internal DateOnly IssueDate { get; init; }

        internal DateOnly ExpirationDate { get; init; }

        internal ulong CredentialId { get; init; }

        internal string CredentialUrl { get; init; } = null!;
    }
}
