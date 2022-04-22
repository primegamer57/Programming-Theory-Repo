using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance { get; set; }
    [SerializeField] private TextMeshProUGUI text;
    public List<GameObject> shapes;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    public void SetText(string textToSet)
    {
        text.text = textToSet;
    }
}
