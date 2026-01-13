using ApiProject.WebApi.Context;
using ApiProject.WebApi.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationsController : ControllerBase
    {
        private readonly ApiContext _context;

        public NotificationsController(ApiContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult NotificationList()
        {
            var values = _context.Notifications.ToList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateNotification(Notification Notification)
        {
            _context.Notifications.Add(Notification);
            _context.SaveChanges();
            return Ok(" ekleme işlemi başarılı");
        }

        [HttpDelete]
        public IActionResult DeleteNotification(int id)
        {
            var value = _context.Notifications.Find(id);
            _context.Notifications.Remove(value);
            _context.SaveChanges();
            return Ok(" silme işlemi başarılı");
        }
        [HttpGet("GetNotification")]
        public IActionResult GetNotification(int id)
        {
            var value = _context.Notifications.Find(id);
            return Ok(value);
        }
        [HttpPut]
        public IActionResult UpdateNotification(Notification Notification)
        {
            _context.Notifications.Update(Notification);
            _context.SaveChanges();
            return Ok(" güncelleme işlemi başarılı");
        }
    }
}
