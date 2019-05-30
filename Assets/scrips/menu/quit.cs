using UnityEngine;
using System.Collections;

public class quit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void quitinthegame()
    {
        Application.Quit();
        Debug.Log("Выход работает");
    }
}
