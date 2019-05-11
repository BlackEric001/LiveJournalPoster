using Horizon.XmlRpc.Client;
using LjPoster.Model;
using System;
using System.Text;

namespace LjPoster
{
    public class LjProvider
    {
        public LjUserInfo Auth(UserPassword username)
        {
            ILj proxy = XmlRpcProxyGen.Create<ILj>();
            var ans = proxy.Login(username);
            return ans;
        }

        public PostLjAnswer Publish(Challenge challenge, Post message, string ljgroup = null)
        {
            ILj proxy = XmlRpcProxyGen.Create<ILj>();
            var post = new PostLj();
            post.username = challenge.username;
            post.auth_response = challenge.auth_response;
            post.auth_challenge = challenge.auth_challenge;
            post.ver = challenge.ver;
            post.@event = message.Content;
            post.subject = message.Title;
            post.lineendings = "pc";

            post.props = new Horizon.XmlRpc.Core.XmlRpcStruct();
            post.props.Add("taglist", message.TagList);

            post.year = DateTime.Now.Year;
            post.mon = DateTime.Now.Month;
            post.day = DateTime.Now.Day;
            post.hour = DateTime.Now.Hour;
            post.min = DateTime.Now.Minute;
            if (!string.IsNullOrWhiteSpace(ljgroup))
            {
                post.usejournal = ljgroup;
            }
            else
            {
                post.usejournal = challenge.username;
            }
            return proxy.Post(post);
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

        private string GetBase64String(string data)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(data);
            return Convert.ToBase64String(bytes);
        }
    }
}
