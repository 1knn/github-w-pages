using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QuintaApp.Models;

namespace QuintaApp.Controllers
{
    public class FuncionarioController : Controller
    {
        // GET: Funcionario
        public ActionResult Index()
        {
            Funcionario funcionario = new Funcionario()
            {
                FuncID = 1,
                FuncNome = "Bruno",
                FuncFuncao = "Sênior"
            };

            return View(funcionario);
        }

        public ActionResult Listar(ushort A, string FuncNome, string FuncFuncao )
        {
            ViewData["FuncID"] = A;
            ViewData["FuncNome"] = FuncNome;
            ViewData["FuncFuncao"] = FuncFuncao;

            return View();
        }
    }
}