using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class buttonclic : MonoBehaviour
    
{
    public AudioSource clicbutton;
    public AudioSource music;
    public quit z;
    // Start is called before the first frame update

    public void clik()
    {
        music.Stop();
        Debug.Log("-music");
        clicbutton.Play();
        Debug.Log("+effect button");
    }
}
