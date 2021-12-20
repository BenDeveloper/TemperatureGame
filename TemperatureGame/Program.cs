// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int n = int.Parse(Console.ReadLine()); // the number of temperatures to analyse
string[] inputs = Console.ReadLine().Split(' ');
for (int i = 0; i < n; i++)
{
    int t = int.Parse(inputs[i]);// a temperature expressed as an integer ranging from -273 to 5526
}

// Write an answer using Console.WriteLine()
// To debug: Console.Error.WriteLine("Debug messages...");
int result = 0;

if (inputs != null ||
    n < 10000)
{

    if (int.TryParse(inputs[0], out result))
    {

        for (int i = 1; i < n; i++)
        {

            int resultToTest = 0;

            if (int.TryParse(inputs[i], out resultToTest))
            {
                Console.Error.WriteLine("inputs {0}", inputs[i]);

                // result is positive
                if (result > 0)
                {
                    // check i positive
                    if (resultToTest > 0)
                    {
                        if (result > resultToTest)
                        {
                            result = resultToTest;
                            Console.Error.WriteLine(result);
                        }
                    }
                    // check i negative
                    else
                    {
                        if (result > -resultToTest)
                        {
                            result = resultToTest;
                            Console.Error.WriteLine(result);
                        }
                    }
                }
                // else result negative
                else
                {
                    // check i positive
                    if (resultToTest > 0)
                    {
                        if ((result + resultToTest) == 0)
                        {
                            result = resultToTest;
                            Console.Error.WriteLine(result);
                        }
                        else if (result < -resultToTest)
                        {
                            result = resultToTest;
                            Console.Error.WriteLine(result);
                        }
                    }
                    // check i negative
                    else
                    {
                        if (result < resultToTest)
                        {
                            result = resultToTest;
                            Console.Error.WriteLine(result);
                        }
                    }
                }

                // result is zéro
                if (result == 0)
                {
                    break;
                }
            }

        }
    }
}

Console.WriteLine(result);
Console.ReadLine();