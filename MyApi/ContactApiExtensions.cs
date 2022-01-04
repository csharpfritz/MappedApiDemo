namespace MyApi;

public static class ContactApiExtensions
{
	public static void MapContactApi(this WebApplication app)
	{
		app.MapGet("/contacts", (ContactRepository repo) => {
			return repo.GetContacts();
		});
		app.MapGet("/contacts/{id:int}", (ContactRepository repo, int id) => {
			return repo.GetContacts()
			.FirstOrDefault(c => c.ContactId == id);
		});
	}
}