using System;
using System.Collections.Generic;
using System.Text;

namespace Nop.Core.Domain.Common
{
    public partial class ContactMessage:BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }

    }
}
