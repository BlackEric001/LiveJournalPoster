using Horizon.XmlRpc.Client;
using LjPoster.Model;
using LjPoster.Crypto;

namespace LjPoster
{
    public class Poster
    {
        public LjUserInfo Auth(UserPassword username)
        {
            ILj proxy = XmlRpcProxyGen.Create<ILj>();
            var ans = proxy.Login(username);
            return ans;
        }


        public bool MakeNewPost(UserPassword user, Post post)
        {
            LjProvider provider = new LjProvider();

            GetChallengeAnswer answer = provider.GetChallenge();

            var challenge = new Challenge();
            challenge.auth_challenge = answer.challenge;
            challenge.auth_response = Md5.GetMd5Hash(answer.challenge + user.hpassword);
            challenge.username = user.username;

            post.TagList = "Картинка дня, космос";

            provider.Publish(challenge, post);

            return true;
        }

        public LjUserInfo AuthChallenge(Challenge challenge)
        {
            ILj proxy = XmlRpcProxyGen.Create<ILj>();
            var ans = proxy.LoginChallenge(challenge);
            return ans;
        }

        public GetChallengeAnswer GetChallenge()
        {
            ILj proxy = XmlRpcProxyGen.Create<ILj>();
            var ans = proxy.GetChallenge();
            return ans;
        }

    }
}
