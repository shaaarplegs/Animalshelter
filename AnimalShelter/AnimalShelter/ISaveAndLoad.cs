using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter
{
    public interface ISaveAndLoad
    {
        bool SaveFiles(string FileName);
        bool LoadFiles(string FileName);
    }
}
