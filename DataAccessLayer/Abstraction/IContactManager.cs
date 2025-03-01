﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Class;

namespace DataAccessLayer.Abstraction
{
    public interface IContactManager<Contact>
    {
        void addContact (Contact contact);
        void removeContact (Contact contact);
        void updateContact (Contact contact);
        List<Contact> getAll ();
        Contact getContact ();
    }
}
