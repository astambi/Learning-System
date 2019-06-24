﻿namespace LearningSystem.Services.Models.Courses
{
    using AutoMapper;
    using LearningSystem.Services.Models.Users;

    public class CourseDetailsServiceModel
    {
        public CourseWithDescriptionServiceModel Course { get; set; }

        public UserServiceModel Trainer { get; set; }

        public int Students { get; set; }

        public bool IsUserEnrolled { get; set; }
    }
}
