using System;
using System.Collections.Generic;
using System.Text;

namespace LjPoster.Model
{
    public class UserPassword
    {
        public string username { get; set; }

        public string hpassword { get; set; }

        public int ver
        {
            get
            {
                return 1;
            }
        }
    }
}
