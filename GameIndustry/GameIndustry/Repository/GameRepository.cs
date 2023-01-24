using GameIndustry.Models;

namespace GameIndustry.Repository
{
    public class GameRepository : IRepository
    {
        public List<Game> GetAllGames()
        {
            var list = new List<Game>()
        {
        new Game(){ Name = "Farming Simulator 2019", Genre = "Simulator", ReleaseDate = new DateTime(2018,11,19)},
        new Game(){ Name = "Witcher", Genre = "Action/RPG", ReleaseDate = new DateTime(2015,5,18)},
        new Game(){ Name = "Destroy All Humans", Genre = "Action-Adventure", ReleaseDate = new DateTime(2007,11,19)},
        };
            return list;
        }
    }
}
