using Insurance.Data.Infrastructure;
using Insurance.Domaine.Entity;
using Insurance.Service;


using Rotativa.MVC;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class EvenementController : Controller
    {

        public static int UserId = 1;
        EvenementService ise = new EvenementService();
      //  IUnitOfWork iuw = null;

        public EvenementController()
        {
           
        }

        // GET: Evenement********************************************************
        public ActionResult List()
        {
            var Exhibition = ise.GetAll();
            List<EvenementModel> fVM = new List<EvenementModel>();
            foreach (var item in Exhibition)
            {
                fVM.Add(
                    new EvenementModel
                    {
                        EvenementId = item.EvenementId,
                        Description = item.Description,
                        Title = item.Title,
                        Image = item.Image,
                        Start_Date =  new DateTime(),
                        Finish_Date = new DateTime(),
                        
                    });
            }
            return View(fVM);
        }

        // GET: Evenement/Details/5
        public ActionResult Details(int id)
        {
            evenement c = ise.GetById(id);

            return View(c);
        }

        // GET: Evenement/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Evenement/Create****************************************************
        [HttpPost]
        public ActionResult Create(evenement e, HttpPostedFileBase image)
        {
            if (!ModelState.IsValid || image == null || image.ContentLength == 0)
            {
                RedirectToAction("List");
            }
        
                e.AgenceId = 1;
               e.Image = image.FileName;
            ise.Add(e);
            ise.Commit();
                var path = Path.Combine(Server.MapPath("~/Content/Upload/"), image.FileName);
                image.SaveAs(path);
                return RedirectToAction("List", "Evenement");

            return View();
        }
        //********************************************************************************

        // GET: Evenement/Edit/5
        public ActionResult Edit(int id)
        {
            if (id == 0)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            evenement c = ise.GetById(id);
            if (c == null)
            {
                return HttpNotFound();
            }

            return View(c);
        }

        // POST: Evenement/Edit/5
        [HttpPost]
        public ActionResult Edit(evenement e)
        {
            if (ModelState.IsValid)
            {
                ise.Update(e);
                TempData.Clear();
                TempData["updated"] = e.Title;
                return RedirectToAction("List");
            }
            return View(e);
        }

        // GET: Evenement/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // DELETE: Evenement/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            evenement a = ise.GetById(id);
            ise.Delete(a);
            var hs = ise.GetAll();
            TempData.Clear();
            TempData["deleted"] = "1";
            return RedirectToAction("List", hs);
        }


    
        public ActionResult ExportPdf()
        {

            return new ActionAsPdf("List")
            {

                FileName = Server.MapPath("~/Content/List.pdf")

            };

        }


       




    }


}
