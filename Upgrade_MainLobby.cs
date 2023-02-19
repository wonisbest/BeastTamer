using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Upgrade_MainLobby : MonoBehaviour
{
    GameObject tmp;
    GameObject Upgrade_Item;
    public bool UpgradeBool = false;
    public int statplus_Attack = 0;
    public int statplus_MagicAttack = 0;
    public int statplus_Defense = 0;
    public int statplus_MagicDefense = 0;
    public int enforce_item = 0;

    public float Enforce_Probability = 100;
    public float Enforce_Result;
    public TextMeshProUGUI statplus_Attack_txt;
    public TextMeshProUGUI statplus_MagicAttack_txt;
    public TextMeshProUGUI statplus_Defense_txt;
    public TextMeshProUGUI statplus_MagicDefense_txt;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EnforceItemButton()
    {
        if (!UpgradeBool)
        {
            UpgradeBool = true;
            tmp = EventSystem.current.currentSelectedGameObject;
            EventSystem.current.currentSelectedGameObject.GetComponent<Image>().color = Color.yellow ;

            statplus_Attack = 0;
            statplus_MagicAttack = 0;
            statplus_Defense = 0;
            statplus_MagicDefense = 0;
            enforce_item = 0;
}
    }

    public void EnforceItemSelect()
    {
        if(UpgradeBool)
        {
            UpgradeBool = false;
            tmp.GetComponent<Image>().color = Color.white;

            tmp.transform.Find("ItemIcon").GetComponent<Image>().sprite = EventSystem.current.currentSelectedGameObject.transform.Find("GradeFrame").transform.Find("ItemIcon").GetComponent<Image>().sprite;
            enforce_item = EventSystem.current.currentSelectedGameObject.GetComponent<ItemData>().enforce_item;
            Upgrade_Item = EventSystem.current.currentSelectedGameObject;
            /*statplus_Attack = EventSystem.current.currentSelectedGameObject.GetComponent<ItemData>().AttackPlus;
            statplus_MagicAttack = EventSystem.current.currentSelectedGameObject.GetComponent<ItemData>().MagicAttackPlus;
            statplus_Defense = EventSystem.current.currentSelectedGameObject.GetComponent<ItemData>().DefensePlus;
            statplus_MagicDefense = EventSystem.current.currentSelectedGameObject.GetComponent<ItemData>().MagicDefensePlus;*/
            // ���� ��ġ

            if (EventSystem.current.currentSelectedGameObject.GetComponent<ItemData>().AttackPlus > 0) 
            { 
            statplus_Attack += (enforce_item+1) * 2;
            }
            if (EventSystem.current.currentSelectedGameObject.GetComponent<ItemData>().MagicAttackPlus > 0)
            { 
                statplus_MagicAttack += (enforce_item+1) * 2; 
            }
            if (EventSystem.current.currentSelectedGameObject.GetComponent<ItemData>().DefensePlus > 0)
            { 
                statplus_Defense += (enforce_item + 1) * 2; 
            }
            if (EventSystem.current.currentSelectedGameObject.GetComponent<ItemData>().MagicDefensePlus > 0)
            { 
                statplus_MagicDefense += (enforce_item + 1) * 2; 
            }
        }


        statplus_Attack_txt.text = "+" + statplus_Attack;
        statplus_MagicAttack_txt.text = "+" + statplus_MagicAttack;
        statplus_Defense_txt.text = "+" + statplus_Defense;
        statplus_MagicDefense_txt.text = "+" + statplus_MagicDefense;

    }

    public void Upgrade()
    {
        for(int i = 0; i <= enforce_item; i++)
        {
            if(i == 0) { 
            Enforce_Probability = 100 * (float)0.9;
            }
            else
            {
                Enforce_Probability = Enforce_Probability * (float)0.9;
            }
        }
         //Mathf.Pow(100 * (float) 0.9, enforce_item+1); // ��ȭ Ȯ��
        Enforce_Result = Random.Range(0, 100); // Ȯ�� ���� ũ�� ����
        if (Enforce_Probability >= Enforce_Result) // ����
        {
            //��� �����
            enforce_item++;
            Upgrade_Item.GetComponent<ItemData>().enforce_item = enforce_item; // ��ȭ ����++
            Upgrade_Item.GetComponent<ItemData>().AttackPlus += statplus_Attack;
            Upgrade_Item.GetComponent<ItemData>().MagicAttackPlus += statplus_MagicAttack;
            Upgrade_Item.GetComponent<ItemData>().DefensePlus += statplus_Defense;
            Upgrade_Item.GetComponent<ItemData>().MagicDefensePlus += statplus_MagicDefense;
            Debug.Log("��ȭ ����");
        }
        else //����
        {
            //��� �����
            Debug.Log("��ȭ ����");
        }
    }
}
