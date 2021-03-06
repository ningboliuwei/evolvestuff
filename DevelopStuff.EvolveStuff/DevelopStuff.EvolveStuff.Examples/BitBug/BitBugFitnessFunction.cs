﻿using System;
using System.Collections.Generic;
using System.Text;
using DevelopStuff.EvolveStuff.Core;

namespace DevelopStuff.EvolveStuff.Examples.BitBug
{
    public class BitBugFitnessFunction : FitnessFunction<Bug>
    {
        #region IFitnessFunction Members

        /// <summary>
        /// Calculates a <see cref="BitBug"/>s fitness based on an <see cref="Environment"/>.
        /// </summary>
        /// <param name="environment"></param>
        /// <param name="individual"></param>
        /// <returns></returns>
        public override double CalculateFitness(SimpleEnvironment<Bug> environment, Bug individual)
        {
            Bug arrayIndividual = individual;

            double total = 0;

            for (int i = 0; i < arrayIndividual.Values.Length; i++)
            {
                total += arrayIndividual.Values[i];
            }

            return ((total / arrayIndividual.Values.Length) * 100);
        }

        #endregion
    }
}
