using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : Shape
{
    protected override void DisplayText(string textToDisplay)
    {
        base.DisplayText(textToDisplay);
        transform.localScale = new Vector3(2, 2, 2);
    }
}
