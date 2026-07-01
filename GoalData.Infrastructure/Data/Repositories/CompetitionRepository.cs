using GoalData.Application.Interfaces;
using GoalData.Domain.Models;
using Microsoft.Data.SqlClient;

namespace GoalData.Infrastructure.Data.Repositories;

public class CompetitionRepository : ICompetitionRepository
{
    private readonly string _connectionString;

    public CompetitionRepository(string connectionString)
    {
        _connectionString = connectionString;
    }

    public async Task<IEnumerable<Competition>> GetAllAsync()
    {
        var competitions = new List<Competition>();

        using var connection = new SqlConnection(_connectionString);
        await connection.OpenAsync();

        var command = new SqlCommand("SELECT Id, Name, Code, Type, Emblem, LastUpdated FROM Competitions", connection);
        var reader = await command.ExecuteReaderAsync();

        while (await reader.ReadAsync())
        {
            competitions.Add(new Competition
            {
                Id = reader.GetInt32(0),
                Name = reader.GetString(1),
                Code = reader.GetString(2),
                Type = reader.GetString(3),
                Emblem = reader.GetString(4),
                LastUpdate = reader.GetString(5)
            });
        }

        return competitions;
    }

    public Task<Competition> GetByCodeAsync(string code)
    {
        throw new NotImplementedException();
    }
}
