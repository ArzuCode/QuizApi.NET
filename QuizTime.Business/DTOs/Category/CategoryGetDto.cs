﻿using System;

namespace QuizTime.Business.DTOs.Category
{
    public class CategoryGetDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int QuizCount { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
