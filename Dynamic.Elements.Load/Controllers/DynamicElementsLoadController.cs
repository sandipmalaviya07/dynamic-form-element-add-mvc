using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dynamic.Elements.Load.Models;

namespace Dynamic.Elements.Load.Controllers
{
    public class DynamicElementsLoadController : Controller
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            ElementsModel elementsModel = new ElementsModel();
            elementsModel._TemplateModel = new TemplateModel();
            elementsModel.lstTemplateModels = new TemplateModel();
            //elementsModel.lstTemplateModels.Add(elementsModel._TemplateModel);
            elementsModel.IncrementValue = 1;
            return View(elementsModel);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult PostTemplate(ElementsModel model)
        {
            var data = model;
            return View();
        }
    }
}