using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayRoll_Client.ViewModel
{
    public interface ITakeable
    {
        public string Title { get; }
        public void Front();
        public int GetPageLength();
        public List<string> GetPageInfo(int pnum);
        public void Back();
        public void Choose(int pnum, int i);
    }
}
