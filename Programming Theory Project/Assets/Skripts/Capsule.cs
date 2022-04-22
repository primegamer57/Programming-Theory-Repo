using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsule : Shape
{
    protected override void DisplayText(string textToDisplay)
    {
        base.DisplayText(textToDisplay);
        transform.localScale = new Vector3(4, 2, 4);
    }
}
