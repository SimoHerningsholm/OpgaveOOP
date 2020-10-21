using System;
using System.Collections.Generic;
using System.Text;

namespace BL
{
    interface InstrumentRepository
    {
        /*
                public async Task<bool> CreateContactAsync(Contact contact)
        {
            //Alt sættes i trycatch hvis der skulle opstå et problem under eksekvering af kode.
            try
            {
                //Der simuleres 5 sekunders ekverkveringstid.
                await Task.Delay(5000);
                //Hvis kontakten der er sat som argument går igennem validering fortsætter den og prøver at skrive til databasen
                if(new Validator().validateContact(contact)) //(værdier skal være sat på alle properties og de skal have rigtig datatype)
                {
                    //Instanciere et databind objekt med henblik på at kunne kalde skrivnings metode for kontakter, for at skrive en ny kontakt til databasen
                    DataBind d = new DataBind();
                    //Skrivningsmetoden returnere true hvis den successfuldt har skrevet, ellers returnere den false. Resultatet returneres tilbage efter den har skrevet
                    return await d.WriteContactAsync(contact);
                }
                else 
                {
                    //Hvis ikke kontakten går igennem validering returneres der at false
                    return false;
                }
            }
            catch
            {
                //Har der været et problem under eksekvering af metoden returneres der false
                return false;
            }
        }
        public async Task<List<Contact>> ReadContactsAsObjectsAsync()
        {
            //Alt sættes i trycatch hvis der skulle opstå et problem under eksekvering af kode.
            try
            {
                //Der simuleres 5 sekunders ekverkveringstid.
                await Task.Delay(5000);
                //Instanciere et databind objekt med henblik på at kunne hente alle kontakter der er lagret i databasen
                DataBind d = new DataBind();
                //Kalder readallcontactasync metoden på databind objektet som returnere en liste af alle kontakter. Disse sættes i en ny liste kaldet contacts
                List<Contact> contacts = await d.ReadAllContactsAsync();
                //Alle de returnerede kontakter køres igennem en validering der tjekker om listen ikke er null og at der er sat værdier og om de har rigtige datatyper
                if(new Validator().validateContacts(contacts))
                {
                    //Køre den successfuldt gennem valideringen returneres listen af kontakter
                    return contacts;
                }
                //Hvis ikke den overholder valideringens krav returneres der null
                return null;
            }
            catch
            {
                //Har der været et problem under eksekvering af metoden returneres der false
                return null;
            }
        }
        public async Task<Contact> readContactAsync(Contact inContact)
        {
            //Alt sættes i trycatch hvis der skulle opstå et problem under eksekvering af kode.
            try
            {
                //Der simuleres 5 sekunders ekverkveringstid.
                await Task.Delay(5000);
                //Hvis kontakten der er sat som argument går igennem validering fortsætter den og prøver at skrive til databasen
                if (new Validator().validateContact(inContact))
                {
                    //Instanciere et databind objekt med henblik på at kunne hente en kontakt fra databasen ud fra id på den kontakt der er sat ind i metoden
                    DataBind d = new DataBind();
                    //Henter kontakt fra databasen  hvis det ikke har ladet sig gøre at hente den, er den sat til null, som returneres tilbage.
                    Contact contact = await d.ReadOneContactAsync(inContact);
                    //Kontakten eller null returneres tilbage
                    return contact;
                }
                else
                {
                    //Valideres kontakten til at være ukorrekt returneres der false
                    return null;
                }
            }
            catch
            {
                //Har der været et problem under ekvekveringen af metoden returneres der null
                return null;
            }
        }
        public async Task<bool> UpdateContactAsync(Contact contact)
        {
            //Alt sættes i trycatch hvis der skulle opstå et problem under eksekvering af kode.
            try
            {
                //Der simuleres 5 sekunders ekverkveringstid.
                await Task.Delay(5000);
                //Hvis kontakten successfuldt køre gennem validering, fortsætter den og prøver at opdatere den indsatte kontakt
                if (new Validator().validateContact(contact))
                {
                    //Instanciere et databind objekt med henblik på at kunne opdatere en kontakt i databasen ud fra id på den kontakt der er sat ind i metoden
                    DataBind d = new DataBind();
                    //hvis den successfuldt har kørt opdateringens metoden i databind returnere den true tilbage, ellers returnere den false tilbage. Dette returneres videre tilbage herfra
                    return await d.UpdateContactAsync(contact);
                }
                else
                {
                    //Valideres kontakten til at være ukorrekt returneres der false
                    return false;
                }
            }
            catch
            {
                //Har der været et problem under ekvekveringen af metoden returneres der null
                return false;
            }
        }
        public async Task<bool> DeleteContactAsync(Contact contact)
        {
            //Alt sættes i trycatch hvis der skulle opstå et problem under eksekvering af kode.
            try
            {
                //Der simuleres 5 sekunders ekverkveringstid.
                await Task.Delay(5000);
                //Hvis kontakten successfuldt køre gennem validering, fortsætter den og prøver at slette kontakten på basis af id på kontakten
                if (new Validator().validateContact(contact))
                {
                    //Instanciere et databind objekt med henblik på at kunne slette en kontakt i databasen ud fra id på den kontakt der er sat ind i metoden
                    DataBind d = new DataBind();
                    //hvis den successfuldt har kørt sletnings metoden fra databind returnere den true tilbage, ellers returnere den false tilbage. Dette returneres videre tilbage herfra
                    return await d.DeleteContactAsync(contact);
                }
                else
                {
                    //Er kontakt ikke valideret til at være korrekt returneres der false
                    return false;
                }
            }
            catch
            {
                //Har der været et problem under ekvekveringen af metoden returneres der null
                return false;
            }
        }
         */
    }
}
