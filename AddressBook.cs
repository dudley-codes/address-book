using System;
using System.Collections.Generic;

namespace TryCatchExercise
{
  public class AddressBook
  {
    private List<Contact> _contacts = new List<Contact>();
    public void AddContact(Contact contact)
    {
      _contacts.Add(contact);
    }

    public Contact GetByEmail(string email)
    {
      return _contacts[Email];
    }
  }

  public class Contact
  {
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Address { get; set; }

    public string FullName { get; set; }
  }
}