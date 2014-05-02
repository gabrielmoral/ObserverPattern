using System;

namespace ObserverPattern
{
	class LocalNewspaperClient : NewspaperClient
	{
		public void UpdateNews (string news)
		{
			Console.WriteLine("Local news: " + news);
		}
	}
}

