using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RecipieBookManager : MonoBehaviour
{
    public TextMeshProUGUI honeyTxt;
    public TextMeshProUGUI tulipRootsTxt;
    public TextMeshProUGUI whiteRootsTxt;
    public TextMeshProUGUI brandyTxt;
    public TextMeshProUGUI racoonGreaseTxt;
    public TextMeshProUGUI anemoneSeedsTxt;

    // Start is called before the first frame update
    void Start()
    {
      honeyTxt.text = "- " + SaveSystem.GetInventoryLevel("honey").ToString();
      tulipRootsTxt.text = "- " + SaveSystem.GetInventoryLevel("tulipRoots").ToString();
      whiteRootsTxt.text = "- " + SaveSystem.GetInventoryLevel("whiteRoots").ToString();
      brandyTxt.text = "- " + SaveSystem.GetInventoryLevel("brandy").ToString();
      racoonGreaseTxt.text = "- " + SaveSystem.GetInventoryLevel("racoonGrease").ToString();
      anemoneSeedsTxt.text = "- " + SaveSystem.GetInventoryLevel("anemoneSeeds").ToString();

    }

    // Update is called once per frame
    void Update()
    {

    }

    //FEVER - TULIP ROOTS - GRIND THEM - MIX IN HONEY - Feed to patient
}
