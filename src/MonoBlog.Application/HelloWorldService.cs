using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonoBlog
{
    public class HelloWorldService : MonoBlogAppService, IHelloWorldService
    {
        public string HelloWorld()
        {
            return $"Hello,World";
        }
    }
}
