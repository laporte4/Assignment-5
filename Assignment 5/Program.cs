using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    class Program
    {
        static void Main(string[] args)
     
       
    {
        // read from a file
        StreamReader examScores;
        examScores = File.OpenText("C:\\Users\\LAPORTE4\\Downloads\\Scores.txt");

        // declare variables
        double score = 0.0;
        double total = 0.0;
        int countRecords = 0;
        int CountA = 0;
        int CountA2 = 0;
        int CountB = 0;
        int CountB2 = 0;
        int CountB3 = 0;
        int CountC = 0;
        int CountC2 = 0;
        int CountC3 = 0;
        int CountD = 0;
        int CountD2 = 0;
        int CountD3 = 0;
        double average = 0.0;
        int failScore = 0;

        //declare max and min
        double maxScore = 0.0;
        double minScore = 100;


        try
        {
            // while statement
            while (!examScores.EndOfStream)
            {
                if (double.TryParse(examScores.ReadLine(), out score))
                {
                    total = total + score;
                    countRecords++;

                    // finding the max and min scores
                    if (score >= 0 && score <= 100)
                    {
                        if (score > maxScore)
                        {
                            maxScore = score;

                        }

                        if (score < minScore)
                        {
                            minScore = score;
                        }

                        // using the if function to find the number of students with each grade
                        if (score >= 94)
                        {
                            CountA++;
                        }
                        else if (score >= 90)
                        {
                            CountA2++;
                        }
                        else if (score >= 87)
                        {
                            CountB++;
                        }
                        else if (score >= 83)
                        {
                            CountB2++;
                        }
                        else if (score >= 80)
                        {
                            CountB3++;
                        }
                        else if (score >= 77)
                        {
                            CountC++;
                        }
                        else if (score >= 73)
                        {
                            CountC2++;
                        }
                        else if (score >= 70)
                        {
                            CountC3++;
                        }
                        else if (score >= 67)
                        {
                            CountD++;
                        }
                        else if (score >= 63)
                        {
                            CountD2++;
                        }
                        else if (score >= 60)
                        {
                            CountD3++;
                        }
                        else
                        {
                            failScore++;
                        }
                    }
                }

            }



        }
        catch
        {
            Console.WriteLine("Insert a file");
        }


        // Declare the average
        average = total / countRecords;

        // WriteLines that show the user the number 
        examScores.Close();
        Console.WriteLine("Total: " + total);
        Console.WriteLine("Number of Students: " + countRecords);
        Console.WriteLine("Maximum Score: " + maxScore);
        Console.WriteLine("Minimum Score: " + minScore);
        Console.WriteLine("Average Score: " + average);
        Console.WriteLine("Score A : " + CountA);
        Console.WriteLine("Score A- : " + CountA2);
        Console.WriteLine("Score B+ : " + CountB);
        Console.WriteLine("Score B : " + CountB2);
        Console.WriteLine("Score B- : " + CountB3);
        Console.WriteLine("Score C+ : " + CountC);
        Console.WriteLine("Score C : " + CountC2);
        Console.WriteLine("Score C- : " + CountC3);
        Console.WriteLine("Score D+ : " + CountD);
        Console.WriteLine("Score D : " + CountD2);
        Console.WriteLine("Score D- : " + CountD3);
        Console.WriteLine("Fail: " + failScore);

        Console.ReadLine();
    }

}
}


 