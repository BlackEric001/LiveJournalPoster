
namespace LjPoster.Model
{
    public class GetChallengeAnswer
    {
        public string auth_scheme { get; set; }

        public string challenge { get; set; }

        public int expire_time { get; set; }

        public int server_time { get; set; }
    }
}