using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Minimalistic_MVC5.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string  Name { get; set; }
        public List<Resource> Resources { get; set; }
    }
}