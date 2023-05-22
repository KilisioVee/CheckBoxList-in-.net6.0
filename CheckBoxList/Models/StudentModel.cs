using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CheckBoxList.Models
{
    public class StudentModel
    {
        public IList<SelectListItem> StudentNames { get; set; }
    }
}