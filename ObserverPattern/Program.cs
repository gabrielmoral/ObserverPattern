using System;

namespace ObserverPattern
{
	class Program
	{
		static void Main(string[] args)
		{
			DigitalNewspaper digitalNewspaper = new DigitalNewspaper ();

			NewspaperClient localNewspaperClient = new LocalNewspaperClient ();
			NewspaperClient nationalNewspaperClient = new NationalNewspaperClient ();

			digitalNewspaper.RegisterSubscriptor (localNewspaperClient);
			digitalNewspaper.RegisterSubscriptor (nationalNewspaperClient);

			digitalNewspaper.SendLatestNews ();

			digitalNewspaper.RemoveSubscriptor (localNewspaperClient);

			digitalNewspaper.SendLatestNews ();
		}

	}
}

