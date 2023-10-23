using System;
using System.Collections.Generic;
using System.Text;
using Nop.Core;
using Nop.Core.Domain.Common;

namespace Nop.Services.Common
{
    public partial interface IContactForm
    {
        void DeleteAddress(ContactMessage msg);
        void InsertAddress(ContactMessage msg);
        void UpdateAddress(ContactMessage msg);

    }
}
