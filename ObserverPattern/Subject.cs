using System;

namespace ObserverPattern
{
	interface Observable
	{
		void RegisterSubscriptor (NewspaperClient client);
		void RemoveSubscriptor(NewspaperClient client);
		void SendLatestNews();
	}
}

