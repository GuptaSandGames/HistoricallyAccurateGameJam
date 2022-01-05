using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ROOOTS : MonoBehaviour
{
  public Sprite unground;
  public Sprite ground;
  public Sprite feverCure;
  public Image image;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      if(gameObject.name == "feverCure"){
        image.sprite = feverCure;
        image.color = new Color32(255,0,0,255);
      }
      if(gameObject.name == "ground"){
        image.sprite = ground;
        image.color = new Color32(0,255,0,255);
      }
      if(gameObject.name == "unground"){
        image.sprite = unground;
        image.color = new Color32(0,0,255,255);
      }
    }
}
