﻿using System.Threading.Tasks;
using MyLeasing.Web.Data.Entities;
using MyLeasing.Web.Models;

namespace MyLeasing.Web.Helpers
{
    public interface IConverteHelper
    {
        Task<Property> ToPropertyAsync(PropertyViewModel model, bool isNew);

        PropertyViewModel ToPropertyViewModel(Property property);
    }
}