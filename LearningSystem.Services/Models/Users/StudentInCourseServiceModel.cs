﻿namespace LearningSystem.Services.Models.Users
{
    using System.Linq;
    using AutoMapper;
    using LearningSystem.Common.Mapping;
    using LearningSystem.Data.Models;

    public class StudentInCourseServiceModel : IMapFrom<StudentCourse>, IHaveCustomMapping
    {
        public string StudentId { get; set; }

        public string StudentUserName { get; set; }

        public string StudentEmail { get; set; }

        public string StudentName { get; set; }

        public Grade? Grade { get; set; }

        public bool HasExamSubmission { get; set; }

        public void ConfigureMapping(Profile mapper)
            => mapper
            .CreateMap<StudentCourse, StudentInCourseServiceModel>()
            .ForMember(
                dest => dest.HasExamSubmission,
                opt => opt.MapFrom(src => src.Student.ExamSubmissions.Any(e => e.CourseId == src.CourseId)));
    }
}
