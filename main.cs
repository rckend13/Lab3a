using System;

class MainClass {
  public static void Main (string[] args) {
    double speed;
    double time;
    double distance;
    int counter=1;
    
    

    while(counter <=7){
      Console.WriteLine("Enter the distance covered by car#"+" "+ counter);
       distance = Convert.ToDouble(Console.ReadLine());
      Console.WriteLine("Enter the time taken by car# "+ ""+counter);
       time= Convert.ToDouble(Console.ReadLine());
       speed = distance/time;
       counter++;
       Console.WriteLine("The speed of this car is"+" "+ speed+ " "+ "miles per hour");

    }
    
  }
}