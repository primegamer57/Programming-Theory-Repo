using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Shape
{
    protected override void DisplayText(string textToDisplay)
    {
        base.DisplayText(textToDisplay);
        transform.localScale = new Vector3(3, 3, 3);
    }
}
