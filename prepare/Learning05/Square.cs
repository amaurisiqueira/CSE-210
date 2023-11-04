public class Square: Shape {
    public override double GetArea(){
        return _side * _side ;
    }
    public Square(string color,double side ):base(color){
         _side  =  side  ;
        
    }
    private double _side;

}