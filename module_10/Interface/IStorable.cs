using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module_10.Interface
{
    public interface IStorable
    {
        void SaveState(string fileName);
        void LoadState(string fileName);
    }
}
