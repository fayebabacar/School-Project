﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace ProjetServiceWeb.Models
{
    public partial class OnlineCourse
    {
        public int CourseId { get; set; }
        public string Url { get; set; }

        public virtual Course Course { get; set; }
    }
}