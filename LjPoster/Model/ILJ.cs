using Horizon.XmlRpc.Client;
using Horizon.XmlRpc.Core;

namespace LjPoster.Model
{
    [XmlRpcUrl("http://www.livejournal.com/interface/xmlrpc")]
    public interface ILj : IXmlRpcProxy
    {
        [XmlRpcMethod("LJ.XMLRPC.login")]
        LjUserInfo Login(UserPassword user);

        [XmlRpcMethod("LJ.XMLRPC.login")]
        LjUserInfo LoginChallenge(Challenge challenge);

        [XmlRpcMethod("LJ.XMLRPC.postevent")]
        PostLjAnswer Post(PostLj post);

        [XmlRpcMethod("LJ.XMLRPC.getchallenge")]
        GetChallengeAnswer GetChallenge();
    }
}
