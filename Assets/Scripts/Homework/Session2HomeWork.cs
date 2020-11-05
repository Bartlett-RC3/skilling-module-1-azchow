using System;
using System.Collections;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Diagnostics;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    
    //Colour Names Array
    string[] colours = {"black", "white","blue","yellow","purple"}

    


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(colours[1]);
        //LOOPS
        //For loop(counter,end condition,step)
        for (int counter = 0; Counter < colours.Length; counter = counter + 1) ;
         {
            Debug.Log("The current colour at pos " + counter);
            Debug.Log{colours[counter]};

         }
        int sumOfOddNumbers = 0;
        for (int i = 1; i < 100; i = i + 2) ;
        {
          sumOfOddNumbers+=i;
            Debug.Log("All odd numbers to 100 add to");
        }
        //shorthand for loop
        foreach (string currentColour in colours) ;
        {
            Debug.Log("I want to buy an apple " + currentColour);

        }
        //while loop(need a condition to end otherwise may break my computer)
        int whileCounter = 0;
        string apple;
        while (whileCounter < colours.Length) ;
        {
            apple += colours[whileCounter]+",";
            whileCounter+=2;
        }
        Debug.Log(apple);
        //CINDITIONALS(asking the computer questions)
        //If satement
        for (int i = 0; i =< 200; i++) ;
        {
            if (i % 2 == 0) ;
            {
                Debug.Log("Whole number:" + i);
            }
            else
            {
                Debug.Log("Odd mumber" + i);
            }
            //Asking multiple questions
            bool question1Answer = true;
            bool question2Answer = true;
            bool question3Answer =false;
            //Two conditions met(Concatenation)
            if (question1Answer && question2Answer) ;
            {
                Debug.Log("Both answers are ture");
            }
            //Or question(one condition is met form two)
            if (question1Answer || question3Answer)
            {
                Debug.Log("One of the answer is true");
            }
            //More than two questions
            if (question1Answer || question2Answer||question3Answer)
            {
               //Action here
                Debug.Log("One of the answer is true");
            }
            //question inside of question
            if (question1Answer==true)
            {
                if (question2Answer == true)
                {
                    if (question3Answer == false)
                }
            }








        }




    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
