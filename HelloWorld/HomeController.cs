using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HelloWorld
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public string Index()
        {
            return "This is my default action...";
        }
        public string Xamarin(string name)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, welcome to Visual Studio for Mac");
        }
    }
}
