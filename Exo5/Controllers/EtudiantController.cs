using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Exo5.Controllers
{
    public class EtudiantController : Controller
    {
        // GET: Etudiant
        public IActionResult Index()
        {
            return View();
        }

        // GET: Etudiant/Details/5
    }
}