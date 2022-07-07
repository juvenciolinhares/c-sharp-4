using System;
using System.Collections.Generic;
using System.Text;
using MetodosAbstratosExercicio.Entities.Enum;

/*
 * se eu não fiz um construtor vazio, a subclasse me obriga a fazer um consytrutor igual ao construtor não vazio
 */

namespace MetodosAbstratosExercicio.Entities
{
    internal class Rectangle : Shape

    {
        public double Width { get; set; }
        public double Height { get; set; }


        //crio um construtor com atributos da classe base e dessa classe
        public Rectangle(double width, double height, Color color ) : base( color )
        {
            Width = width;
            Height = height;
        }
              

        //preciso obrigatoriamente implementar o método abstrato(SOBRESCRITA)
        public override double Area()//ja tem o override sem implementar o virtual na classe pai
        {
            return Width * Height;
        }
    }
}
