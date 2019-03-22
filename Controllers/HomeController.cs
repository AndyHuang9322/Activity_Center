using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Activity_Center.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;

namespace Activity_Center.Controllers {
    public class HomeController : Controller {
        private MyContext dbContext;

        // here we can "inject" our context service into the constructor
        public HomeController (MyContext context) {
            dbContext = context;
        }
// Homepage:
        [Route ("")]
        [HttpGet]
        public IActionResult Index () {
            return View ();
        }
// Register:
        [HttpPost("/new")]
        public IActionResult CreateUser (User info) {
            if(ModelState.IsValid)
            {
                if(dbContext.Users.Any(u => u.Email == info.Email))
                {
                    ModelState.AddModelError("Email", "Email already in use!");
                    return View("Index");
                }
                User new_model_item = new User ();
                new_model_item.FirstName = info.FirstName;
                new_model_item.LastName = info.LastName;
                new_model_item.Email = info.Email;
                PasswordHasher<User> Hasher = new PasswordHasher<User>();
                new_model_item.Password= Hasher.HashPassword(info, info.Password);
                dbContext.Add (new_model_item);
                dbContext.SaveChanges ();
                ViewBag.data = new_model_item;
                HttpContext.Session.SetInt32("UserId", new_model_item.UserId);
                HttpContext.Session.SetString("FirstName", new_model_item.FirstName);
                HttpContext.Session.SetString("LastName", new_model_item.LastName);
                return RedirectToAction("Dashboard");
            }
            else
            { 
                return View("Index");
            }
        }
// Login:
        [HttpPost("/LoginUser")]
        public IActionResult Login (UserLogin info) {
            if(ModelState.IsValid)
            {
                var user_email = dbContext.Users.FirstOrDefault(u => u.Email == info.LogEmail);
                {
                    if(user_email == null)
                    {
                        ModelState.AddModelError("LogEmail", "Incorrect");
                        return View ("Index");
                    }
                    var hasher = new PasswordHasher<UserLogin>();
                    var user_password = hasher.VerifyHashedPassword(info, user_email.Password, info.LogPassword);
                    if(user_password == 0)
                    {
                        ModelState.AddModelError("LogPassword", "Incorrect");
                        return View ("Index");
                    }
                    HttpContext.Session.SetInt32("UserId", user_email.UserId);
                    HttpContext.Session.SetString("FirstName", user_email.FirstName);
                    HttpContext.Session.SetString("LastName", user_email.LastName);
                    return RedirectToAction("Dashboard");  
                }
            }
            else
            { 
                return View("Index");
            }
        }
// Dashboard:
        [HttpGet("Home")]
        public IActionResult Dashboard (int id) {
            int? UserId = HttpContext.Session.GetInt32("UserId");
            if (UserId == null)
            {
                return View("Index");
            }
            List<Event> MyEvents = dbContext.Events
            .OrderBy(e => e.StartTime)
            .Include(e => e.Participants)
            .ToList();
            ViewBag.LoginUser = (int) HttpContext.Session.GetInt32("UserId");
            ViewBag.FirstName = HttpContext.Session.GetString("FirstName");
            ViewBag.LastName = HttpContext.Session.GetString("LastName");
            List<User> MyUsers = dbContext.Users
            .ToList();
            ViewBag.users = MyUsers;
            List<Event> UserJoinedEvents = dbContext.Events
            .Include(u => u.Participants)
            .Where(u => u.Participants
            .All(assoc => assoc.UserId == UserId))
            .ToList();
            List<Event> UserNotJoinedEvents = dbContext.Events
            .Include(u => u.Participants)
            .Where(u => u.Participants
            .All(assoc => assoc.UserId != UserId))
            .ToList();
            ViewBag.UserJoinedEvents = UserJoinedEvents;
            ViewBag.UserNotJoinedEvents = UserNotJoinedEvents;
            return View (MyEvents);
        }
// Logout:
        [HttpGet("/logout")]
        public IActionResult Logout () {
            HttpContext.Session.Clear();
            return View("Index");
        }
// NewEvent:
        [HttpGet("/New")]
        public IActionResult NewEvent () {
            return View();
        }
// AddEvent:
        [HttpPost("/Add")]
        public IActionResult CreateEvent (Event info) {
            if(ModelState.IsValid)
            {
                DateTime today = DateTime.Now;
                if(info.StartTime < today)
                {
                    ModelState.AddModelError("StartTime", "Past Date / Invalid");
                    return View("NewEvent");
                }
                else
                {
                    Event new_model_item = new Event ();
                    Console.WriteLine(Request.Form["TimeType"]);
                    if (Request.Form["TimeType"] == "0"){
                        new_model_item.EndTime = info.StartTime.AddDays(info.Duration);
                        new_model_item.TimeType = "Days";

                    }
                    if (Request.Form["TimeType"] == "1"){
                        new_model_item.EndTime = info.StartTime.AddHours(info.Duration);
                        new_model_item.TimeType = "Hours";
                    }
                    if (Request.Form["TimeType"] == "2"){
                        new_model_item.EndTime = info.StartTime.AddMinutes(info.Duration);
                        new_model_item.TimeType = "Minutes";
                    }
                    new_model_item.Title = info.Title;
                    new_model_item.StartTime = info.StartTime;
                    new_model_item.Duration = info.Duration;
                    new_model_item.Description = info.Description;
                    new_model_item.UserId = (int)HttpContext.Session.GetInt32("UserId");
                    dbContext.Add(new_model_item);
                    dbContext.SaveChanges ();
                    int EventId = new_model_item.EventId;
                    return RedirectToAction("ShowEvent", new {id = EventId});
                }
            }
            return View("NewEvent");
        }
// ShowEvent:
        [HttpGet("/Activity/{id}")]
        public IActionResult ShowEvent (int id) {
            Event GuestsList = dbContext.Events
                .Include(e => e.Participants)
                .ThenInclude(assoc => assoc.User)
                .FirstOrDefault(e => e.EventId == id);
            ViewBag.GuestsList = GuestsList;
            Event ThisEvent = dbContext.Events
            .FirstOrDefault(e => e.EventId == id);
            List<User> MyUsers = dbContext.Users
            .ToList();
            ViewBag.users = MyUsers;
            return View(ThisEvent);
        }
// RSVP:
        [HttpPost("/RSVP/{id}")]
        public IActionResult RSVP (int id) {
            int? UserId = HttpContext.Session.GetInt32("UserId");
            int EventId = id;
            User UserToAdd = dbContext.Users
                .FirstOrDefault(u => u.UserId == UserId);
            Event EventToAdd = dbContext.Events
                .FirstOrDefault(e => e.EventId == EventId);
            Association newAssociation = new Association();
            newAssociation.UserId = (int)UserId;
            newAssociation.EventId = EventId;
            newAssociation.User = UserToAdd;
            newAssociation.Event = EventToAdd;
            dbContext.Add(newAssociation);
            dbContext.SaveChanges();
            return RedirectToAction("Dashboard", new {id = EventId});
        }
// Un-RSVP:
        [HttpGet("Un-RSVP/{id}")]
        public IActionResult UnRSVP (int id) {
            int? UserId = HttpContext.Session.GetInt32("UserId");
            int EventId = id;
            List<Association> unRSVPs = dbContext.Associations
                .Where(e => e.EventId == EventId).ToList();
            Association unRSVP = unRSVPs.FirstOrDefault(u => u.UserId == UserId);
            dbContext.Remove(unRSVP);
            dbContext.SaveChanges ();
            return RedirectToAction ("Dashboard");
        }
// Delete:
        [HttpGet("/Delete/{id}")]
        public IActionResult Delete (int id) {
            Event DeletedEvent = dbContext.Events
                .FirstOrDefault(e => e.EventId == id);
            dbContext.Remove(DeletedEvent);
            dbContext.SaveChanges();
            return RedirectToAction("Dashboard");
        }
    }
}