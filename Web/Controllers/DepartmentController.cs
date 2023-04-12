using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Runtime.Intrinsics.Arm;
using CapstoneProjects.DataAccess;
using CapstoneProjects.Models;

namespace Web.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly AppDbContext _db;                //read from program.cs
        public DepartmentController(AppDbContext db)     //implement
        {
            _db = db;
        }



        public IActionResult Index()
        {
            //EQUAL TO: DATATABLE --> SELECT * FROM DEPARTMENTS

            //ALSO AS WRITTEN AS: var DepartmentList = _db.Departments.ToList();
            IEnumerable<Department> DepartmentList = _db.Departments;
            return View(DepartmentList);
        }

        //GET:
        public IActionResult Create()
        {
            return View();
        }

        //POST:
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Department dep)
        {
            if (ModelState.IsValid)
            {

                int check = 0;
                _db.Departments.Add(dep);
                check = _db.SaveChanges();

                if (check > 0)
                {
                    TempData["OK"] = "Successfully added the Department Category";

                }
                else
                {
                    TempData["NO"] = "Unable to add Department Category";
                }
                return RedirectToAction("Index");
            }//end of modelstate

            return View(dep);
        }


        //eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee

        // GET: Categories/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category =  _db.Departments.Find(id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        // POST: Categories/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Department category)
        {
            //if (category.DepID != id)
            //{
            //    return NotFound();
            //}

            if (ModelState.IsValid)
            {
                try
                {
                    _db.Update(category);
                    _db.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CategoryExists(category.DepID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(category);
        }

        private bool CategoryExists(int id)
        {
            return _db.Departments.Any(e => e.DepID == id);
        }

        //pppppppppppppppppppppppppppppppppppppppppp

        // GET: Categories/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category = _db.Departments
                .FirstOrDefault(m => m.DepID == id);
            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        // POST: Categories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            int check = 0;
            var category = _db.Departments.Find(id);
            _db.Departments.Remove(category);
             check = _db.SaveChanges();
            if (check > 0)
            {
                TempData["OK"] = "Successfully Deleted";
                return RedirectToAction("Index");
            }
            else
            {
                TempData["NO"] = "Unable to delete";
                return RedirectToAction("Index");
            }
            
        }
    }
    }
    
            
        
    

