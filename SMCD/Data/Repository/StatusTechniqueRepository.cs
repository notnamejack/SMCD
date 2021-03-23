using Microsoft.EntityFrameworkCore;
using SMCD.Data.Interfaces;
using SMCD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMCD.Data.Repository
{
    public class StatusTechniqueRepository : IStatusTechnique
    {
        private readonly AppDBContent appDBContent;
        public StatusTechniqueRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public StatusTechnique GetStatusTechnique(int id) => appDBContent.StatusTechnique.FirstOrDefault(i => i.Id == id);
    }
}
