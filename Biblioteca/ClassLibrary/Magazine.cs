using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Magazine : Document
    {
        
        public int IssueNumber { get; set; }

        
        public Magazine(string title, int issueNumber) : base(title)
        {
            IssueNumber = issueNumber;
        }
    }
}
