using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class p1retrybttn : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void p1Retry(){
        StartCoroutine(retrybttn());
        Debug.Log("RETRY!!!");
    }
    public void p1Quit(){
        StartCoroutine(quitbttn());
        Debug.Log("QUIT!!!");
    }

    IEnumerator retrybttn(){
        yield return new WaitForSeconds(.1f);
        SceneManager.LoadScene(1);
    }
    IEnumerator quitbttn(){
        yield return new WaitForSeconds(.1f);
        SceneManager.LoadScene(0);
    }
}
