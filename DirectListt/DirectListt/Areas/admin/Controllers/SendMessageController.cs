using DirectListt.Data;
using DirectListt.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGeneration.Contracts.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace DirectListt.Areas.admin.Controllers
{
    [Area("admin")]
    public class SendMessageController : Controller
    {
        private readonly AppDbContext _context;

        public SendMessageController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Contact> model = _context.Contacts.ToList();
            return View(model);
        }
        public IActionResult Update(int id)
        {
            return View(_context.Contacts.Find(id));
        }

        [HttpPost]
        public IActionResult Update(Contact model)
        {
            if (ModelState.IsValid)
            {
                _context.Contacts.Update(model);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(model);
        }
        public IActionResult Delete(int id)
        {
            Contact contact = _context.Contacts.Find(id);
            _context.Contacts.Remove(contact);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult SendMailAll()
        {
            return View(_context.Contacts.ToList());
        }
        [HttpPost]
        public IActionResult SendMailAll(string MailText)
        {
            List<Contact> contacts = _context.Contacts.ToList();
            foreach (var item in contacts)
            {
                MailMessage message = new MailMessage();
                message.From = new MailAddress("punhan.shahmurov.123456@gmail.com","Hello P222");
                message.To.Add(item.Email);
                message.Body = MailText;
                message.IsBodyHtml = true;
                message.Subject = "Communication";

                SmtpClient smtpClient = new SmtpClient();
                smtpClient.Host = "smtp.gmail.com";
                smtpClient.EnableSsl = true;
                smtpClient.Port = 587;
                smtpClient.Credentials = new NetworkCredential("punhan.shahmurov.123456@gmail.com", "Punhan123456");
                smtpClient.Send(message);
            }

            return RedirectToAction("Index");
        }
    }
}
