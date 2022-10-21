//Lerissa Lazar
//09-14-22
//Reverse it
//the user is asked to enter a number or word and the computer will reverse the input they give.

Console.Clear();

int num, remainder;
int revNum = 0;
int length = 0;
bool validNum;
bool loop = true;
string input;
string revStr = "";

while (loop)
{

    Console.WriteLine("Enter a number or word: ");
    input = Console.ReadLine();

    validNum = int.TryParse(input, out num);

    if (validNum)
    {
        revNum = 0;
        while (num > 0)
        {
            remainder = num % 10;
            revNum = (revNum * 10) + remainder;
            num = num / 10;
        }
        Console.WriteLine(revNum);
    }
    else
    {
        revStr = "";
        length = input.Length - 1;
        while (length >= 0)
        {
            revStr = revStr + input[length];
            length--;
        }
        Console.WriteLine(revStr);
    }

    Console.WriteLine("Do you want to try again? Yes or no?");
    
    string playAgain;
    bool validInput = false;
    while(!validInput)
    {
        playAgain = Console.ReadLine().ToLower();
        validInput = true;
        if(playAgain == "yes")
        {
            validInput = true;
        }
        else if(playAgain == "no")
        {
            validInput = true;
            loop = false;
            Console.WriteLine("Thank you for playing, bye!");
        }
        else
        {
            validInput = false;
            Console.WriteLine("Invalid response, enter yes or no");
        }
    }
}