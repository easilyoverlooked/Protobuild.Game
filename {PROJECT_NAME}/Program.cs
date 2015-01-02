using System;

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
#endif
}
