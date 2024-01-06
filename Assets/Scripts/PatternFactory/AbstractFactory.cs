using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractFactory: MonoBehaviour
{


    public  float Yofset = 2;
    public abstract void GetProduct(Vector3 position);




}
