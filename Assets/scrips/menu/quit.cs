using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class quit : MonoBehaviour

{
    // Start is called before the first frame update
    public int i = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    public void start()
    {

    }
    public void avtor()
    {
        Invoke("gotoavtor", 0.5f);
        
    }
    public void quitinthegame()
    {
        Invoke("quitthegame", 0.5f);
        Debug.Log("Выход работает");
    }
    IEnumerator vait(float second)
    {
        yield return new WaitForSeconds(second);
    }
    public void gotoavtor()
    {
        SceneManager.LoadScene("avtor");
    }
    public void quitthegame()
    {
        Application.Quit();
    }
    public void gotothegame()
    {

    }
}
