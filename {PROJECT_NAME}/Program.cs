using System;
#if MONOMAC
using MonoMac.AppKit;
using MonoMac.Foundation;
#endif

namespace {PROJECT_NAME}
{
#if WINDOWS	
    public static class Program
    {
        public static void Main(string[] args)
        {
			using (var game = new Game())
				game.Run();
        }
    }
#elif MONOMAC
	class Program
	{
		static void Main (string[] args)
		{
			NSApplication.Init ();

			using (var p = new NSAutoreleasePool ()) {
				NSApplication.SharedApplication.Delegate = new AppDelegate ();				
				NSApplication.Main (args);
			}
		}
	}

	class AppDelegate : NSApplicationDelegate
	{
		private Game game;

		public override void FinishedLaunching (MonoMac.Foundation.NSObject notification)
		{
			game = new Game();
			game.Run();
		}

		public override bool ApplicationShouldTerminateAfterLastWindowClosed (NSApplication sender)
		{
			return true;
		}
	}    
#endif
}
