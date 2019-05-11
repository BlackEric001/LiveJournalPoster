using Horizon.XmlRpc.Core;

namespace LjPoster.Model
{

    public class PostLjAnswer
    {
        public int anum { get; set; }

        public int itemid { get; set; }

        [XmlRpcMissingMapping(MappingAction.Ignore)]
        public string url { get; set; }
    }
}
