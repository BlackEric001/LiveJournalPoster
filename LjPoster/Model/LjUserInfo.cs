using Horizon.XmlRpc.Core;

namespace LjPoster.Model
{
    public class LjUserInfo
    {
        public int userid { get; set; }

        [XmlRpcMissingMapping(MappingAction.Ignore)]
        public string message { get; set; }

        public string fullname { get; set; }

        public FriendgroupLj[] friendgroups { get; set; }

        public string[] usejournals { get; set; }

    }
}
