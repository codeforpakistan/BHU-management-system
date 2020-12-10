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
    public class StepTwoController : Controller
    {
        StepTwoBL stepTwoBL = new StepTwoBL();
        OutParamModel outmodel = new OutParamModel();
        // GET: PN/StepTwo
        public ActionResult Index()
        {
            var model = stepTwoBL.SelectAll(out outmodel);
            return View(model);
        }
      
        // GET: PN/StepTwo/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PN/StepTwo/Create
        public ActionResult Create()
        {
            ViewBag.PatientId = new SelectList(Dropdowns.PatientDropDown, "Value", "Text");
            return View();
        }

        // POST: PN/StepTwo/Create
        [HttpPost]
        public ActionResult Create(PreNatal_Step2 model)
        {
            var toReturn = stepTwoBL.Save(model, out outmodel);
            return (Json(new { mdl = outmodel, pa = toReturn }, JsonRequestBehavior.AllowGet));
          
        }

        // GET: PN/StepTwo/Edit/5
        public ActionResult Edit(int id)
        {
            var model = stepTwoBL.SelectByID(id, out outmodel);
            ViewBag.PatientId = new SelectList(Dropdowns.PatientDropDown, "Value", "Text",model.PatientId);
            return View(model);
        }

        // POST: PN/StepTwo/Edit/5
        [HttpPost]
        public ActionResult Edit(PreNatal_Step2 model)
        {
            try
            {
                stepTwoBL.Update(model, out outmodel);
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
            catch(Exception ex)
            {
                ex.Message.ToString();
                return View();
            }
        }

        // GET: PN/StepTwo/Delete/5
        [HttpPost]
        public JsonResult DeletePrenatalStepTwo(int id)
        {
            stepTwoBL.Delete(id, out outmodel);
            return Json(new { result = outmodel }, JsonRequestBehavior.AllowGet);
        }
        [HttpGet]
        public ActionResult PopulateForm(int MrNumber)
        {
            var model = stepTwoBL.PopulateByMrNumber(MrNumber, out outmodel);
            if (model != null)
            {
                ViewBag.PatientId = new SelectList(Dropdowns.PatientDropDown, "Value", "Text", model.PatientId);
                return View("~/Areas/PN/Views/StepTwo/Create.cshtml", model);
            }
            ViewBag.PatientId = new SelectList(Dropdowns.PatientDropDown, "Value", "Text");
            return View("~/Areas/PN/Views/StepTwo/Create.cshtml");

        }
    }
}
