using Microsoft.EntityFrameworkCore;
using SMCD.Data.Interfaces;
using SMCD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMCD.Data.Repository
{
    public class TechniqueRepository : ITechnique
    {
        private readonly AppDBContent appDBContent;
        public TechniqueRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public IEnumerable<Technique> Technique => appDBContent.Technique;

        public Technique GetTechnic(int id)
        {
            throw new NotImplementedException();
        }
    }
}
