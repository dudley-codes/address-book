using System.Collections.Generic;

namespace TryCatchExercise
{
  public class AddressBook
  {
    public AddressBook()
    {
      contacts = new Dictionary<string, Contact>();
    }
    public Dictionary<string, Contact> contacts { get; set; }
    // private List<Contact> _contacts = new List<Contact>();
    public void AddContact(Contact contact)
    {
      contacts.Add(contact.Email, contact);
    }

    public Contact GetByEmail(string email)
    {
      return contacts[email];
    }
  }

  public class Contact
  {
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Address { get; set; }

    public string FullName
    {
      get
      {
        return $"{FirstName} {LastName}";
      }
    }
  }
}