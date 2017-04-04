﻿using MvcApplication2.Models;
using MvcApplication2.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MvcApplication2.Controllers
{
    public class ContactController : ApiController
    {
        public Contact[] Get()
        {
            return contactRepository.GetAllContacts();
        }
        private ContactRepository contactRepository;

        public ContactController()
        {
            this.contactRepository = new ContactRepository();
        } 
        
    }
}
