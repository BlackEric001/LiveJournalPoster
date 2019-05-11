using Horizon.XmlRpc.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LjPoster.Model
{
    public class PostLj
    {
        public string username { get; set; }

        public string auth_method { get { return "challenge"; } }

        public string auth_challenge { get; set; }

        public string auth_response { get; set; }

        public int ver { get; set; }

        public string @event { get; set; }

        public string subject { get; set; }

        public string lineendings { get; set; }

        public XmlRpcStruct props { get; set; }

        public int year { get; set; }

        public int mon { get; set; }

        public int day { get; set; }

        public int hour { get; set; }

        public int min { get; set; }

        public string usejournal { get; set; }
    }
}