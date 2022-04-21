//-------------------------------------------------------------------------
// <copyright file="Recipe.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;
using System.Collections;

namespace Full_GRASP_And_SOLID.Library
{
    public class Recipe
    {
        private ArrayList steps = new ArrayList();
        public ArrayList GetSteps()
        {
            return this.steps;
        }

        public Product FinalProduct { get; set; }

        public void AddStep(Step step)
        {
            this.steps.Add(step);
        }

        public void RemoveStep(Step step)
        {
            this.steps.Remove(step);
        }


        /// <summary>
        /// Para realizar el cambio se utilizó SRP, de tal manera que cada clase contenga una sola 
        /// responsabilidad.
        /// Por esa razón, se modificó la clase recipe, moviendo el método de imoresión de receta
        /// a una clase nueva, para que ambas tengan una sola razón de cambio. 
        /// </summary>

        public void PrintRecipe()
        {
            ConsolePrinter.Printer(steps, FinalProduct);
        }
    }
}