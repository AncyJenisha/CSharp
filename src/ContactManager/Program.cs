namespace ContactManager
{
    using System.Collections.Generic;
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<ContactManager> contact = new List<contacts>();
            ContactManager.Add("Ancy", "as", "hh", "gg");
            foreach (var contact in contactsManage)
            {
                Console.WriteLine(contact.Name);
                Console.WriteLine(contact.Phone);
                Console.WriteLine(contact.Email);
                Console.WriteLine(contact.AdditionalNotes);
            }
        }
    }
}