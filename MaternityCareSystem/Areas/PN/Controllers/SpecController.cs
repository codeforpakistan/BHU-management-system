using MaternityCareSystem.Areas.PN.BL;
using MaternityCareSystem.Areas.PN.DataModels;
using MaternityCareSystem.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MaternityCareSystem.Areas.PN.Controllers
{
    [Authorize(Roles = "Admin")]
    public class SpecController : Controller
    {
        SpecBL obj = new SpecBL();
        OutParamModel outmodel = new OutParamModel();
        // GET: PN/Spec
        public ActionResult Index()
        {
            var model = obj.SelectAll(out outmodel);
            return View(model);
        }

        // GET: PN/Spec/Create
        public ActionResult Create()
        {
            return View();
        }

      
        // POST: PN/Spec/Create
        [HttpPost]
        public JsonResult Create(Specialization model)
        {
                // TODO: Add insert logic here
                var toReturn = obj.Save(model, out outmodel);
                return (Json(new { mdl = outmodel, pa = toReturn }, JsonRequestBehavior.AllowGet));
        }

        // GET: PN/Spec/Edit/5
        public ActionResult Edit(int id)
        {
            var model = obj.SelectByID(id, out outmodel);
            return View(model);
        }

        // POST: PN/Spec/Edit/5
        [HttpPost]
        public ActionResult Edit(Specialization model)
        {
            try
            {
                obj.Update(model,out outmodel);
                if (!outmodel.Error)
                {
                    // TODO: Add update logic here

                    return RedirectToAction("Index");
                }
                else
                {
                    return View(model);
                }
            }
            catch
            {
                return View();
            }
        }

        public JsonResult DeleteSpec(int specid)
        {
            obj.Delete(specid, out outmodel);
            return Json(new { result = outmodel }, JsonRequestBehavior.AllowGet);
        }
    }
}
