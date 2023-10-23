using System;
using System.Collections.Generic;
using System.Text;
using Nop.Core.Domain.Common;
using Nop.Data;
using Nop.Services.Events;
using OfficeOpenXml.FormulaParsing.Excel.Functions.RefAndLookup;

namespace Nop.Services.Common
{
    public class ContactForm:IContactForm
    {
        private readonly IEventPublisher _eventPublisher;
        private readonly IRepository<ContactMessage> _contactRepository;
        public ContactForm(IEventPublisher eventpublisher, IRepository<ContactMessage> contactMessage)
        {
            _eventPublisher = eventpublisher;
            _contactRepository = contactMessage;
        }

        public void DeleteAddress(ContactMessage msg)
        {
            if (msg == null)
                throw new ArgumentNullException(nameof(msg));

            _contactRepository.Delete(msg);

            //event notification
            _eventPublisher.EntityDeleted(msg);
        }

        public void InsertAddress(ContactMessage msg)
        {
            if (msg == null)
                throw new ArgumentNullException(nameof(msg));


            //some validation


            _contactRepository.Insert(msg);

            //event notification
            _eventPublisher.EntityInserted(msg);
        }

        public void UpdateAddress(ContactMessage msg)
        {
            if (msg == null)
                throw new ArgumentNullException(nameof(msg));


            _contactRepository.Update(msg);

            //event notification
            _eventPublisher.EntityUpdated(msg);
        }
    }
}
