using System;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class script1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int integer1 = 5; //creating an integer variable
        float float1 = 45.3f;//creating a real variable
        char simvol = 'A';//creating a symbolic variable
        bool istina = true;//creating a boolean variable

        int integer2 = (int)float1; // converting a real variable to an integer
        float float2 = (float)integer1; // converting an integer variable to a real one
        bool expression1 = System.Convert.ToBoolean(float1); //converting a real variable to a boolean
        bool expression2 = System.Convert.ToBoolean(integer1);//converting an integer variable to a boolean

        string result = integer1 + " " + float1 + " " + simvol + " " + istina + " " + integer2 + " " + float2 + " " + expression1 + " " + expression2; //Creating a string where all the original variables were recorded and their transformation
        Debug.Log(result);

        StreamWriter sw = new StreamWriter("test.txt");
        sw.Write("integer1 = ");
        sw.WriteLine(integer1);
        sw.Write("float1 = ");
        sw.WriteLine(float1);
        sw.Write("simvol = ");
        sw.WriteLine(simvol);
        sw.Write("istina = ");
        sw.WriteLine(istina);
        sw.Write("integer2 = ");
        sw.WriteLine(integer2);
        sw.Write("float2 = ");
        sw.WriteLine(float2); 
        sw.Write("expression1 = ");
        sw.WriteLine(expression1);
        sw.Write("expression2 = ");
        sw.WriteLine(expression2);
        sw.Write("result = ");
        sw.WriteLine(result);
        sw.Close();

        StreamReader sr = new StreamReader("test.txt");
        Console.WriteLine(sr.ReadToEnd());
        sr.Close();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
