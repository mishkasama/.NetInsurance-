using Insurance.Data.Infrastructure;
using Insurance.Domaine.Entity;
using Insurance.Service;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {

        SiniterService uow = new SiniterService();

        public ActionResult Index()
        {
            var items = uow.GetAll();
            //sinister model = Mapper.Map<sinister>(items);

            ViewBag.Title = items;
            return View();
        }
        // GET: Home/Delete/5
        public ActionResult Delete(int id)
        {
            try
            {
                var items = uow.GetById(id);

                uow.Delete(items);
              
                uow.Commit();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        // GET: ReservationAcc/Edit/5
        public ActionResult Edit(int id)
        {

            var items = uow.GetById(id);
            sinisterModels senist = new sinisterModels
            {
                email = items.email,
                dateCreation = items.dateCreation,
                nameFirstname = items.nameFirstname,
                nameInsurancCompany = items.nameInsurancCompany,

            };
            return View(senist);
        }

        // POST: Home/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, sinister sen)
        {
            var items = uow.GetById(id);
            items.email = sen.email;
            items.dateCreation = sen.dateCreation;
            items.nameFirstname = sen.nameFirstname;
            items.nameInsurancCompany = sen.nameInsurancCompany;



            if (ModelState.IsValid)
            {
                uow.Update(items);
                uow.Commit();
                return RedirectToAction("Index");
            }

            return View();
        }
        // GET: Home/Create
        public ActionResult Create()
        {
            return View();
        }
        // POST: Home/Create
        [HttpPost]

        public ActionResult Create(sinisterModels sinismodel, HttpPostedFileBase image)
        {
            if (!ModelState.IsValid || image == null || image.ContentLength == 0)
            {
                RedirectToAction("Index");
            }
            sinismodel.urlImage = image.FileName;
            sinister sinis = new sinister();

            sinis.email = sinismodel.email;
            sinis.dateCreation = sinismodel.dateCreation;
            sinis.nameFirstname = sinismodel.nameFirstname;
            sinis.urlImage = sinismodel.urlImage;
            sinis.nameInsurancCompany = sinismodel.nameInsurancCompany;
            sinis.tel = sinismodel.tel;
            sinis.policyNum = sinismodel.policyNum;
            sinis.latitude = sinismodel.latitude;
            sinis.longitude = sinismodel.longitude;
            sinis.state = sinismodel.state;

            uow.Add(sinis);
            uow.Commit();
            // Sauvgarde de l'image

            var path = Path.Combine(Server.MapPath("~/Content/Upload/"), image.FileName);
            image.SaveAs(path);
            return RedirectToAction("Index");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        // GET: Home/Details/5
        public ActionResult Details(int id)
        {
            var items = uow.GetById(id);
            sinisterModels sinis = new sinisterModels
            {
                id = items.id,
                email = items.email,
                dateCreation = items.dateCreation,
                nameFirstname = items.nameFirstname,
                nameInsurancCompany = items.nameInsurancCompany,
                tel = items.tel,
                policyNum = items.policyNum,

                urlImage = items.urlImage,

                latitude = items.latitude,
                longitude = items.longitude
            };
            return View(sinis);
        }

    }
}