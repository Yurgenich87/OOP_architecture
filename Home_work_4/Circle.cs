namespace Home_work_4;

public class Circle : IShape
{
   private double radius;

   public Circle(double radius)
   {
      this.radius = radius;
   }

   public double GetArea()
   {
     return Math.PI * radius * radius;
      
   }

   public double GetPerimeter()
   {
       return 2 * Math.PI * radius;
   }

   public double GetRadius()
   {
      return radius;
   }

   public void SetRadius(double radius)
   {
      this.radius = radius;
   } 
   
}