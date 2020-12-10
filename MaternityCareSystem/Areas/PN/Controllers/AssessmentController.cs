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
    [Authorize(Roles ="Admin")]
    public class AssessmentController : Controller
    {
        AssessmentBL obj = new AssessmentBL();
        OutParamModel outmodel = new OutParamModel();
        // GET: PN/Assessment
        public ActionResult Index()
        {
            var model = obj.SelectAll(out outmodel);
            return View(model);
        }

      
        // GET: PN/Assessment/Create
        public ActionResult Create()
        {
            ViewBag.PatientId = new SelectList(Dropdowns.PatientDropDown, "Value", "Text");
            return View();
        }

        // POST: PN/Assessment/Create
        [HttpPost]
        public ActionResult Create(PreNatal_Assessment model)
        {
            var toReturn = obj.Save(model, out outmodel);
            return (Json(new { mdl = outmodel, pa = toReturn }, JsonRequestBehavior.AllowGet));
        }

        // GET: PN/Assessment/Edit/5
        public ActionResult Edit(int id)
        {
            var model = obj.SelectByID(id, out outmodel);
            ViewBag.PatientId = new SelectList(Dropdowns.PatientDropDown, "Value", "Text", model.PatientId);
            return View(model);
        }

        // POST: PN/Assessment/Edit/5
        [HttpPost]
        public ActionResult Edit(PreNatal_Assessment model)
        {
            try
            {
                obj.Update(model, out outmodel);
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
            catch (Exception ex)
            {
                ex.Message.ToString();
                return View();
            }
        }


        [HttpPost]
        public ActionResult Delete(int id)
        {
            obj.Delete(id, out outmodel);
            return Json(new { result = outmodel }, JsonRequestBehavior.AllowGet);
        }
    }
}
