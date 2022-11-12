 abstract public  class Shape{
  protected Color color;
protected bool filled=true;

public Shape (){

}
public Shape ( Color color, bool filled )


{
    this.color=color;

}
public Color GetColor(){
    return color;
}
public void SetColor (Color color)
{
    this.color=color;
}

public abstract double GetArea();
public abstract double GetPerimetr();


public string toString(){
    return "Shape" + "["+ color + "," + filled + "]";
     }
}

public enum Color {
    Green,
    Red,
    Blue,
    Pink,
    Black
   
}