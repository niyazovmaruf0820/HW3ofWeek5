﻿using task4;
Counter counter = new Counter();
counter.Increase();
counter.Increase();
counter.Increase();
counter.Increase();
counter.Increase();
counter.Increase();
counter.Increase();
counter.Increase();
counter.Increase();
counter.Increase();
counter.Decrease();
counter.Decrease();
counter.Decrease();
counter.Decrease();
counter.Decrease();
counter.IncreaseBy(100);
counter.DecreaseBy(50);
System.Console.WriteLine(counter.Value);