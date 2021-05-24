# Play with C# task

## Tasks doc
https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task?view=net-5.0

## Run on VSCode (Select .NET 5.0 SDK)
https://code.visualstudio.com/docs/languages/dotnet

### PlayOne: Saturation of CPU usage
Run PlayOne to see how many tasks your computer can run without increase the execution time significantly.
Start with one task, get the average result, try with two tasks, get the average result, etc.

Obs.: More tasks = more work.

On my computer: 

- TASKS: 1 => Average execution time: 772ms (CPU usage: ~35%)
- TASKS: 2 => Average execution time: 780ms (CPU usage: ~50%)
- TASKS: 4 => Average execution time: 767ms (CPU usage: ~80%)
- TASKS: 5 => Average execution time: 756ms (CPU usage: ~95%)
- TASKS: 6 => Average execution time: 795ms (CPU usage: ~100%) 
- TASKS: 7 => Average execution time: 869ms (CPU usage: ~100%)
- TASKS: 8 => Average execution time: 979ms (CPU usage: ~100%)
- TASKS: 12 => Average execution time: 1515ms (CPU usage init: ~100%, CPU usage end: ~80%)

*(CPU usage includes all tasks running on my computer)

### PlayTwo: Using tasks to calculate prime numbers faster
Run PlayTwo to see how many time your computer spends to calculate the prime numbers until ~10000000 with N tasks. 
Try to discover the best number of tasks to complete the calculation with the minimun time.

Obs.: More tasks = same work, but divided.

On my computer: 

- TASKS: 1 => Average execution time: 3835ms (CPU usage: ~33%)
- TASKS: 4 => Average execution time: 1498ms (CPU usage: ~70%)
- TASKS: 6 => Average execution time: 1135ms (CPU usage: ~90%) 
- TASKS: 7 => Average execution time: 1065ms (CPU usage: ~98%) 
- TASKS: 8 => Average execution time: 1009ms (CPU usage: ~100%) 
- TASKS: 12 => Average execution time: 1023ms (CPU usage: ~100%)
- TASKS: 32 => Average execution time: 968ms (CPU usage: ~100%)
- TASKS: 64 => Average execution time: 977ms (CPU usage: ~100%)
- TASKS: 128 => Average execution time: 995ms (CPU usage: ~100%)
- TASKS: 256 => Average execution time: 1019ms (CPU usage: ~100%)
- TASKS: 512 => Average execution time: 1057ms (CPU usage: ~100%)

*(CPU usage includes all tasks running on my computer)

### Tested computer: 
- I7-7700HQ
- 16GB DDR4 2400 Mhz
- Windows 10
