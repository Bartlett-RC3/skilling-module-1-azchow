using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Session1Homework : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
    //Declare a int variable and set a value
    public int myFisrstWholeNumber = 5;
    public int mySecondWholeNumber = 15;
    //Declare a float variable and set a value
    public float myFirstDecimalNumber = 5.5f;
    //Declare a string variable and set a value
    private string myFirstWords = "hello world!"
    //Create a function that prints the declared variables
    private int calculatorSum(int _FistNumuber, int _SecondNumuber, )
    {
        int sumResult = _FistNumuber + _SecondNumuber;
        return sumResult;
    }
    viod start()
    {
        int sumresult = calculatorSum（myfirstWholeNumber,mySecondWholeNumber）;
        Debug.log("adding two numbers result:" + sumresult.ToString());
    }
    void Update()
    //Declare and initialize an array
    public int[] myWholeNumberCollection = new int[5];
    public float[] myDecimalNumberCollection = { 1.5f, 2.5f, 3.5f };
    //Declare and initialize a list
    public List<int> myFistIntList = new List<int>();
    //Create and initialize a Dictionary


    public class HowToDictionaryInitializer
    {
        class StudentName
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int ID { get; set; }
        }

        public static void Main()
        {
            var students = new Dictionary<int, StudentName>()
        {
            { 111, new StudentName { FirstName="Sachin", LastName="Karnik", ID=211 } },
            { 112, new StudentName { FirstName="Dina", LastName="Salimzianova", ID=317 } },
            { 113, new StudentName { FirstName="Andy", LastName="Ruth", ID=198 } }
        };

            foreach (var index in Enumerable.Range(111, 3))
            {
                Console.WriteLine($"Student {index} is {students[index].FirstName} {students[index].LastName}");
            }
            Console.WriteLine();

            var students2 = new Dictionary<int, StudentName>()
            {
                [111] = new StudentName { FirstName = "Sachin", LastName = "Karnik", ID = 211 },
                [112] = new StudentName { FirstName = "Dina", LastName = "Salimzianova", ID = 317 },
                [113] = new StudentName { FirstName = "Andy", LastName = "Ruth", ID = 198 }
            };

            foreach (var index in Enumerable.Range(111, 3))
            {
                Console.WriteLine($"Student {index} is {students2[index].FirstName} {students2[index].LastName}");
            }
        }
    }



    
    
    {
        // Update is called once per frame


    }
}
