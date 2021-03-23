using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SMCD.Data;
using SMCD.Models;
using SMCD.Data.Interfaces;
using SMCD.Data.ViewModel;
using Microsoft.EntityFrameworkCore;

namespace SMCD.Controllers
{
    public class JobController : Controller
    {
        private AppDBContent db;
        public JobController(AppDBContent db)
        {
            this.db = db;
        }

        //private readonly ITechnique _technic;

        //public JobController(ITechnique iTechnic)
        //{
        //    _technic = iTechnic;
        //}
        

        public async Task<IActionResult> Index()
        {
            return View();
        }
        public async Task<IActionResult> Сustomers()
        {
            return View();
        }
        public IActionResult Rating()
        {
            return View();
        }
        public IActionResult Student()
        {
            return View();
        }
        public async Task<IActionResult> Technic()
        {
            IQueryable<Technique> techniques = db.Technique.Include(x => x.StatusTechnique);

            //TechniqueListModel obj = new TechniqueListModel
            //{
            //    AllTechnique = _technic.Technique
            //};

            //TechniqueListModel viewModel = new TechniqueListModel
            //{
            //    Technique = await techniques.AsNoTracking().ToListAsync()
            //};

            return View();
        }
    }
}