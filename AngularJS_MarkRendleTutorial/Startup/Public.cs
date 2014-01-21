using Simple.Web;
using System;
using System.Collections.Generic;
using System.Linq;
//using System.Web;

namespace AngularJS_MarkRendleTutorial.Startup
{
    public class Public:IStartupTask
    {
        public void Run(IConfiguration configuration, IWebEnvironment environment)
        {
            configuration.PublicFileMappings.Add("/", "/toto.htm");
            
            new Simple.Web.PublicFolder("/Content");
            //new Simple.Web.PublicFolder("/Scripts");
            new Simple.Web.PublicFolder("/Scripts");
        }
    }
}