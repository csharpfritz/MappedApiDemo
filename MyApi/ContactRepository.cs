using System.Text.Json;

namespace MyApi;
public class ContactRepository {

	public IEnumerable<Contact> GetContacts() {
		var contacts = JsonSerializer.Deserialize<IEnumerable<Contact>>(
			File.ReadAllText("wwwroot/contacts.json")
		);
		return contacts;
	}

}
