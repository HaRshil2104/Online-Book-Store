﻿
using System.Collections.Generic;
using Bookstore.Models.ViewModel;

namespace BookStore.Models.Models
{
    public class ListResponse<T> where T : class
    {
        public IEnumerable<T> Records { get; set; }

        public int TotalRecords { get; set; }
    }
    
}
