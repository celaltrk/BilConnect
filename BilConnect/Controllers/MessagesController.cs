﻿using BilConnect.Data.Services;
using BilConnect.Data.Static;
using BilConnect.Data.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace BilConnect.Controllers
{
    [Authorize(Roles = UserRoles.Admin + "," + UserRoles.User)]

    public class MessagesController : Controller
    {
        private readonly IMessagesService _service;
        public MessagesController(IMessagesService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> Create(string content, string userId, int chatId)
        {
            try
            {
                // Create a new message
                MessageVM msg = new MessageVM
                {
                    Content = content,
                    Timestamp = DateTime.UtcNow,
                    SenderUserId = userId,
                    ChatId = chatId
                };
                await _service.AddNewMessageAsync(msg);

                // Success
                return Json(new { success = true, message = "Data saved successfully" });
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error: " + ex.Message);
                // Return a JSON result indicating failure
                return Json(new { success = false, message = ex.Message });
            }
        }

    }
}
