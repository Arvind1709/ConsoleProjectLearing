﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProjectLearing
{
    public class functionExample
    {
        /// <summary>
        /// Calculate the body mass index (BMI) based on weight in kg and height in meter
        /// </summary>
        /// <param name="weight">
        /// The weight in kilogram
        /// </param>
        /// <param name="height">
        /// The height in meter
        /// </param>
        /// <returns>
        /// The body mass index
        /// </returns>
        public double CalculateBMI(double weight, double height)
        {
            return weight / (height * height);
        }

        /// <summary>
        /// Get the weight status based on the Body Mass Index (BMI)
        /// </summary>
        ///<params name="bmi">
        ///The body mass index
        ///</params>
        /// A text string that represents the weight status
        ///<returns>
        ///WeightStatus
        ///</returns>
        public string GetWeightStatus(double bmi)
        {
            string weightStatus = "";

            switch (bmi)
            {
                case < 18.5:
                    weightStatus = "Underweight";
                    break;
                case >= 18.5 and <= 24.9:
                    weightStatus = "Healthy Weight";
                    break;
                case >= 25 and <= 29.9:
                    weightStatus = "Overweight";
                    break;
                case > 30:
                    weightStatus = "Obesity";
                    break;
            }
            return weightStatus;
        }


        ///<summary>
        /// Use it in main to practice
        ///</summary>

        //functionExample functionExample = new functionExample();

        //// main program
        //Console.WriteLine("Body Mass Index (BMI) Calculation");

        //Console.WriteLine("Enter a weight (kg):");
        //var weight = Convert.ToDouble(Console.ReadLine());

        //Console.WriteLine("Enter a height (m):");
        //var height = Convert.ToDouble(Console.ReadLine());


        //double bmi = functionExample.CalculateBMI(weight, height);
        //string weightStatus = functionExample.GetWeightStatus(bmi);

        //Console.WriteLine($"BMI: {bmi:0.#}");
        //Console.WriteLine($"Weight status:{weightStatus}");

       
    }
}
