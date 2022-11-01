using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace UnitTestProject
{
    public class ConsecutiveDivisorNumber
    {
        public static void Main(string[] args)
        {
            ConsecutiveDivisorNumber consecutiveDivisorNumberObj = new ConsecutiveDivisorNumber();
            int totalInputs = consecutiveDivisorNumberObj.AskUserForNumberOfInputs();
            List<long> totalConsecutiveDivisorList = consecutiveDivisorNumberObj.GetTotalDivisor(totalInputs);

            consecutiveDivisorNumberObj.ShowAllDivisor(totalConsecutiveDivisorList);
            Console.ReadLine();
        }

        public int AskUserForNumberOfInputs()
        {
            int totalInputs = Convert.ToInt32(Console.ReadLine());
            return totalInputs;
        }

        public long AskUserForInputs()
        {
            long input = Convert.ToInt64(Console.ReadLine());
            return input;
        }

        public List<long> GetTotalDivisor(int totalInputs)
        {
            List<long> totalConsecutiveDivisorList = new List<long>();

            for (int readInputs = 0; readInputs < totalInputs; readInputs++)
            {
                long input = AskUserForInputs();
                long numberOfDivisor = ConsecutiveDivisor(input);
                totalConsecutiveDivisorList.Add(numberOfDivisor);
            }

            return totalConsecutiveDivisorList;
        }

        public void ShowAllDivisor(List<long> totalConsecutiveDivisorList)
        {
            foreach (var showResult in totalConsecutiveDivisorList)
            {
                Console.WriteLine(showResult);
            }
        }

        public int ConsecutiveDivisor(long inputNumber)
        {
            int compareDivisor = 0;

            for (long indexCount = 1; indexCount < inputNumber; indexCount++)
            {
                List<long> firstDivisor = GetNumberOfDivisor(indexCount);
                List<long> secondDivisor = GetNumberOfDivisor(indexCount + 1);

                if (firstDivisor.Count == secondDivisor.Count)
                    compareDivisor++;
            }
            return compareDivisor;
        }

        public List<long> GetNumberOfDivisor(long divisorLimit)
        {
            List<long> totalDivisor = new List<long>();
            for (long divident = 1; divident < divisorLimit + 1; divident++)
            {
                if (divisorLimit % divident == 0)
                {
                    totalDivisor.Add(divident);
                }
            }
            return totalDivisor;
        }
    }
}