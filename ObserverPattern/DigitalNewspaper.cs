using System;
using System.Collections.Generic;

namespace ObserverPattern
{
	class DigitalNewspaper : Observable
	{
		IList<NewspaperClient> newspaperClients; 

		public DigitalNewspaper ()
		{
			this.newspaperClients = new List<NewspaperClient>();
		}

		public void RegisterSubscriptor (NewspaperClient client)
		{
			this.newspaperClients.Add (client);
		}

		public void RemoveSubscriptor (NewspaperClient client)
		{
			this.newspaperClients.Remove (client);
		}

		public void SendLatestNews ()
		{
			string news = this.GetLatestNews ();

			foreach (var client in this.newspaperClients) 
			{
				client.UpdateNews (news);
			}
		}

		private String GetLatestNews()
		{
			return "This is the last news at " + DateTime.Now.ToString("hh.mm.ss.ffffff");
		}
	}
}

