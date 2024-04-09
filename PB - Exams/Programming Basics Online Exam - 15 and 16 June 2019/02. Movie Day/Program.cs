double timeOfRecording = double.Parse(Console.ReadLine());
double numberOfScenes = double.Parse(Console.ReadLine());
double timeDurationOfScene = double.Parse(Console.ReadLine());

double preparation = 0;
double timeForFilmingTheScenes = 0;
double necessaryTime = 0;

preparation = timeOfRecording * 0.15;
timeForFilmingTheScenes = numberOfScenes * timeDurationOfScene;
necessaryTime = preparation + timeForFilmingTheScenes;

if (necessaryTime>timeOfRecording)
{
    Console.WriteLine($"Time is up! To complete the movie you need {Math.Round(necessaryTime - timeOfRecording, 0)} minutes.");
}
else 
{
    Console.WriteLine($"You managed to finish the movie on time! You have {Math.Round(timeOfRecording - necessaryTime, 0)} minutes left!");
} 
    
    

