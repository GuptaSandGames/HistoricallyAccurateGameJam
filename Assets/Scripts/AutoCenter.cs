using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class AutoCenter : MonoBehaviour
{
    public Canvas cancan;
    public Camera cam;
    // Start is called before the first frame update
    void Start()
    {
      cancan = gameObject.GetComponent<Canvas>();
      cam = Camera.main;
      cancan.worldCamera = cam;

    }

    // Update is called once per frame
    void Update()
    {

    }
}
