﻿using System;

namespace Entities
{
    public class Member
    {
        public int Id { get; set; }

        public string LoginName { get; set; }

        public string FullName { get; set; }

        public string Email { get; set; }

        public DateTime DateOfBirth { get; set; }
    }
}