using GameIndustry.Models;

namespace GameIndustry.Repository
{
    public interface IRepository
    {
        public List<Game> GetAllGames();
    }
}
