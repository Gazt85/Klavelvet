﻿namespace Klavelvet.Shared.Data_Transfer_Objects.Category
{
    public class CategoryDto
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public string Url { get; set; } = string.Empty;
    }
}
