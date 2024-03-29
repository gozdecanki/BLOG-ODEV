﻿using System;
using BlogOdev.Data.Context;
using BlogOdev.Data.Dto;
using BlogOdev.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlogOdev.Web.Controllers
{
    public class ContactController : Controller
    {
        private readonly BlogContext _blogContext;
        public ContactController(BlogContext blogContext)
        {
            _blogContext = blogContext;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Send ([FromBody] ContactSendDto contactSend)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            _blogContext.Contacts.Add(new Contact()
            {
                Name = contactSend.Name,
            Surname = contactSend.Surname,
            Message=contactSend.Message,
            CreateDate =DateTime.UtcNow

            }
                );
            _blogContext.SaveChanges();
            return new JsonResult("ok");
        }
    }
}