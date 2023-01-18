using Platformer.Mechanics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public GameObject start, quit;
    public StartZone startZone;
    public QuitZone quitZone;

    public Animator transition;
    

    // Update is called once per frame
    void Update()
    {
        if (startZone.start)
        {
            SceneSwap(1);
        }
        if (quitZone.quit)
        {
            SceneSwap(2);
        }
    }

    public void SceneSwap(int ind)
    {
        StartCoroutine(LoadLevel(ind));
    }

    IEnumerator LoadLevel(int index)
    {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(index);
    }
}
