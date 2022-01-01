using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{

    public Button play;
    public Button quit;
    // Start is called before the first frame update
    void Start()
    {
      play.onClick.AddListener(Play);
      quit.onClick.AddListener(Quit);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Play()
    {
      Debug.Log("PLAYING NOW");
    }

    public void Quit()
    {
      Application.Quit();
    }
}
