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
  public float imageScale = 1f;
  private RectTransform rt;
    // Start is called before the first frame update
    void Start()
    {
      rt = GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
      if(gameObject.name == "feverCure") {
        image.sprite = feverCure;
        rt.sizeDelta = new Vector2(28f*imageScale,40f*imageScale);
      }

      if(gameObject.name == "ground") {
        image.sprite = ground;
        imageScale = 1.36f;
        rt.sizeDelta = new Vector2(55*imageScale,52*imageScale);
      }

      if(gameObject.name == "unground") {
        image.sprite = unground;
        imageScale = 1f;
        rt.sizeDelta = new Vector2(84*imageScale,56*imageScale);
      }
    }
}
