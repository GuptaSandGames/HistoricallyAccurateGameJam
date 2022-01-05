using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
public class RecipieBookManager : MonoBehaviour
{
    public TextMeshProUGUI honeyTxt;
    public TextMeshProUGUI tulipRootsTxt;
    public TextMeshProUGUI whiteRootsTxt;
    public TextMeshProUGUI brandyTxt;
    public TextMeshProUGUI racoonGreaseTxt;
    public TextMeshProUGUI anemoneSeedsTxt;
    public GameObject parent;
    GameObject[] panels = new GameObject[3];
    public GameObject activePanel;

    // Start is called before the first frame update
    void Start()
    {
      int children = parent.transform.childCount;
      for (int i = 0; i < children; ++i)
      {
        panels[i] = parent.transform.GetChild(i).gameObject;
      }
      activePanel = panels[0];

      honeyTxt.text = "- " + SaveSystem.GetInventoryLevel("honey").ToString();
      tulipRootsTxt.text = "- " + SaveSystem.GetInventoryLevel("tulipRoots").ToString();
      whiteRootsTxt.text = "- " + SaveSystem.GetInventoryLevel("whiteRoots").ToString();
      brandyTxt.text = "- " + SaveSystem.GetInventoryLevel("brandy").ToString();
      racoonGreaseTxt.text = "- " + SaveSystem.GetInventoryLevel("racoonGrease").ToString();
      anemoneSeedsTxt.text = "- " + SaveSystem.GetInventoryLevel("anemoneSeeds").ToString();

    }

    public void nextPage() {
      for(int i = 0; i < panels.Length; i++)
      {
        if (activePanel == panels[i]) {
          activePanel.SetActive(false);
          int index = i+1;
          if (index%panels.Length == 0) {
            i=-1;
          }
          activePanel = panels[i+1];
          activePanel.SetActive(true);
          return;
        }
      }
    }

    public void exit() {
      SceneManager.LoadScene(4);
    }
}
