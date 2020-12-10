using MaternityCareSystem.Areas.PN.BL;
using MaternityCareSystem.Domain;
using MaternityCareSystem.Models;
using MaternityCareSystem.Models.ProcModels;
using System;
using System.Linq;
using System.Web.Mvc;

namespace MaternityCareSystem.Areas.PN.Controllers
{
    [Authorize(Roles = "Admin")]
    public class RolesController : Controller
    {
        // GET: PN/Roles
        RolesBL obj = new RolesBL();
        OutParamModel outmodel = new OutParamModel();
        HmsContext context = new HmsContext();
        public ActionResult Index()
        {
            var model = obj.SelectAll(out outmodel);
            return View(model);
        }

        // GET: PN/Roles/Edit/5
        public ActionResult Edit(string id)
        {
            var model = obj.SelectByID(id, out outmodel);
            ViewBag.Role = new SelectList(context.AspNetRoles.ToList(), "Id", "Name",model.Id);
            return View(model);
        }

        // POST: PN/Roles/Edit/5
        [HttpPost]
        public ActionResult Edit(RolesViewModel model)
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

        
       
    }
}
