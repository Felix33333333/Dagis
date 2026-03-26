
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Kommunikation : MonoBehaviour
{
    public TMP_Text contactText;

    // Klass för kontakt
    public class Contact
    {
        public string name;
        public string parentName;
        public string phone;
        public string email;

        public Contact(string n, string p, string ph, string e)
        {
            name = n;
            parentName = p;
            phone = ph;
            email = e;
        }
    }

    List<Contact> contacts = new List<Contact>();
   
    void Start()
    {
        // Fake kontakter
        contacts.Add(new Contact("Yannic", "Maria", "070-123 45 67", "maria.yannic@gmail.com"));
        contacts.Add(new Contact("Anna", "Johan", "070-234 56 78", "johan.anna@gmail.com"));
        contacts.Add(new Contact("Adam", "Sara", "070-345 67 89", "sara.adam@gmail.com"));
        contacts.Add(new Contact("Roger", "Peter", "070-456 78 90", "peter.roger@gmail.com"));
        contacts.Add(new Contact("Ludvig", "Karin", "070-567 89 01", "karin.ludvig@gmail.com"));
        contacts.Add(new Contact("Lukas", "Anders", "070-678 90 12", "anders.lukas@gmail.com"));
        Debug.Log("KNAPP TRYCKT");
    }

    // Koppla denna till knappen
    public void ShowContacts()
    {
        if (contactText.text == "")
        {
            contactText.text = "Kontakter:\n\n";

            foreach (Contact c in contacts)
            {
                contactText.text +=
                    "Elev: " + c.name + "\t" +
                    "Förälder: " + c.parentName + "\t" +
                    "Telefon: " + c.phone + "\t" +
                    "Email: " + c.email + "\n";
            }
        }
        else
        {
            contactText.text = "";
        }
    }
}
