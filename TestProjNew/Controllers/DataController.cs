using Microsoft.AspNetCore.Mvc;
using NrcTaskWeb.Models.DbModels;
using System;
using TestProjNew.Models;

namespace NrcTaskWeb.Controllers
{
    public class DataController : Controller
    {
        IRepo _repo;
        public DataController(IRepo repo)
        {
            _repo = repo;
        }
        public IActionResult AddData()
        {
            DataSample dataSample = new DataSample();
            return View(dataSample);
        }

        [HttpPost]
        public IActionResult AddData(DataSample data)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    data.IsFailed = true;
                    return View("AddData", data);
                }

                bool result = _repo.AddData(data);

                if (result)
                {
                    Shared.IsSucceeded = true;
                    return RedirectToAction("Index", "Home");
                }
                Shared.IsSucceeded = false;
                data.IsFailed = true;
                return View("AddData", data);

            }
            catch (Exception ex)
            {
                Shared.IsSucceeded = false;
                return Content("Failed" + ex);
            }
        }
    }
}
