using TodoApi.Model;

namespace TodoApi
{
    public class Storage
    {
        public static readonly List<Player> playerList = new List<Player>()
        {
            new Player{ Id = 101, Name = "Ekrem", Surname = "Caglayan", Age = 22 },
            new Player{ Id = 102, Name = "Füsun", Surname = "Caglayan", Age = 47 },
            new Player{ Id = 103, Name = "Bozkurt", Surname = "Caglayan", Age = 47 },
        };

        public static readonly List<Footballer> footballerList = new List<Footballer>()
        {
            new Footballer{ Id = 105, Name = "Ekrem", Surname = "Caglayan", Age = 22, Position = Enum.FootballerPosition.Defending, ClubId = 101 },
            new Footballer{ Id = 106, Name = "Ekrem2", Surname = "Caglayan2", Age = 23, Position = Enum.FootballerPosition.Defending, ClubId = 101 },
            new Footballer{ Id = 102, Name = "Füsun", Surname = "Caglayan", Age = 47, Position = Enum.FootballerPosition.Attacking, ClubId = 102 },
            new Footballer{ Id = 103, Name = "Bozkurt", Surname = "Caglayan", Age = 47, Position = Enum.FootballerPosition.Midfielder, ClubId = 103 },
        };

        public static readonly List<Basketballer> basketballerList = new List<Basketballer>()
        {
            new Basketballer{ Id = 101, Name = "Ekrem", Surname = "Caglayan", Age = 22, Position = Enum.BasketballerPosition.SmallForward, ClubId = 101 },
            new Basketballer{ Id = 102, Name = "Füsun", Surname = "Caglayan", Age = 47, Position = Enum.BasketballerPosition.PowerForward, ClubId = 102 },
            new Basketballer{ Id = 103, Name = "Bozkurt", Surname = "Caglayan", Age = 47, Position = Enum.BasketballerPosition.ShootingGuard, ClubId = 103 },
        };

        public static readonly List<Club> clubList = new List<Club>()
        {
            new Club{ Id = 101, Name = "Fenerbahce", Year = 22 },
            new Club{ Id = 102, Name = "Galatasaray", Year = 47 },
            new Club{ Id = 103, Name = "Besiktas", Year = 47 },
        };
    }
}