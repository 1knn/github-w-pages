using MileniApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MileniApp.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult Index()
        {
            Cliente cliente = new Cliente()
            {
                ClienteID = 1,
                ClieteNome = "Bela",
                Cpf = 12345678911,
                RG = 123445678,
                DigRg = '0',
                ClieteTel = 12345678
                
            };

            return View(cliente);
        }
    }
}