using GameIndustry.Models;
using Microsoft.AspNetCore.Components;

namespace GameIndustry.Pages
{
    public partial class Index
    {
        [Inject] GameIndustry.Repository.IRepository repository { get; set; }

        private List<Game> games = new List<Game>();
        /// <summary>
        /// Метод отвечает за данные до отрисовки
        /// </summary>
        /// <returns></returns>
        protected async override Task OnInitializedAsync()
        {
            await Task.Delay(2000);
            games = repository.GetAllGames();

            rnd = new Random(DateTime.Now.Millisecond);
            oneGameToShow = games[rnd.Next(0, games.Count)];
        }

        private Random rnd;
        private Game oneGameToShow;

        private void ShowNewGame()
        {
            oneGameToShow = SwitchGame();
        }

        private Game SwitchGame()
        {
            Game tempGame;
            if (games.Count >= 2)
            {
                int iterator = rnd.Next(0, games.Count);
                tempGame = games[iterator];
            }
            else if (games.Count == 1)
            {
                tempGame = games[0];
            }
            else
            {
                return new Game() { Name = "No items in array!", ReleaseDate = DateTime.Now };
            }
            return tempGame;
        }
    }
}
