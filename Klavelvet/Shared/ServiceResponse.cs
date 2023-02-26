using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Klavelvet.Shared
{
    public class ServiceResponse<T>
    {
        public T? Data { get; set; }

        public bool Success { get; set; }

        public string Message { get; set; } = string.Empty;
    }
}
