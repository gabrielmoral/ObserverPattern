using System;

namespace ObserverPattern
{
	class NationalNewspaperClient : NewspaperClient
	{
		public void UpdateNews (string news)
		{
			Console.WriteLine("National news: " + news);
		}
	}
}

