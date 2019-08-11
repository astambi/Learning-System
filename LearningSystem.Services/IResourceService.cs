﻿namespace LearningSystem.Services
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using LearningSystem.Services.Models.Courses;
    using LearningSystem.Services.Models.Resources;

    public interface IResourceService
    {
        Task<IEnumerable<CourseResourceServiceModel>> AllByCourseAsync(int courseId);

        Task<bool> CanBeDownloadedByUserAsync(int id, string userId);

        Task<bool> CreateAsync(int courseId, string fileName, string contentType, byte[] fileBytes);

        Task<ResourceDownloadServiceModel> DownloadAsync(int id);

        bool Exists(int id);

        Task<bool> RemoveAsync(int id);
    }
}
