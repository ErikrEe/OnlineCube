using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class genericcode : MonoBehaviour
{
    public U GenericMethod<U>(U value1, U value2)
    {
        print(value1);
        return value2;
    }
    void Start()
    {
        string name;
        name = "welcome to 2020's game of the year";
        print(name);
    }
}