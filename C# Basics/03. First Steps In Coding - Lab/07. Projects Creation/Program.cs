string architectName = Console.ReadLine();
int projectsAmount = int.Parse(Console.ReadLine());
int time = projectsAmount * 3;

Console.WriteLine($"The architect {architectName} will need {time} hours to complete {projectsAmount} project/s.");