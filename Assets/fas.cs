using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fas : MonoBehaviour
{
    public string scenename;
    public string pointname;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D coll) {
      PixelCrushers.SaveSystem.LoadScene(scenename + "@" + pointname);
    }
}
