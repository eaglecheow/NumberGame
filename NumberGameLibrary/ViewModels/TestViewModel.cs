using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NumberGameLibrary.Models;
using NumberGameLibrary.Services;

namespace NumberGameLibrary.ViewModels
{
    public class TestViewModel
    {
        public ObservableCollection<Game> GameCollection { get; private set; }

        public TestViewModel()
        {
            Debug.WriteLine("TestViewModel Constructor Called");
            SetDefaultValue();
        }
        
        private void SetDefaultValue()
        {
            Debug.WriteLine("Setting Default Values");
            var gameCollection =  new ObservableCollection<Game>()
            {
                new Game(){PlayerName = "Eagle", GameOption = Game.GameType.GuessingGame, Score = 21, TimeStamp = DateTime.Parse("2017-12-12")},
                new Game(){PlayerName = "John", GameOption = Game.GameType.Point21, Score = 33, TimeStamp = DateTime.Parse("2018-1-5")},
                new Game(){PlayerName = "Bobby", GameOption = Game.GameType.GuessingGame, Score = 55, TimeStamp = DateTime.Parse("2018-3-5")}
            };
            GameCollection = gameCollection;
        }
    }
}
