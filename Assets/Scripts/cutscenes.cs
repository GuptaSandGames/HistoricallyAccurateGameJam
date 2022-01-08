using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using PixelCrushers.DialogueSystem;

public class cutscenes : MonoBehaviour
{
    public string name;
    public string triggername;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      bool trigger = DialogueLua.GetVariable(triggername).AsBool;
      if (trigger) {
        DialogueLua.SetVariable(triggername,false);
        PixelCrushers.SaveSystem.LoadScene(name);
      }
    }
}
