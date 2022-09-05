//-------------------------------------------------------------------------------
// <copyright file="Step.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------------

namespace Full_GRASP_And_SOLID.Library
{
// Patrón Experto: Se asigna la responsabilidad al al experto en los datos,  
// a la clase que tiene los datos necesarios para cumplir la responsabilidad
// en este caso la clase Step conoce la cantidad de tiempo consumido y de insumos; utilizando
// de la clase Product el costo de los insumos y de la clase Equipament el costo del equipamiento.
// En la clase Recipe se realiza sumariza los costos antes calculados en GetProductionCost() y los 
// imprime en PrintRecipe().
    public class Step
    {
        public Step(Product input, double quantity, Equipment equipment, int time)
        {
            this.Quantity = quantity;
            this.Input = input;
            this.Time = time;
            this.Equipment = equipment;
        }

        public Product Input { get; set; }

        public double Quantity { get; set; }

        public int Time { get; set; }

        public Equipment Equipment { get; set; }
        public double GetStepCost()
        {
            return
                (this.Input.UnitCost * this.Quantity) +
                (this.Equipment.HourlyCost * this.Time);
        }

    }
}