﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ma1mariya.ViewModels
{
    public class ContactForm
    {
       // [Required]
        public string Sender { get; set; }
        //[Required]
        //[EmailAddress(ErrorMessage = "This is not a valid email address")]
        public string Email { get; set; }
        //[Required]
        public string Subject { get; set; }
        //[Required]
        public string Message { get; set; }
    }
}