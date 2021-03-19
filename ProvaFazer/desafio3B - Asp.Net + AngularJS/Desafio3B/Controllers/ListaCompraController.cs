using Desafio3A.DataModel;
using Desafio3A.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Desafio3A.Controllers
{
    public class ListaCompraController : Controller
    {
        DataModelContext db = new DataModelContext();

        public JsonResult BuscarAlimentos(string termo)
        {
            termo = termo ?? "";

            var alimentos = db.Alimento.Where(w => w.Nome.Contains(termo)).ToList();
            var alimentosViewModel = alimentos.Select(s => new ListaCompraVM()
            {
                IdAlimento = s.Id,
                Nome = s.Nome,
                Preco = s.Preco,
                Quantidade = 1
            });

            return Json(alimentosViewModel, JsonRequestBehavior.AllowGet);
        }

        public JsonResult BuscarListaCompra()
        {
           throw new NotImplementedException();
        }

        [HttpPost]
        public JsonResult Salvar(List<ListaCompraVM> dados)
        {
            throw new NotImplementedException();
        }
    }
}