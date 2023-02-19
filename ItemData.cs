using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using TMPro;
using UnityEngine;

public class ItemData : MonoBehaviour
{
    public static ItemData itemdata;

    public int AttackPlus;
    public int MagicAttackPlus;
    public int DefensePlus;
    public int MagicDefensePlus;
    public int enforce_item;
    private void Awake()
    {

        if (itemdata == null)
        {
            itemdata = this;
            //beastdata가 null 이면 이 오브젝트를 싱글톤으로 설정
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        itemdata.AttackPlus = 0;
        itemdata.MagicAttackPlus = 0;
        itemdata.DefensePlus = 0;
        itemdata.MagicDefensePlus = 0;
        itemdata.enforce_item = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(enforce_item > 0)
        {
            gameObject.transform.Find("GradeFrame").transform.Find("EnforceText").gameObject.SetActive(true);
            gameObject.transform.Find("GradeFrame").transform.Find("EnforceText").GetComponent<TextMeshProUGUI>().text = "+" + enforce_item;
        }
    }
}
