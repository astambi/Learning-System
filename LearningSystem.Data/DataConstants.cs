﻿namespace LearningSystem.Data
{
    public class DataConstants
    {
        public const string StringMaxLength = "The {0} must be at max {1} characters long.";
        public const string StringMinMaxLength = "The {0} must be at least {2} and at max {1} characters long.";

        public const int ArticleTitleMinLength = 3;
        public const int ArticleTitleMaxLength = 50;
        public const int ArticleContentMinLength = 3;
        public const int ArticleContentMaxLength = 5000;
        public const string ArticlePublishDate = "The Publish date cannot be in the future.";

        public const int CourseNameMaxLength = 50;
        public const int CourseDescriptionMaxLength = 2000;
        public const string CourseEndDate = "The End date cannot be before the Start date.";
        public const string CourseStartDate = "The Start date cannot be in the past.";

        public const int FileMaxLengthInMb = 2;
        public const int FileMaxLengthInBytes = FileMaxLengthInMb * 1024 * 1024;
        public const string FileType = "zip";

        public const int UserNameMinLength = 2;
        public const int UserNameMaxLength = 100;
        public const int UserUsernameMaxLength = 50;
        public const string UserBirthdate = "The Birthdate cannot be in the future.";
    }
}
