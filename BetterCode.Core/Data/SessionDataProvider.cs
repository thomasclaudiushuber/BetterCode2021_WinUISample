using BetterCode.Core.Model;

namespace BetterCode.Core.Data;

public class SessionDataProvider : ISessionDataProvider
{
    public async Task<IEnumerable<Session>> GetSessionsAsync()
    {
        await Task.Delay(100); // Simulate some server work;

        return new List<Session> {
          new(".NET 6: Neuigkeiten bei den Anwendungsarten und im SDK", "Dr. Holger Schwichtenberg", new TimeOnly(9, 15), new TimeOnly(10, 0)),
          new("Neuigkeiten in C# 10",    "Rainer Stropek", new TimeOnly(10, 15), new TimeOnly(11, 0)),
          new("Neuigkeiten von ASP.NET Core 6.0 und Blazor 6", "Christian Wenz", new TimeOnly(10, 15), new TimeOnly(11, 0)),
          new(".NET 6: Neuigkeiten bei den .NET-Basisklassen", "Dr. Holger Schwichtenberg", new TimeOnly(12, 15), new TimeOnly(13, 0)),
          new("WinUI 3 und das Windows App SDK: Moderne Desktop-Apps für Windows 10 und 11 entwickeln", "Thomas Claudius Huber", new TimeOnly(14, 0), new TimeOnly(14, 45)),
          new("Cross-Plattform-Entwicklung mit .NET Multi-Platform App UI", "André Krämer", new TimeOnly(15, 0), new TimeOnly(15, 45)),
          new("Migration von .NET Framework 4.8 zu .NET 6", "Dr. Holger Schwichtenberg", new TimeOnly(16, 0), new TimeOnly(16, 45)),
          new("Frage-/Diskussionsrunde zu .NET 6", "Alexander Neumann (Moderation)", new TimeOnly(17, 0), new TimeOnly(17, 45)),
        };
    }
}
