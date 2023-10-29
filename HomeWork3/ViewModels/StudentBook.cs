using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HomeWork3.Models;

namespace HomeWork3.ViewModels
{
    public class StudentBook
    {
        public IEnumerable<students> studentsss { get; set; }
        public IEnumerable<books> booksss { get; set; }
    }
}