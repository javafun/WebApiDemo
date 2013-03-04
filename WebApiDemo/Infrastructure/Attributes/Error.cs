using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebApiDemo.Infrastructure.Attributes
{
    public class Error
    {
        public string Name { get; set; }

        public string[] Message { get; set; }
    }
}
