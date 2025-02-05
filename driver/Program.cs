long startWS = Environment.WorkingSet;
long startTicks = Environment.TickCount;
TestLib.Work();
long endWS = Environment.WorkingSet;
long endTicks = Environment.TickCount;
Console.WriteLine($"Cost per string literal (bytes): {(endWS - startWS)/10000}");
Console.WriteLine($"Cost per string literal (microseconds): {(endTicks - startTicks)/10.0}");
