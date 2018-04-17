using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Web.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using BLL;

namespace HappyLibraryMVC.Controllers
{
    public class AuthorsController : Controller
    {
        // GET: Authors
        [Authorize]
        public ActionResult Index()
        {
            HttpClient client = MVCUtil.GetClient("userToken");

            IEnumerable<Author> listAuthors = JsonConvert.DeserializeObject<IEnumerable<Author>>(client.GetStringAsync("api/Authors").Result);

            return View(listAuthors);
        }

        // GET: Authors/Details/5
        [Authorize]
        public ActionResult Details(int id)
        {
            HttpClient client = MVCUtil.GetClient("userToken");

            Author author = JsonConvert.DeserializeObject<Author>(client.GetStringAsync($"api/Authors/{id}").Result);

            return View(author);
        }

        // GET: Authors/Create
        [Authorize]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Authors/Create
        [HttpPost]
        [Authorize]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                Author author = new Author()
                {
                    Name = collection["Name"],
                    Surname = collection["Surname"],
                    Email = collection["Email"],
                    Birthday = DateTime.Parse(collection["Birthday"])
                };

                HttpClient client = MVCUtil.GetClient("userToken");

                JObject result = JObject.FromObject(author);

                var httpResponseMessage = client.PostAsJsonAsync("api/Authors", result).Result;

                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                return RedirectToAction("Index");
            }
        }

        // GET: Authors/Edit/5
        [Authorize]
        public ActionResult Edit(int id)
        {
            HttpClient client = MVCUtil.GetClient("userToken");

            Author atr = JsonConvert.DeserializeObject<Author>(client.GetStringAsync($"api/Authors/{id}").Result);

            return View(atr);
        }

        // POST: Authors/Edit/5
        [HttpPost]
        [Authorize]
        public ActionResult Edit(Author author)
        {
            HttpClient client = MVCUtil.GetClient("userToken");

            JObject jObj = JObject.FromObject(author);

            var y = client.PutAsJsonAsync($"api/Authors", jObj).Result;

            return RedirectToAction("Index");
        }

        // GET: Authors/Delete/5
        [Authorize]
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Authors/Delete/5
        [HttpPost]
        [Authorize]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
