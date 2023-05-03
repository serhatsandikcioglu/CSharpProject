using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace VotingApp
{
    public class Category
    {
        public string Name { get; set; }
        public int VoteCount { get; set; }

        public Category(string categories,int voteCount)
        {
            Name = categories;
            VoteCount = voteCount;
        }
    }
}
