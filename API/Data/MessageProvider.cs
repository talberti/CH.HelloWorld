using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using API.Common.Data;

namespace API.Data
{
    /// <summary>
    /// Implementation of the <see cref="IMessageProvider"/> interface.
    /// </summary>
    public class MessageProvider : IMessageProvider
    {

        /// <summary>
        /// Return the message.
        /// </summary>
        /// <returns>Returns "Hello World".</returns>
        public string Message
        {
            get
            {
                return "Hello World";
            }
        }
    }
}
