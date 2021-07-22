/*****************************************************************
Program Name: Rectangle
Description : An application that calculates and displays areas and volumes 5 times, then displays a list of the results and their sums .
Programmer : Juanita Darns
Date : 7/22/2021
******************************************************************/

using System;

namespace rectangle
{
    // Rectangle class
    public class Rectangle{
        private float length, width, height; //Declaring instance variables

        // The class constructor which instantiates the Rectangle class with length, width, and height.
        public Rectangle(float length, float width, float height){
            this.length = length;
            this.width = width;
            this.height = height;
        }

    // Length property with a getter and a setter for the instance variable length.
    public float Length{
        get{
            return length;
        }
        set{
            length = value;
        }
    }

    // Width property with a getter and a setter for the instance variable width.
    public float Width{
        get{
            return width;
        }
        set{
            width = value;
        }
    }

    // Height property with a getter and a setter for the instance variable height.
    public float Height{
        get{
            return height;
        }
        set{
            height = value;
        }
    }

    // Method to calculate the area.
    public float calculateArea(float length, float width, float height){
        return (2*length*width) + (2*width*height) + (2*length*height);
    }

    // Method to calculate the volume.
    public float calculateVolume(float length, float width, float height){
        return length*width*height;
    }

    // Method to display the results
    public void displayResults(float area, float volume){
        Console.WriteLine("\nArea is: {0}", area);
        Console.WriteLine("Volume is: {0}", volume);
    }

    }
    class Program
    {
        static void Main(string[] args)
        {
            float[] resultsForVolume = new float[5]; //Array for the volumes declaration.
            float[] resultsForArea = new float[5];  //Array for the areas declaration.
            int counter = 0;// Counter for the while loop.

            while (counter < 5){ //Loop 5 times.
                Console.WriteLine("\nEnter values:");

                Console.Write("Length: "); //Prompt the user for length.
                float length = float.Parse(Console.ReadLine());

                Console.Write("Width: "); //Prompt the user for width.
                float width = float.Parse(Console.ReadLine());

                Console.Write("Height: "); //Prompt the user for height.
                float height = float.Parse(Console.ReadLine());

                Rectangle rectangle = new Rectangle(length, width, height); //Create an instance of the Rectangle class.

                // Calculate the area and volume using the given values.
                float area = rectangle.calculateArea(length, width,height); 
                float volume = rectangle.calculateVolume(length, width,height);

                rectangle.displayResults(area, volume);
                
                // Add the volume and area results to the respective arrays, in the index equal to the current iteration.
                resultsForArea[counter] = area;
                resultsForVolume[counter] = volume;
                
                // Check whether this is the last iteration and display the areas and volumes arrays, and the sums of their elements if yes.
                if (counter == 4){
                    Console.WriteLine("Volumes results: {0}", String.Join(',', resultsForVolume));
                    float volumeSum = 0;

                    for (int i = 0; i<resultsForVolume.Length; i++){
                        volumeSum += resultsForVolume[i];
                    }

                    Console.WriteLine("Total volume: {0}", volumeSum);

                    Console.WriteLine("\nArea results: {0}", String.Join(',', resultsForArea));
                    float areaSum = 0;

                    for (int i = 0; i<resultsForArea.Length; i++){
                        areaSum += resultsForArea[i];
                    }
                    
                    Console.WriteLine("Total area: {0}", areaSum);
                }
                //Increment the counter for the while loop after every run.
                counter++;
            }

        }
    }
}
