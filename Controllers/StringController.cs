using Microsoft.AspNetCore.Mvc;
using Penguin.Cms.Core.Attributes;

namespace Penguin.Cms.Modules.Macros.Controllers
{
    public class StringController : Controller
    {
        [ShowMacro]
        public ActionResult Obfuscate(string toObfuscate)
        {
            return this.View((object)toObfuscate);
        }
    }
}