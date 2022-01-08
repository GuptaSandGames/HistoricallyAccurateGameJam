using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Video;
public class nextsceneinsecs : MonoBehaviour
{
    [SerializeField]
    private float delayBeforeLoading;
    public VideoPlayer player;
    [SerializeField]
    private string sceneNameToLoad;

    private float timeElapsed;

    // Start is called before the first frame update
    void Update()
    {
      timeElapsed += Time.deltaTime;

      if(timeElapsed > player.clip.length) {
        SceneManager.LoadScene(sceneNameToLoad);
      }
    }
}
