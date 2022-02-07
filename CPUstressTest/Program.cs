Console.WriteLine("Stress test for CPU");
Console.WriteLine("Press enter to start...");
while (Console.ReadKey().Key == ConsoleKey.Enter) {
    for (int ix = 0; ix < Environment.ProcessorCount; ++ix)
    {
        new Thread(loopForever).Start();
    }
    while (true)
    {
        Console.WriteLine("Stress testing");
        while (true)
        {
            Console.WriteLine("Stress testing");
            while (true)
            {
                Console.WriteLine("Stress testing");
                while (true)
                {
                    Console.WriteLine("Stress testing");
                }
            }
        }
    }
}

static void loopForever()
{
    while (true) ;
}
