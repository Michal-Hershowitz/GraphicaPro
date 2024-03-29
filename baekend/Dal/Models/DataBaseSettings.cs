﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal.Interface;

namespace Dal.Models
{
    public class DataBaseSettings : IDataBaseSettings
    {
        public string ConnectionString { get; set; } = String.Empty;//מימוש הפונקציות מהאינטרפייס 

        public string DatabaseName { get; set; } = String.Empty;//מימוש הפונקציות מהאינטרפייס

        public string CollectionEmployee { get; set; } = String.Empty;//ממימוש הפונקציות מהאינטרפייס
        public string CollectionCustomer { get; set; } = String.Empty;//ממימוש הפונקציות מהאינטרפייס
        public string CollectionContract { get; set; } = String.Empty;//ממימוש הפונקציות מהאינטרפייס

    }
}
