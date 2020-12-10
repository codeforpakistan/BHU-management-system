using MaternityCareSystem.Areas.PN.BL;
using MaternityCareSystem.Areas.PN.DataModels;
using MaternityCareSystem.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using System.Web.Security;

namespace MaternityCareSystem.Areas.PN.Controllers
{
    [Authorize(Roles = "Admin,Receptionist")]
    public class PatientController : Controller
    {
        // GET: PN/Patient
        OutParamModel outmodel = new OutParamModel();
        PatientBL obj = new PatientBL();
       
        public ActionResult Index(int? id, int? mrNo)
        {
            try
            {
                //var userid = User.Identity.GetUserId();
               // string[] roles = Roles.GetRolesForUser(User.Identity.GetUserName());
               // bool isInRole = User.IsInRole("Receptionist");
                int pageNo = id ?? 1;
                int pagesize = 10;
                var model = mrNo.HasValue ? obj.SeachPatientByMrNumber(mrNo ?? 0, out outmodel) : obj.SelectAll(pageNo, pagesize, out outmodel);
                PatientInfoPaging pmodel = new PatientInfoPaging();
                pmodel.PageNo = pageNo;
                pmodel.Patients = model;
                pmodel.TotalRecords = outmodel.TotalRecords;
                pmodel.PageSize = pagesize;
                return View(pmodel);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        // GET: PN/Patient/Create
        public ActionResult Create()
        {
            ViewBag.GuardianRelation = new SelectList(Dropdowns.Relation, "Value", "Text");
            ViewBag.Gender = new SelectList(Dropdowns.Genders, "Value", "Text");
            return View();
        }

        // POST: PN/Patient/Create
        [HttpPost]
        public JsonResult Create(PatientInfo model)
        {
            var toReturn = obj.Save(model, out outmodel);
            return Json(new { mdl = outmodel, pa = toReturn }, JsonRequestBehavior.AllowGet);// TODO: Add insert logic here
        }

        // GET: PN/Patient/Edit/5
        public ActionResult Edit(int id)
        {
            var model = obj.SelectByID(id, out outmodel);
            ViewBag.GuardianRelation = new SelectList(Dropdowns.Relation, "Value", "Text",model.GuardianRelation);
            ViewBag.Gender = new SelectList(Dropdowns.Genders, "Value", "Text",model.Gender);
            return View(model);
        }

        // POST: PN/Patient/Edit/5
        [HttpPost]
        public ActionResult Edit(PatientInfo model)
        {
            try
            {
                ViewBag.GuardianRelation = new SelectList(Dropdowns.Relation, "Value", "Text", model.GuardianRelation);
                ViewBag.Gender = new SelectList(Dropdowns.Genders, "Value", "Text", model.Gender);
                if (ModelState.IsValid)
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
        // POST: PN/Patient/Delete/5
        [HttpPost]
        public JsonResult DeletePatient(int patientid)
        {
            obj.Delete(patientid, out outmodel);
            return Json(new { result = outmodel }, JsonRequestBehavior.AllowGet);
        }
       
        
    }
}
