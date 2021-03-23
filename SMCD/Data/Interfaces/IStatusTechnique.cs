using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SMCD.Models;

namespace SMCD.Data.Interfaces
{
    public interface IStatusTechnique
    {
        StatusTechnique GetStatusTechnique(int id);
    }
}
