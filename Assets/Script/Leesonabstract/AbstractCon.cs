using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbstractCon : AbstractTypeA
{
    public override int a { get; set; } = 0;

    void Start()
    {
        Debug.Log(a);    
    }
}
