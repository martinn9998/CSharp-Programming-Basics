//Група     trail	cross-country	downhill	road
//juniors	5.50	 8	             12.25	     20
//seniors	 7	     9.50	          13.75  	21.50


int juniorBikers = int.Parse(Console.ReadLine());
int seniorBikers = int.Parse(Console.ReadLine());
string typeTrack = Console.ReadLine();
double priceJuniors = 0, priceSeniors = 0, priceSum = 0; 
switch (typeTrack)
{
    case "trail":
        priceJuniors = 5.50;
        priceSeniors = 7;
        break;
    case "cross-country":
        if (juniorBikers + seniorBikers >= 50)
        {
            priceJuniors = 8 * 0.75;
            priceSeniors = 9.50 * 0.75;
        }
        else
        {
            priceJuniors = 8;
            priceSeniors = 9.50;
        }
        break;
    case "downhill":
        priceJuniors = 12.25;
        priceSeniors = 13.75;
        break;
    case "road":
        priceJuniors = 20;
        priceSeniors = 21.50;
        break;
}
priceSum = priceJuniors * juniorBikers + priceSeniors *  seniorBikers;
double expences = priceSum * 0.05;
double remaining = priceSum - expences;
Console.WriteLine($"{remaining:f2}");