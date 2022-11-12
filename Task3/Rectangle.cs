public class Rectangle:Shape{
    protected double width=1.0;
    protected double length=1.0;
    public Rectangle(){

    } 
    public Rectangle (double width,double length)
    {

    }
    public Rectangle (Color color,bool filled,double width,double length  ) :base(color,filled)
    {

    }
    public double GetWidth(){
return width;
    }
    public void SetWidth(double width){
this.width=width;
    }
      public double GetLength(){
return length;
    }
    public void SetLenth(double lenth){
this.length=lenth;
    }
    public  override double GetArea(){
        return length*width;
    }
    public override double GetPerimetr(){
return 2*(length+width);
    }
    public string toString(){
 return "Square , Rectangle" + color + "," + filled + ", "+  width + ", " + length;
    }
}