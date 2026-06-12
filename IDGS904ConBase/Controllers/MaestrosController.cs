using IDGS904ConBase.Models;
using System;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

namespace IDGS904ConBase.Controllers
{
    public class MaestrosController : Controller
    {
        // GET: Maestros
        public ActionResult Index()
        {
            using (var dbAlumno = new AlumnoContext())
            {
                return View(dbAlumno.Maestros.ToList());
            }
        }

        // GET: Maestros/Details/5
        public ActionResult Details(int id)
        {
            using (var dbAlumno = new AlumnoContext())
            {
                return View(dbAlumno.Maestros.Where(x => x.Id == id).FirstOrDefault());
            }
        }

        // GET: Maestros/Edit/5
        public ActionResult Edit(int id)
        {
            using (var dbAlumno = new AlumnoContext())
            {
                return View(dbAlumno.Maestros.Where(x => x.Id == id).FirstOrDefault());
            }
        }

        // POST: Maestros/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Maestro maestro)
        {
            try
            {
                using (var dbAlumno = new AlumnoContext())
                {
                    dbAlumno.Entry(maestro).State = EntityState.Modified;
                    dbAlumno.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Maestros/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Maestros/Create
        [HttpPost]
        public ActionResult Create(Maestro maestro)
        {
            try
            {
                using (var dbAlumno = new AlumnoContext())
                {
                    dbAlumno.Maestros.Add(maestro);
                    dbAlumno.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Maestros/Delete/5
        public ActionResult Delete(int id)
        {
            using (var dbAlumno = new AlumnoContext())
            {
                return View(dbAlumno.Maestros.Where(x => x.Id == id).FirstOrDefault());
            }
        }

        // POST: Maestros/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                using (var dbAlumno = new AlumnoContext())
                {
                    Maestro maestro = dbAlumno.Maestros.Where(x => x.Id == id).FirstOrDefault();

                    dbAlumno.Maestros.Remove(maestro);
                    dbAlumno.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}