public class Circle:Shape {
protected double radius =1.0;


public  Circle(){

}
public Circle (double radius)
{

}
public Circle (double radius,Color color,bool filled) :base(color,filled)
{

}
public double GetRadius(){
    return radius;
}
    public override double GetArea(){
        return radius* radius*Math.PI;
    }
    public override double GetPerimetr(){
return 2*Math.PI*radius;
    }
    public string toString(){
        
    }
}