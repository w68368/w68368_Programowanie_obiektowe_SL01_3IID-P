using Lab2.Constructions.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Constructions
{
    class Construction
    {
        public Construction(double height, double width, int entrances, int humanCapacity, BuildMaterialType buildMaterial)  // ctor tab*2
        {
            Height = height;
            Width = width;
            Entrances = entrances;
            HumanCapacity = humanCapacity;
            BuildMaterial = buildMaterial;
        }

        public Construction()
        {
            Height = 23;
            Width = 12;
            Entrances = 1;
            HumanCapacity = 1;
            BuildMaterial = BuildMaterialType.Wood;
        }
         public Construction(CreateConstructionDto input)
        {
            Height = input.Height;
            Width = input.Width;
            Entrances = input.Entrances;
            HumanCapacity = input.HumanCapacity;
            BuildMaterial = input.BuildMaterial;
        }
        public double Height { get; set; }
        public double Width { get; set; }
        public int Entrances { get; set; }
        public int HumanCapacity { get; set; }
        public BuildMaterialType BuildMaterial { 
           get
            {
                return _buildMaterial;
            }
            set
            {
               // if (value == string.Empty)
             //   {
              //      throw new ArgumentNullException();
              //  }
                _buildMaterial = value;
            }
        }
        private BuildMaterialType _buildMaterial { get; set; }


    }
}

