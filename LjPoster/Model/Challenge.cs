namespace LjPoster.Model
{
    public class Challenge
    {
        public string auth_method { get { return "challenge"; } }

        public string auth_challenge { get; set; }

        public string auth_response { get; set; }

        public string username { get; set; }

        public int ver
        {
            get
            {
                return 1;
            }
        }
    }
}