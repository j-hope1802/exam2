public class Circle{
    protected double radius;
    protected double Pi;
  
    public Circle(){

    } 
    public Circle (double radius)
    {

    }
  
    public double GetRadius(){
     return radius;
    }
    public void SetRadius(double radius){
this.radius=radius;
    }

    public double  GetArea(){
       return radius* radius*Math.PI;
    }
    public double GetCircumference(){
     return 2*Math.PI*radius;
    }
    public override string ToString(){
         return "Circle :" + radius;
    }
}
