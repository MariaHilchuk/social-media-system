using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace SocialMediaSystem
{
    public class Entity
    {
        public Guid id { get; set; }

        public Entity()
        {
            id = Guid.NewGuid();
        }

        public Entity(Guid id)
        {
            this.id = id;
        }

        public virtual bool IsValid()
        {
            return id != Guid.Empty;
        }
        public virtual string Format()
        {
            return $"[{id}]";
        }

        public virtual void Parse(string data)
        {
        }

        public virtual string FileName => "Entity.txt";
    }

    public class User : Entity
    {
        public string? Username { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }

        public User()
        {
            Username = string.Empty;
            Email = string.Empty;
            Password = string.Empty;
        }

        public User(Guid id, string username, string EMAIL, string password) : base(id)
        {
            Username = username;
            Email = EMAIL;
            Password = password;
        }

        public new virtual bool IsValid()
        {
            if (!base.IsValid()) return false;

            if (string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(Password))
                return false;

            return true;
        }
        public override string Format()
        {
            return $"[{id}][{Username}][{Email}]";
        }

    }

    public sealed class Blogger : User
    {
        public int? FollowersCount { get; set; }

        public Blogger()
        {
            FollowersCount = 0;
        }

        public Blogger(Guid id, string username, string email, string password, int followers)
            : base(id, username, email, password)
        {
            FollowersCount = followers;
        }

        public new bool IsValid()
        {
            if (!base.IsValid()) return false;

            if (FollowersCount < 0) return false;

            return true;
        }
        public override void Parse(string data)
        {
        }
    }

    public class Gamer : User
    {
        public string? FavoriteGame { get; set; }

        public Gamer()
        {
            FavoriteGame = string.Empty;
        }

        public Gamer(Guid id, string username, string email, string password, string favorite_game)
            : base(id, username, email, password)
        {
            FavoriteGame = favorite_game;
        }


        public new bool IsValid()
        {
            if (!base.IsValid()) return false;

            if (string.IsNullOrEmpty(FavoriteGame)) return false;

            return true;
        }
        public override string Format()
        {
            return base.Format() + $"[{FavoriteGame}]";
        }
    }

    public sealed class Influencer : User
    {
        public string? Brand { get; set; }

        public Influencer()
        {
            Brand = string.Empty;
        }

        public Influencer(Guid id, string username, string email, string password, string brand)
            : base(id, username, email, password)
        {
            Brand = brand;
        }

        public new bool IsValid()
        {
            if (!base.IsValid()) return false;

            if (string.IsNullOrEmpty(Brand)) return false;

            return true;
        }
        public override string Format()
        {
            return base.Format() + $"[{Brand}]";
        }
    }

    public class Post : Entity
    {
        public User? Author { get; set; }
        public string? Description { get; set; }
        public List<User>? Views { get; set; }
        public DateTime? PublishedDate { get; set; }
        public List<User>? Likes { get; set; }

        public Post()
        {
            Author = new User();
            Description = string.Empty;
            Views = new List<User>();
            PublishedDate = null;
            Likes = new List<User>();
        }

        public Post(Guid id, User author, string description, List<User> views, DateTime published_date, List<User> likes)
            : base(id)
        {
            Author = author;
            Description = description;
            Views = views;
            PublishedDate = published_date;
            Likes = likes;
        }

        public new bool IsValid()
        {
            if (!base.IsValid()) return false;

            if (Author == null || !Author.IsValid()) return false;
            if (string.IsNullOrEmpty(Description)) return false;

            if (Views == null) Views = new List<User>();
            if (Likes == null) Likes = new List<User>();

            return true;
        }
        public override string Format()
        {
            return $"[{id}][{Author?.id}][{Description}][{PublishedDate?.ToUniversalTime()}]";
        }

        public override string FileName => "Posts.txt";
    }
    public static class FileManager
    {
        public static void Add(Entity entity)
        {
            if (entity == null)
                throw new ArgumentNullException();

            if (!entity.IsValid())
                throw new Exception("Invalid entity");

            string record = entity.Format();

            using (StreamWriter writer = new StreamWriter(entity.FileName, true))
            {
                writer.WriteLine(record);
            }
        }
    }
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());

        }
    }
}