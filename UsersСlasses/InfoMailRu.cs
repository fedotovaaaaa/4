﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.UsersClasses;

namespace WindowsFormsApp1.UsersClasses
{
    internal class InfoMailRu : InfoEmail
    {
        public InfoMailRu(StringPair emailAdressTo, string subject, string body) :
                   base(emailAdressTo, subject, body)
        {
            SmtpClientAdress = "smtp.mail.ru";
            EmailAdressFrom = new StringPair("falconanastasia@mail.ru", "Федотова Анастасия Яновна");
            EmailPassword = "GcFspVtinsLasb5zn3dr";
            Port = -1;
        }
    }
}
