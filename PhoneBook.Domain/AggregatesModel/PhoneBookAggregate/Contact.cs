using System;
using PhoneBook.Domain.SeedWork;

namespace PhoneBook.Domain.AggregatesModel.PhoneBookAggregate
{
    public class Contact : Entity, IAggregateRoot
    {

        private static  int _counter = 0;
        public DateTime CreateDateTime { get; private set; }
        public DateTime? UpdatedTime { get; private set; }
        
        public Name Name { get; private set; }
        
        public string Tag { get; private set; }
        
        public NumberType NumberType { get; private set; }
        
        public string Number { get; private set; }
        public string Email { get; private set; }
        public string Website { get; private set; }




        public Contact(Name name, string tag, int numberTypeId, string number, string email, string website)
        {
            SetId();
            CreateDateTime = DateTime.UtcNow;
            UpdatedTime = null;
            Name = name;
            Tag = $@"#{tag}";
            Number = number;
            Email = email;
            Website = website;
            SetNumberType(numberTypeId);

            // if (numberTypeId == 1)
            //     NumberType = NumberType.Landline;
            // else if (numberTypeId == 2)
            //     NumberType = NumberType.Mobile;
            // else if (numberTypeId == 3)
            //     NumberType = NumberType.Virtual;
            
        }

        public void UpdateContact(Name name, string tag, int numberTypeId, string number, string email, string website)
        {
            UpdatedTime = DateTime.UtcNow;;
            Name = name;
            Tag = $"#{tag}";
            Number = number;
            Email = email;
            Website = website;
            SetNumberType(numberTypeId);

            

        }

        private void SetId()
        {
            _counter++;
            Id = _counter;
        }
        
        private void SetNumberType(int numberTypeId)
        {
            if (numberTypeId == 1)
                NumberType = NumberType.Landline;
            else if (numberTypeId == 2)
                NumberType = NumberType.Mobile;
            else if (numberTypeId == 3)
                NumberType = NumberType.Virtual;
        }
        
    }
}