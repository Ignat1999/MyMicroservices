﻿using LecturalAPI.Models.dataBaseModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LecturalAPI.Models
{
    public class LessonTypeDB
    {
        [Key]
        public Guid id { get; set; }
        public string name { get; set; }
        public string shortNameOfType { get; set; }
        public string info { get; set; }
        public byte[]? MethodicDoc { get; set; }
        public byte[]? AdditionalInfoDoc { get; set; }
        public byte[]? Presentation { get; set; }
        public List<LessonDB> lessonDbs { get; set; }
    }
}
