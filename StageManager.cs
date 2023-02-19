using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageManager : MonoBehaviour
{
    GameObject beast;
    // Start is called before the first frame update
    void Start()
    {


        beast = (GameObject)Instantiate(BeastData.beastdata.BeastPrefab,
            GameObject.Find("Player").transform.localPosition,
            Quaternion.Euler(0,0,0), GameObject.Find("Player").gameObject.transform);

        beast.transform.localRotation = Quaternion.Euler(0, 0, 0);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
