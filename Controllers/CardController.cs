using DymamicCard.Models.Data;
using DymamicCard.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DymamicCard.Controllers
{
    public class CardController : Controller
    {
        PersonRepository pr = new PersonRepository();
        public IActionResult DataIndex()
        {
            return View(pr.TList());
        }
        [HttpGet]
        public IActionResult AddData()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddDAta(PersonInfo pi)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("AddData");
            }
            pr.TAdd(pi);
            return RedirectToAction("DataIndex");
        }
        [HttpGet]
        public IActionResult CardIndex(int id)
        {
            var per = pr.TGetById(id);
            PersonInfo pi = new PersonInfo()
            {
                PersonName = per.PersonName,
                Job = per.Job,
                BirthDate = per.BirthDate,
                PhoneNumber = per.BirthDate,
                Address = per.Address,
                Mail = per.Mail,
                Website = per.Website
            };
            return View(pi);
        }
    }
}