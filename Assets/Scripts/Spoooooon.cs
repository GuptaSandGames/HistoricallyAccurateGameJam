using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spoooooon : MonoBehaviour
{
  public Sprite sadSpoon;
  public Sprite honeySpoon;
  public Sprite fatSpoon;
  public bool isHoney = false;
  private Image img;
    void Start()
    {
      img = gameObject.GetComponent<Image>();
    }

    void Update()
    {
    }

    public void changeSpoon(string type) {
      if (type == "Honey") {
        Debug.Log("?");
        img.sprite = honeySpoon;
        gameObject.name = "honeySpoon";
      }
    }
}
