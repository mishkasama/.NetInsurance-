using CodeKicker.BBCode;
using Insurance.Domaine.Entity;
using Insurance.Service;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class ForumController : Controller
    {
        TopicService Ts = new TopicService();
        SousCategoryService Ss = new SousCategoryService();
        UserService Us = new UserService();
        CategoryService Cs = new CategoryService();
        FavorisService Fs = new FavorisService();
        MessagesService Ms = new MessagesService();
        ReponseService Rs = new ReponseService();
        LikesService Ls = new LikesService();
        FilterService sfil = new FilterService();

        public static users currentuser= new users();
        public static List<users> userss = null;
        public static string msg = "";
        public static string msg2 = "";





        // GET: Forum
        public ActionResult First()
        {
            var client = new RestClient("http://localhost:18080/insurance-web/api/");
            var request = new RestRequest("Category", Method.GET);
            request.AddHeader("Content-type", "application/json");
            IRestResponse<List<category>> Cat = client.Execute<List<category>>(request);


            ViewBag.topic = Ts.GetAll();
            ViewBag.soucategory = Ss.GetAll();
            ViewBag.message = Ms.GetAll();
            ViewBag.user = Us.GetAll();


            return View(Cs.GetAll());
        }



        public void DeleteMessage(int id)
        {
            messages m = Ms.GetById(id);
            Ms.Delete(m);
            Ms.Commit();
        }

        public ActionResult AddFavoris(int id , int iduser, int idcat)
        {

            if (iduser==0)
            {
                msg= "Sorry, you have to connect";
                return RedirectToAction("Login");
            }
            else { 
            var listf = Fs.GetAll();
            favoris f = new favoris();
            f.idtopic = id;
            f.iduser = iduser;

            f.date = DateTime.Now;

            Fs.Add(f);
            Fs.Commit();
            return RedirectToAction("ViewForum", new
            {
          id=idcat
            });

            }
        }


        public ActionResult AddFavoris2(int id, int iduser)
        {

            if (iduser == 0)
            {
                msg = "Sorry, you have to connect";
                return RedirectToAction("Login");
            }
            else
            {
                var listf = Fs.GetAll();
                favoris f = new favoris();
                f.idtopic = id;
                f.iduser = iduser;

                f.date = DateTime.Now;

                Fs.Add(f);
                Fs.Commit();
                return RedirectToAction("ViewTopic", new
                {
                    id = id,
                    idRep = 0,
                });

            }
        }



        public ActionResult AddLike(int id, int iduser)
        {

            if (iduser == 0)
            {
                msg = "Sorry, you have to connect";
                return RedirectToAction("Login");
            }
            else
            {
                var listf = Ls.GetAll();
                likes l = new likes();
                l.idmessage = id;
                l.iduser = iduser;

                l.date = DateTime.Now;
                messages messages = Ms.GetById(id);
                messages.nbLike = messages.nbLike + 1;
                Ms.Update(messages);
                Ms.Commit();


                Ls.Add(l);
                Ls.Commit();
                return RedirectToAction("ViewTopic", new
                {
                    id = messages.topic.idTopic,
                    idRep = id,
                });

            }
        }



        public ActionResult Deletelike(int id, int iduser)
        {

            if (iduser == 0)
            {
                msg = "Sorry, you have to connect";
                return RedirectToAction("Login");
            }
            else
            {
       
                var listf = Ls.GetAll();
                likes l = new likes();
                foreach (var item in listf)
                {
                    if (item.idmessage == id && item.iduser == iduser)
                    {
                        l = item;
                    }
                }

                messages messages = Ms.GetById(id);
                messages.nbLike = messages.nbLike - 1;
                Ms.Update(messages);
                Ms.Commit();


                Ls.Delete(l);
                Ls.Commit();
                return RedirectToAction("ViewTopic", new
                {
                    id = messages.topic.idTopic,
                    idRep = id,
                });

            }
        }




      
        



        public ActionResult DeleteFavoris(int id, int iduser)
        {

            if (iduser == 0)
            {
                msg = "Sorry, you have to connect";
                return RedirectToAction("Login");
            }
            else
            {
                var listf = Fs.GetAll();
                   favoris f = new favoris();
                foreach (var item in listf)
                {
                    if  (item.idtopic==id && item.iduser==iduser)
                    {
                        f = item;
                    }
                }


                Fs.Delete(f);
                Fs.Commit();
              
                return RedirectToAction("ViewTopic", new
                {
                    id = id,
                idRep=0,
                });

            }
        }


        public ActionResult ViewForum(int id)
        {
            ViewBag.message = Ms.GetAll();
            ViewBag.idcategory = id;
            ViewBag.topic = Ts.GetAll();
            ViewBag.soucategory = Ss.GetAll();
            ViewBag.user = Us.GetAll();
            ViewBag.lastpost= Ms.LastPost();
            ViewBag.fav = Fs.GetAll();

            return View(Ss.GetAll());
        }

        public ActionResult AddTopic()
        {

            ViewBag.topic = Ts.GetAll();
            ViewBag.soucategory = Ss.GetAll();
            ViewBag.user = Us.GetAll();

            return View(Ss.GetAll());


            return View();
        }
        [HttpPost]
        public ActionResult AddTopic(HttpPostedFileBase photo)
        {
            try
            {
                var sujet = Request.Form["subject"];

                var contenu = Request.Form["message"];
                    
                var soucat = Request.Form["subject1"];
                var x=Ss.getByName(soucat);

                var top = new topic();

                top.contenu = (sujet); 
                top.sujet = (contenu);

                var restClient = new RestClient("http://localhost:18080/insurance-web/api/");
                restClient.AddDefaultHeader("accept", "*/*");
                var request = new RestRequest("Topic?id="+x[0].idSousCategory, Method.POST);
                request.AddJsonBody(new
                {

                    sujet = sujet,
                    contenu = contenu
                });
                var response = restClient.Execute(request);
                return RedirectToAction("First");

            }
            catch (Exception ex)
            {
                ViewBag.Message = "ERROR:" + ex.Message.ToString();
                return RedirectToAction("AddTopic");
            }
        }



        public ActionResult ViewTopic(int id, int idRep)
        {
            ViewBag.message = Ms.GetAll();
            ViewBag.reponse = Rs.GetAll();
            ViewBag.idtopic= id;
            ViewBag.topic = Ts.GetAll();
            ViewBag.soucategory = Ss.GetAll();
            ViewBag.user = Us.GetAll();
            ViewBag.fav = Fs.GetAll();
            ViewBag.idRep = idRep;
            ViewBag.likes = Ls.GetAll() ;
            ViewBag.msg = msg2;
            msg2 = "";

                

            return View();
        }


        [HttpPost]
        public ActionResult ViewTopic(int id)
        {

            var filtre = sfil.GetAll();
            int i = 0;
            bool verif = false;
            var contenu = Request.Form["message"];
            var message = new topic();
            message.contenu = (contenu);

            foreach (var item in filtre)
            {
                if (message.contenu.Contains(item.text))
                {
                    verif = true;
                }
            }


            if (!verif)
            {
                try
                {
                    var restClient = new RestClient("http://localhost:18080/insurance-web/api/");
                    restClient.AddDefaultHeader("accept", "*/*");
                    var request = new RestRequest("Message?idtopic=" + id, Method.POST);
                    request.AddJsonBody(new
                    {

                        contenu = contenu

                    });
                    var response = restClient.Execute(request);

                }

                catch (Exception ex)
                {
                    ViewBag.Message = "ERROR:" + ex.Message.ToString();
                    return RedirectToAction("AddTopic");
                }



                List<messages> messages = (List<messages>)Ms.GetAll();
                int count = messages.Count() - 1;

                int idRep = messages[count].idMessage;

                return RedirectToAction("ViewTopic", new
                {
                    id = id,
                    idRep = idRep,
                });
            }
            else
            {
                msg2 = "verifier votre language!!!!";
                return RedirectToAction("ViewTopic", new
                {
                    id = id,
                    idRep = 0,
                });
            }

        }


        public ActionResult AddReponse(int id)
        {

            ViewBag.msg = Ms.GetAll();

            ViewBag.idMessage = id;
            return View();
        }

        [HttpPost]
        public ActionResult AddReponse(HttpPostedFileBase photo , int id)
        {

            reponse rep = new reponse();
            var contenu = Request.Form["message"];
            rep.contenu = (contenu);
            rep.idMessage = id;
            rep.idUser = 2;
            
            rep.datePost= DateTime.Now;
            rep.dateEdit= DateTime.Now;


            Rs.Add(rep);
            Rs.Commit();
            messages msgg = Ms.GetById(id);
            return RedirectToAction("ViewTopic", new
            {
                id = msgg.topic.idTopic,
                idRep = id,
            });
        }



        //bbcode
        public static string bbcode(String text)
        {




            var client = new RestClient("http://localhost:18080/insurance-web/api/");
            var request = new RestRequest("insurance?text="+text, Method.GET);
            request.AddHeader("Content-type", "application/json");
            IRestResponse<List<string>> Cat = client.Execute<List<string>>(request);
            string ccc = "dddd";
            string xx = Cat.Content;
           
            return Cat.Content;
        }



        
        public ActionResult Login()
        {
            ViewBag.ErrorMessage = msg;
            return View();
        }

        [HttpPost]
        public ActionResult Login(HttpPostedFileBase phot)
        {
            var email = Request.Form["login"];
            var password = Request.Form["password"];
            var client = new RestClient("http://localhost:18080/insurance-web/api/");
            var request = new RestRequest("user/"+email+"/"+password, Method.GET);
            request.AddHeader("Content-type", "application/json");


            IRestResponse<List<users>> user = client.Execute<List<users>>(request);

            string ch = user.Content;
            Console.WriteLine(ch);

            currentuser = Us.GetById(int.Parse(ch));
            currentuser.Online = 1;

          
           

            return RedirectToAction("Create", "Home", new { area = "" });
        }

        public ActionResult Logout()
        {
            currentuser.id = 0;
             currentuser.Online = 0;
            return RedirectToAction("First");



        }




    }
}