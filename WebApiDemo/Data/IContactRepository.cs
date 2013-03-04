using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiDemo.Data
{
    public interface IContactRepository
    {
        int Create(Models.Contact contact);
    }


    public class ContactRepository:IContactRepository
    {

        public int Create(Models.Contact contact)
        {
            return 1;
        }
    }
}