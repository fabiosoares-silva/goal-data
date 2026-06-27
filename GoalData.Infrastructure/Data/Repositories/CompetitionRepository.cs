using GoalData.Application.Interfaces;
using GoalData.Domain.Models;

namespace GoalData.Infrastructure.Data.Repositories;

public class CompetitionRepository : ICompetitionRepository
{
    private readonly string _connectionString;

    public CompetitionRepository(string connectionString)
    {
        _connectionString = connectionString;
    }

    public Task<IEnumerable<Competition>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Competition> GetByCodeAsync(string code)
    {
        throw new NotImplementedException();
    }
}
