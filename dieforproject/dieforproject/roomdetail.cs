using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace dieforproject
{
    public class roomdetail
    {
        private string roomId;
        private int numberOfPlayer;
        private string mode;
        private int numberOfRound;
        private int timePerRound;
        private int numberOfReady;
        private List<Player> playerList;

        public roomdetail(string roomId = "", int numberOfPlayer = 3, string mode = "", int numberOfRound = 3, int timePerRound = 1, int numberOfReady = 0, List<Player> playerList = null)
        {
            this.roomId = roomId;
            this.numberOfPlayer = numberOfPlayer;
            this.numberOfRound = numberOfRound;
            this.timePerRound = timePerRound;
            this.mode = mode;
            this.numberOfReady = numberOfReady;
            this.playerList = playerList;
        }
        public string RoomId
        {
            get { return roomId; }
            set { roomId = value; }
        }
        public int NumberOfPlayer
        {
            get { return numberOfPlayer; }
            set { numberOfPlayer = value; }
        }
        public string Mode
        {
            get { return mode; }
            set { mode = value; }
        }
        public int NumberOfRound
        {
            get { return numberOfRound; }
            set { numberOfRound = value; }
        }
        public int TimePerRound
        {
            get { return timePerRound; }
            set { timePerRound = value; }
        }
        public int NumberOfReady
        {
            set { numberOfReady = value; }
            get { return numberOfReady; }
        }
        public List<Player> PlayerList
        {
            set { playerList = value; }
            get { return playerList; }
        }
    }
}
