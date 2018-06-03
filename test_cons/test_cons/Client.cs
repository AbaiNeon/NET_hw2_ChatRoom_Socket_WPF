using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace test_cons
{
    public class Client
    {
        public string Name { get; set; }
        public Socket Socket { get; set; }
    }
}