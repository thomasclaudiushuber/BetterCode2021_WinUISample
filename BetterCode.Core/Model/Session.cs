namespace BetterCode.Core.Model;

public record Session(string Title, string Speaker, TimeOnly startTime, TimeOnly endTime);
