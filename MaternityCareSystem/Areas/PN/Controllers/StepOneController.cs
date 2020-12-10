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
    public class StepOneController : Controller
    {
        StepOneBL obj = new StepOneBL();
        OutParamModel outmodel = new OutParamModel();
        // GET: PN/StepOne
        public ActionResult Index()
        {
            var model = obj.SelectAll(out outmodel);
            return View(model);
        }
        public ActionResult Create()
        {
            ViewBag.PatientId = new SelectList(Dropdowns.PatientDropDown,"Value","Text");
            return View();
        }

        // POST: PN/StepOne/Create
        [HttpPost]
        public ActionResult Create(PreNatal_Step1 model)
        {
            var toReturn = obj.Save(model, out outmodel);
            return (Json(new { mdl = outmodel, pa = toReturn }, JsonRequestBehavior.AllowGet));
        }

        // GET: PN/StepOne/Edit/5
        public ActionResult Edit(int id)
        {
            var model = obj.SelectByID(id, out outmodel);
            ViewBag.PatientId = new SelectList(Dropdowns.PatientDropDown, "Value", "Text",model.PatientId);
            
            return View(model);
        }

        // POST: PN/StepOne/Edit/5
        [HttpPost]
        public ActionResult Edit(PreNatal_Step1 model)
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
            catch
            {
                return View();
            }
        }

        //[HttpPost]
        public JsonResult DeletePrenatalStepOne(int preNatalId)
        {
            obj.Delete(preNatalId, out outmodel);
            return Json(new { result = outmodel }, JsonRequestBehavior.AllowGet);
        }
    }
}
