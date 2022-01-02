using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class nextsceneinsecs : MonoBehaviour
{
    [SerializeField]
    private float delayBeforeLoading;
    [SerializeField]
    private string sceneNameToLoad;

    private float timeElapsed;

    // Start is called before the first frame update
    void Update()
    {
      timeElapsed += Time.deltaTime;

      if(timeElapsed > delayBeforeLoading) {
        SceneManager.LoadScene(sceneNameToLoad);
      }
    }
}
