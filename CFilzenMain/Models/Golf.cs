namespace CFilzenMain.Models
{
    public class Golf
    {
        public string Course { get; set; }
        public int Yardage { get; set; }
        public int HolesPlayed { get; set; }
        public int Score { get; set; }
    }

    public class Game
    {
        public int HoleNumber { get; set; }
        public int HoleYardage { get; set; }
        public int HoleShots { get; set; }
    }

    public class Shot
    {
        public int Count { get; set; }
        public string Club { get; set; }
        public int ShotYardage { get; set; }
        public Direction Direction { get; set; }

    }

    public enum Direction
    {
        Right = 1,
        Left = 2,
        Center = 3
    };
}
