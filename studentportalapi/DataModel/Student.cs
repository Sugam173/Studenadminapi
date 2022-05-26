﻿namespace studentportalapi.DataModel
{
    public class Student
    {
        public Guid Id { get; set; }
        public String FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateofBirth { get; set; }
        public string Email { get; set; }
        public long Mobile { get; set; }
        public string? ProfileImageUrl { get; set; }
        public Guid GenderId { get; set; }

        //Navigation proprities
        public Gender Gender { get; set; }
        public Address Address { get; set; }




    }
}