using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RepositoryLayer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace WebApplication1.Controllers
{
    public class Employee : Controller
    {
        private readonly EmployeeContext context;
        private IWebHostEnvironment webHostEnvironment;

        public Employee(EmployeeContext _context, IWebHostEnvironment environment)
        {
            context = _context;
            webHostEnvironment = environment;
        }
        public IActionResult Index()
        {
            return View();
        }

        public JsonResult GetAll()
        {
            List<Tblemployee> list = new EmployeeDA(context).GetAll();
            return Json(list);
        }
        public JsonResult GetAlldesig()
        {
            List<Designation> list = new EmployeeDA(context).GetAlldesig();
            return Json(list);
        }

        public JsonResult GetByCode(int code)
        {
            Tblemployee list = new EmployeeDA(context).GetByCode(code);
            return Json(list);
        }

        public JsonResult Remove(int code)
        {
            string list = new EmployeeDA(context).Remove(code);
            return Json(list);
        }
        [HttpPost]
        public JsonResult save(Tblemployee tblemployee)
        {
            string list = new EmployeeDA(context).save(tblemployee);
            return Json(list);
        }
        [HttpPost]
        public async Task<ActionResult> uploadImage()
        {
            string Result = string.Empty;
            var files = Request.Form.Files;
            foreach(IFormFile source in files)
            {
                string Filename = source.Name+".jpeg";
                string imagepath = ActualPath(Filename);
                try
                {
                    if (System.IO.File.Exists(imagepath))
                        System.IO.File.Delete(imagepath);

                    using (FileStream stream = System.IO.File.Create(imagepath))
                    {
                        await source.CopyToAsync(stream);
                        Result = "pass";
                    }
                }catch(Exception ex)
                {

                }

            }
            return Ok (Result);
        }
        public string ActualPath(string Filename)
        {
            return Path.Combine(webHostEnvironment.WebRootPath + "\\Uploads\\Employee", Filename);
        }

        public string RemoveImage(string code)
        {
            string Filename = code+".jpeg";
            string imagepath = ActualPath(Filename);
            if (System.IO.File.Exists(imagepath))
                System.IO.File.Delete(imagepath);

            return "";
        }
    }
}
