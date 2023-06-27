using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dieforproject
{
    public class Player
    {
        private string playerId;
        private string playerName;
        private string roomId;
        private int point;
        private string mode;
        private bool isReady;

        public Player(string playerId = "", string playerName = "", string roomId = "", int point = 0, string mode = "", bool isReady = false)
        {
            this.playerId = playerName;
            this.playerName = playerId;
            this.roomId = roomId;
            this.point = point;
            this.mode = mode;
        }
        public string PlayerId
        {
            get { return playerId; }
            set { playerId = value; }
        }
        public string PlayerName
        {
            get { return playerName; }
            set { playerName = value; }
        }
        public string RoomId
        {
            get { return roomId; }
            set { roomId = value; }
        }
        public int Point
        {
            get { return point; }
            set { point = value; }
        }
        public string Mode
        {
            get { return mode; }
            set { mode = value; }
        }
        public bool IsReady
        {
            set { isReady = value; }
            get { return isReady; }
        }
    }
}
