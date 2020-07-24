//Created by: Remedios Meneses
//Student # : 300691712
//Last Mod : July 24, 2020 @ 5:45 PM
//Description: Classes and Interface
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    public abstract class Planet
    {   
        //variables 
         private double _diameter;
         private double _mass;
         private int _moonCount;
         private string _name;
         private double _orbitalPeriod;
         private int _ringCount;
         private double _rotationPeriod;
        
         //properties
         public double Diameter
         {
             get { return _diameter; }
         }

         public double Mass
         {
             get { return _mass; }
         }

         public int MoonCount
         {
             get { return _moonCount; }
             set { _moonCount = value; }
         }

         public string Name
         {
             get { return _name; }
         }

         public double OrbitalPeriod
         {
             get { return _orbitalPeriod; }
             set { _orbitalPeriod = value; }
         }

         public int RingCount
         {
             get { return _ringCount; }
             set { _ringCount = value; }
         }

         public double RotationPeriod
         {
             get { return _rotationPeriod; }
             set { _rotationPeriod = value; } 
         }
        
         //constructor - other classes access properties
         public Planet (string name, double diameter, double mass)
         {
             _name = name;
             _diameter = diameter;
             _mass = mass;

         }

        public override string ToString()
        {
            return $"\t{Name}\t{Diameter}\t{Mass}";
        }
    }
}
