int goalStep = 10000;
int stepSum = 0;
int dayGoal = 0;
bool lessThan10000 = true;
bool ifGoalReached = true;
while (lessThan10000)
{
    string text = Console.ReadLine();
    if (text == "Going home")
    {
        dayGoal = int.Parse(Console.ReadLine());
        stepSum += dayGoal;
        if (stepSum < goalStep)
        {
            Console.WriteLine($"{goalStep - stepSum} more steps to reach goal.");
            lessThan10000 = false;
            ifGoalReached = false;
            break;
        }
        else if (stepSum >= goalStep)
        {
            lessThan10000 = false;
            break;
        }
    }
    dayGoal = int.Parse(text);
    stepSum += dayGoal;
    if (stepSum >= goalStep)
    {
        lessThan10000 = false;
    }

}
if (ifGoalReached)
{
    Console.WriteLine("Goal reached! Good job!");
    Console.WriteLine($"{stepSum - goalStep} steps over the goal!");
}