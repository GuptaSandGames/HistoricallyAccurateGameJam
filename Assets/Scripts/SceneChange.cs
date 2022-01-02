using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour {
  [SerializeField] private string nextScene;

  void OnTriggerEnter2D(Collider2D other)
  {
    if(other.CompareTag("Player"))
    {
      SceneManager.LoadScene(nextScene);
      if(nextScene =="Healers Hut") {
        Vector3 pos = other.gameObject.transform.position + new Vector3 (0f,-1f,0f);
        SaveSystem.SetValue("x",pos.x);
        SaveSystem.SetValue("y",pos.y);
        SaveSystem.SetValue("z",pos.z);
      }
    }
  }
}
