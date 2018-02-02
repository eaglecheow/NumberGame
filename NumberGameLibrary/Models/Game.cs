using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGameLibrary.Models
{
    public class Game : BaseModel
    {
        public enum GameType
        {
            GuessingGame, CalculateGame, Point21
        }

        #region PrivateFields

        private GameType _gameOption;
        private string _playerName;
        private int _score;
        private DateTime _timeStamp;

        #endregion

        #region PublicFields

        public GameType GameOption
        {
            get => _gameOption;
            set => SetProperty(ref _gameOption, value);
        }

        public string PlayerName
        {
            get => _playerName;
            set => SetProperty(ref _playerName, value);
        }

        public int Score
        {
            get => _score;
            set => SetProperty(ref _score, value);
        }

        public DateTime TimeStamp
        {
            get => _timeStamp;
            set => SetProperty(ref _timeStamp, value);
        }

        #endregion
    }
}
