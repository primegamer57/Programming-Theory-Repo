using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shape : MonoBehaviour
{
    [SerializeField] protected Color color;
    [SerializeField] protected string textToSet;
    protected bool isActive;
    
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Renderer>().material.color = color;
    }

    protected virtual void DisplayText(string textToDisplay)
    {
        SetScaleToDefault();
        GameManager.instance.SetText(textToDisplay);
    }

    private void OnMouseDown()
    {
        DisplayText(textToSet);
    }

    protected void SetScaleToDefault()
    {
        foreach (GameObject shape in GameManager.instance.shapes)
        {
            shape.transform.localScale = Vector3.one;
        }
    }
}
