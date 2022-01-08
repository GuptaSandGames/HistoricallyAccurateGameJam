using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using PixelCrushers.DialogueSystem;

public class cutscenes : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      bool trigger = DialogueLua.GetVariable("TriggerCutscene").AsBool;
      if (trigger) {
        DialogueLua.SetVariable("TriggerCutscene",false);
        PixelCrushers.SaveSystem.LoadScene("FeverCutscene");
      }
    }
}
