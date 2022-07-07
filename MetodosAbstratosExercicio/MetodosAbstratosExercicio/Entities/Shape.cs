using System;
using MetodosAbstratosExercicio.Entities.Enum;
using System.Collections.Generic;
using System.Text;

namespace MetodosAbstratosExercicio.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

      

        public Shape(Color color)
        {
            Color = color;
        }


        //metodo abstrato, sintaxe:
        public abstract double Area();//isso me obriga a tornar a classe abstrata
        
        //obs.: não preciso colocar o virtual pra implementar na classe filha
        
    }
}
