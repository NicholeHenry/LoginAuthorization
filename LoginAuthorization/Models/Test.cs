using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginAuthorization.Models
{
    public class Test
    {
        string HelloWorld = "Hello, it works";
        public string HelloWorldMessage
        {
            get
            { return this.HelloWorld; }
            set
            { this.HelloWorld = value; }
        }
    }
}
