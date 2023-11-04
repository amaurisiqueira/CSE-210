using System;

class Program
{
    static void Main(string[] args)
    {

         List<Shape> shapes = new ();
        Square cuadrado = new("green",5);
        shapes.Add(cuadrado);

        Console.WriteLine($"cuadrado de 5 = {cuadrado.GetArea()}");
        Rectangle rectagle = new("yellow",8, 5);
        shapes.Add(rectagle);
        
        Console.WriteLine($"Rectangle de 8 y 5  = {rectagle.GetArea()}");
        Circle cir= new( "brown",5 );
         shapes.Add(cir);

        Console.WriteLine($"Circle   5radius  = {cir.GetArea()}");
        
        foreach(Shape nn in shapes){
        Console.WriteLine($"{nn.GetColor()} = {nn.GetArea()}");
                
        }
 


    }
}