﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace UdemyM1.Controllers
{
    public class SkillController : Controller
    {
        SkillManager _skillManager = new SkillManager(new EFSkillDal());
        public IActionResult Index()
        {
            var values =  _skillManager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddSkill()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddSkill(Skill skill)
        {
            _skillManager.TAdd(skill);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteSkill(int id)
        {
            var values = _skillManager.TGetByID(id);
            _skillManager.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditSkill(int id)
        {
            var values = _skillManager.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditSkill(Skill skill)
        {
            _skillManager.TUpdate(skill);
            return RedirectToAction("Index");
        }
    }
}
