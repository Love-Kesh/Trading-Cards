using System;
using System.Drawing;

namespace A3
{
    public class Player
    {
        public string Name { get; set; }
        public string Team { get; set; }
        public double Rating { get; set; }
        public double Assists { get; set; }
        public string Position { get; set; }
        public double PointsPerGame { get; set; }
        public string Photo { get; set; }
        public Color TeamColor { get; set; } // Field to set colors for teams, so that new teams can have custom colors
    }

    public class Players
    {
        public List<Player> player { get; set; }

        public Players()
        {
            player = new List<Player>();
            playerData();
        }

        public void playerData()
        {
            // Dictionary for mapping teams to colors
            Dictionary<string, Color> teamColors = new Dictionary<string, Color>
            {
                { "Paris Saint-Germain", Color.LightCoral },
                { "Manchester United", Color.LightBlue },
                { "Liverpool", Color.LightGreen },
                { "Manchester City", Color.LightCyan },
                { "Real Madrid", Color.White },
                { "Bayern Munich", Color.LightSalmon }
            };

            player.Add(new Player
            {
                Name = "Lionel Messi",
                Team = "Paris Saint-Germain",
                Rating = 92.5,
                Assists = 12,
                Position = "Forward",
                PointsPerGame = 30.5,
                Photo = $"..\\..\\..\\Images\\Lionel Messi.jpg",
                TeamColor = teamColors["Paris Saint-Germain"] // Use team names as key for dictionary to access the color for that team
            });

            player.Add(new Player
            {
                Name = "Cristiano Ronaldo",
                Team = "Manchester United",
                Rating = 91.0,
                Assists = 10,
                Position = "Forward",
                PointsPerGame = 28.3,
                Photo = $"..\\..\\..\\Images\\Cristiano Ronaldo.jpg",
                TeamColor = teamColors["Manchester United"]
            });

            player.Add(new Player
            {
                Name = "Neymar Jr.",
                Team = "Paris Saint-Germain",
                Rating = 88.0,
                Assists = 9,
                Position = "Winger",
                PointsPerGame = 24.0,
                Photo = $"..\\..\\..\\Images\\Neymar Jr.jpg",
                TeamColor = teamColors["Paris Saint-Germain"]
            });

            player.Add(new Player
            {
                Name = "Kylian Mbappé",
                Team = "Paris Saint-Germain",
                Rating = 89.5,
                Assists = 8,
                Position = "Forward",
                PointsPerGame = 27.5,
                Photo = $"..\\..\\..\\Images\\Kylian Mbappé.jpg",
                TeamColor = teamColors["Paris Saint-Germain"]
            });

            player.Add(new Player
            {
                Name = "Kevin De Bruyne",
                Team = "Manchester City",
                Rating = 89.5,
                Assists = 12,
                Position = "Midfielder",
                PointsPerGame = 15.0,
                Photo = $"..\\..\\..\\Images\\Kevin De Bruyne.jpg",
                TeamColor = teamColors["Manchester City"]
            });

            player.Add(new Player
            {
                Name = "Virgil van Dijk",
                Team = "Liverpool",
                Rating = 87.5,
                Assists = 2,
                Position = "Defender",
                PointsPerGame = 5.0,
                Photo = $"..\\..\\..\\Images\\Virgil van Dijk.jpg",
                TeamColor = teamColors["Liverpool"]
            });

            player.Add(new Player
            {
                Name = "Sergio Ramos",
                Team = "Paris Saint-Germain",
                Rating = 85.5,
                Assists = 3,
                Position = "Defender",
                PointsPerGame = 3.0,
                Photo = $"..\\..\\..\\Images\\Sergio Ramos.jpg",
                TeamColor = teamColors["Paris Saint-Germain"]
            });

            player.Add(new Player
            {
                Name = "Mohamed Salah",
                Team = "Liverpool",
                Rating = 88.5,
                Assists = 8,
                Position = "Winger",
                PointsPerGame = 26.0,
                Photo = $"..\\..\\..\\Images\\Mohamed Salah.jpg",
                TeamColor = teamColors["Liverpool"]
            });

            player.Add(new Player
            {
                Name = "Luka Modrić",
                Team = "Real Madrid",
                Rating = 87.0,
                Assists = 6,
                Position = "Midfielder",
                PointsPerGame = 15.0,
                Photo = $"..\\..\\..\\Images\\Luka Modrić.jpg",
                TeamColor = teamColors["Real Madrid"]
            });

            player.Add(new Player
            {
                Name = "Robert Lewandowski",
                Team = "Bayern Munich",
                Rating = 91.0,
                Assists = 7,
                Position = "Striker",
                PointsPerGame = 34.0,
                Photo = $"..\\..\\..\\Images\\Robert Lewandowski.png",
                TeamColor = teamColors["Bayern Munich"]
            });
        }
    }
}
