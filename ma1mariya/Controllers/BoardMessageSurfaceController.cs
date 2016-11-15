
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Mvc;
using ma1mariya.ViewModels;
using Umbraco.Core.Models;

namespace ma1mariya.Controllers
{
    public class BoardMessageSorfaceController : SurfaceController
    {
        public ActionResult Index()
        {
            return PartialView("MessageForm", new MessageForm());
        }
        [HttpPost]
        public ActionResult HandleFormSubmit(MessageForm model)
        {
            if (!ModelState.IsValid) { return CurrentUmbracoPage(); }

            IContent BMessage = Services.ContentService.CreateContent(model.Sender, CurrentPage.Id, "BoardMessage");
            BMessage.SetValue("sender", model.Sender);
            BMessage.SetValue("message", model.Message);

            Services.ContentService.SaveAndPublishWithStatus(BMessage);

            return RedirectToCurrentUmbracoPage();
        }
    }
}