using UnityEngine;
using System.Collections;


public class QuitManager : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.Delete))
        {
            Application.Quit();
        }
    }
}