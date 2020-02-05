using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basic : MonoBehaviour
{
    //Declare a variable for your (string)name, your (int) age, and (string) favorite color.
    string name = "Orion";
    public int age = 25;
    string color = "Black";

    void Start()
    {
        //Write a command that will print your name once to the console.
        Debug.Log(name);

        /*
         * Print a concatenated string that should say “Hi, my name is <yourName>, and my favorite color today is <color>!”
         * (Hint: You could use a temporary variable to keep track of things, you could accomplish this task in one line of code.)
        */
        Debug.Log("Hello! my name is " + name + " and my favorite color is " + color + "!");
    }

    void Update()
    {
        /*
         * Inside ‘Update’, write a command that will add 2 to your age variable(every frame), and reassign that sum back to the age variable.
         * Print the value of your age variable to the console.
        */
        age += 2;
        Debug.Log("Age: " + age);
    }
}
