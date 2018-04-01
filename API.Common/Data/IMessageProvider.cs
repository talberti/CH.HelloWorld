using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Common.Data
{
    public interface IMessageProvider
    {
        string Message
        {
            get;
        }
    }
}
