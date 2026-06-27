using GoalData.Domain.Models;

namespace GoalData.Application.Interfaces;

public interface ICompetitionRepository
{
    Task<Competition> GetByCodeAsync(string code);
    Task<IEnumerable<Competition>> GetAllAsync();
}
