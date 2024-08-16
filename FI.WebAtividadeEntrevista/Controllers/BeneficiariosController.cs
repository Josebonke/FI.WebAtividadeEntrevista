using FI.AtividadeEntrevista.BLL;
using WebAtividadeEntrevista.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FI.AtividadeEntrevista.DML;
using Microsoft.Ajax.Utilities;
using System.Web.UI.WebControls;
using System.Reflection;

namespace WebAtividadeEntrevista.Controllers
{

    public class BeneficiariosController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Incluir()
        {
            return View();
        }

        [HttpPost]
        public JsonResult Incluir(BeneficiarioModelDto dto)
        {
            BoBeneficiario bo = new BoBeneficiario();

            BeneficiarioModel model = new BeneficiarioModel(dto);
            BeneficiarioFilter filter = new BeneficiarioFilter();
            filter.CpfCliente = model.Cpf;
            filter.IdCliente = model.IdCliente;
            if (!this.ModelState.IsValid)
            {
                List<string> erros = (from item in ModelState.Values
                                      from error in item.Errors
                                      select error.ErrorMessage).ToList();

                Response.StatusCode = 400;
                return Json(string.Join(Environment.NewLine, erros));
            }
            else if (bo.Listar(filter).Count > 0)
            {
                Response.StatusCode = 400;
                return Json("Cpf Já Existe em Nossa Base Por Favor Verificar");
            }
            else
            {

                model.Id = bo.Incluir(new Beneficiario()
                {
                    Id = model.Id,
                    Nome = model.Nome,
                    Cpf = model.Cpf,
                    IdCliente = model.IdCliente
                });
            }
            return Json(model);
        }


        [HttpGet]
        public JsonResult Listar(long idCliente)
        {
            try
            {
                BeneficiarioFilter beneficiarioFilter = new BeneficiarioFilter
                {
                    IdCliente = idCliente
                };
                List<Beneficiario> beneficiarios = new BoBeneficiario().Listar(beneficiarioFilter);

                return Json(beneficiarios, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                // Tratar o erro adequadamente
                throw;
            }
        }


    }  
}