using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuUI : MonoBehaviour
{
    [SerializeField] private Button startButton;

    public void StartButton()
    {
        SceneManager.LoadScene(1);
    }
}
