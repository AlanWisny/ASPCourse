﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPCourse.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public String  Name { get; set; }
        public bool  IsSubscribedToNewsLetter { get; set; }

        public MembershipType MembershipType { get; set; }
        public byte MembershipTypeId { get; set; }
    }
}