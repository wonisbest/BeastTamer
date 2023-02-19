using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Inventory_MainLobby : MonoBehaviour
{
    public int Equipment_N = -1; // sword = 1 , helmet = 2, amor = 3, shield = 4, gloves = 5, shoes = 6,
    GameObject tagCheck;

    public Sprite BasicSword;
    public Sprite BasicHelmet;
    public Sprite BasicAmor;
    public Sprite BasicShield;
    public Sprite BasicGloves;
    public Sprite BasicShoes;

    public TextMeshProUGUI stat_Health;
    public TextMeshProUGUI stat_Attack;
    public TextMeshProUGUI stat_Defense;
    public TextMeshProUGUI stat_Friendship;

    public TextMeshProUGUI statplus_Attack;
    public TextMeshProUGUI statplus_MagicAttack;
    public TextMeshProUGUI statplus_Defense;
    public TextMeshProUGUI statplus_MagicDefense;

    public int statplus_Attack_Sword;
    public int statplus_MagicAttack_Sword;
    public int statplus_Defense_Sword;
    public int statplus_MagicDefense_Sword;

    public int statplus_Attack_Helmet;
    public int statplus_MagicAttack_Helmet;
    public int statplus_Defense_Helmet;
    public int statplus_MagicDefense_Helmet;

    public int statplus_Attack_Amor;
    public int statplus_MagicAttack_Amor;
    public int statplus_Defense_Amor;
    public int statplus_MagicDefense_Amor;

    public int statplus_Attack_Shield;
    public int statplus_MagicAttack_Shield;
    public int statplus_Defense_Shield;
    public int statplus_MagicDefense_Shield;

    public int statplus_Attack_Gloves;
    public int statplus_MagicAttack_Gloves;
    public int statplus_Defense_Gloves;
    public int statplus_MagicDefense_Gloves;

    public int statplus_Attack_Shoes;
    public int statplus_MagicAttack_Shoes;
    public int statplus_Defense_Shoes;
    public int statplus_MagicDefense_Shoes;

    public int statplus_Attack_int;
    public int statplus_MagicAttack_int;
    public int statplus_Defense_int;
    public int statplus_MagicDefense_int;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        StatText();
        StatPlusText();
    }
    public void StatText()
    {
        stat_Health.text = BeastData.beastdata.Stat_Health.ToString();
        stat_Attack.text = BeastData.beastdata.Stat_Attack.ToString();
        stat_Defense.text = BeastData.beastdata.Stat_Defense.ToString();
        stat_Friendship.text = BeastData.beastdata.Stat_Friendship.ToString();
    }

    public void StatPlusText()
    {
        statplus_Attack_int = statplus_Attack_Sword + statplus_Attack_Amor + statplus_Attack_Helmet + statplus_Attack_Shield + statplus_Attack_Gloves + statplus_Attack_Shoes;
        statplus_MagicAttack_int = statplus_MagicAttack_Sword + statplus_MagicAttack_Amor + statplus_MagicAttack_Helmet + statplus_MagicAttack_Shield + statplus_MagicAttack_Gloves + statplus_MagicAttack_Shoes;
        statplus_Defense_int = statplus_Defense_Sword + statplus_Defense_Amor + statplus_Defense_Helmet + statplus_Defense_Shield + statplus_Defense_Gloves + statplus_Defense_Shoes;
        statplus_MagicDefense_int = statplus_MagicDefense_Sword + statplus_MagicDefense_Amor + statplus_MagicDefense_Helmet + statplus_MagicDefense_Shield + statplus_MagicDefense_Gloves + statplus_MagicDefense_Shoes;

        BeastData.beastdata.AttackPlus = statplus_Attack_int;
        BeastData.beastdata.MagicAttackPlus = statplus_MagicAttack_int;
        BeastData.beastdata.DefensePlus = statplus_Defense_int;
        BeastData.beastdata.MagicDefensePlus = statplus_MagicDefense_int;

        statplus_Attack.text = statplus_Attack_int.ToString();
        statplus_MagicAttack.text = statplus_MagicAttack_int.ToString();
        statplus_Defense.text = statplus_Defense_int.ToString();
        statplus_MagicDefense.text = statplus_MagicDefense_int.ToString();
    }
    public void Equipment_Sword()
    {
        if (Equipment_N != -1)
        {
            if (GameObject.Find("SquareButton_Focus").gameObject.activeSelf)
            { GameObject.Find("SquareButton_Focus").SetActive(false); }
        }


        GameObject.Find("EquipFrameSword").transform.Find("SquareButton_Focus").gameObject.SetActive(true);

        Equipment_N = 1;
    }
    public void Equipment_Helmet()
    {
        if (Equipment_N != -1)
        {
            if (GameObject.Find("SquareButton_Focus").gameObject.activeSelf)
            { GameObject.Find("SquareButton_Focus").SetActive(false); }
        }


        GameObject.Find("EquipFrameHelmet").transform.Find("SquareButton_Focus").gameObject.SetActive(true);

        Equipment_N = 2;
    }
    public void Equipment_Amor()
    {
        if (Equipment_N != -1)
        {
            if (GameObject.Find("SquareButton_Focus").gameObject.activeSelf)
            { GameObject.Find("SquareButton_Focus").SetActive(false); }
        }


        GameObject.Find("EquipFrameAmor").transform.Find("SquareButton_Focus").gameObject.SetActive(true);

        Equipment_N = 3;
    }
    public void Equipment_Shield()
    {
        if (Equipment_N != -1)
        {
            if (GameObject.Find("SquareButton_Focus").gameObject.activeSelf)
            { GameObject.Find("SquareButton_Focus").SetActive(false); }

        }


        GameObject.Find("EquipFrameShield").transform.Find("SquareButton_Focus").gameObject.SetActive(true);

        Equipment_N = 4;
    }

    public void Equipment_Gloves()
    {
        if (Equipment_N != -1)
        {
            if (GameObject.Find("SquareButton_Focus").gameObject.activeSelf)
            { GameObject.Find("SquareButton_Focus").SetActive(false); }

        }


        GameObject.Find("EquipFrameGloves").transform.Find("SquareButton_Focus").gameObject.SetActive(true);

        Equipment_N = 5;
    }
    public void Equipment_Shoes()
    {
        if (Equipment_N != -1)
        {
            if (GameObject.Find("SquareButton_Focus").gameObject.activeSelf)
            { GameObject.Find("SquareButton_Focus").SetActive(false); }
        }


        GameObject.Find("EquipFrameShoes").transform.Find("SquareButton_Focus").gameObject.SetActive(true);

        Equipment_N = 6;
    }

    public void Equipment_Cancle() {
        if (Equipment_N != -1)
        {
            if (GameObject.Find("SquareButton_Focus").gameObject.activeSelf)
            { GameObject.Find("SquareButton_Focus").SetActive(false); }
            switch(Equipment_N)
            {
                case 1:
                    if(GameObject.Find("EquipFrameSword").transform.Find("Icon").GetComponent<Image>().sprite != BasicSword)
                    {
                        GameObject.Find("EquipFrameSword").transform.Find("Icon").GetComponent<Image>().sprite = BasicSword;
                    }
                    break;
                case 2:
                    if (GameObject.Find("EquipFrameHelmet").transform.Find("Icon").GetComponent<Image>().sprite != BasicHelmet)
                    {
                        GameObject.Find("EquipFrameHelmet").transform.Find("Icon").GetComponent<Image>().sprite = BasicHelmet;
                    }
                    break;
                case 3:
                    if (GameObject.Find("EquipFrameAmor").transform.Find("Icon").GetComponent<Image>().sprite != BasicAmor)
                    {
                        GameObject.Find("EquipFrameAmor").transform.Find("Icon").GetComponent<Image>().sprite = BasicAmor;
                    }
                    break;
                case 4:
                    if (GameObject.Find("EquipFrameShield").transform.Find("Icon").GetComponent<Image>().sprite != BasicShield)
                    {
                        GameObject.Find("EquipFrameShield").transform.Find("Icon").GetComponent<Image>().sprite = BasicShield;
                    }
                    break;
                case 5:
                    if (GameObject.Find("EquipFrameGloves").transform.Find("Icon").GetComponent<Image>().sprite != BasicGloves)
                    {
                        GameObject.Find("EquipFrameGloves").transform.Find("Icon").GetComponent<Image>().sprite = BasicGloves;
                    }
                    break;
                case 6:
                    if (GameObject.Find("EquipFrameShoes").transform.Find("Icon").GetComponent<Image>().sprite != BasicShoes)
                    {
                        GameObject.Find("EquipFrameShoes").transform.Find("Icon").GetComponent<Image>().sprite = BasicShoes;
                    }
                    break;

            }
            Equipment_N = -1;
        }
    }

    public void Equipment_CompareTag()
    {
        switch (Equipment_N)
        {
            case 1:
                if (EventSystem.current.currentSelectedGameObject.CompareTag("Equipment_Sword")) //눌려진 버튼의 태그가 같으면
                {
                    // 갖다 놓기
                    GameObject.Find("EquipFrameSword").transform.Find("Icon").GetComponent<Image>().sprite = EventSystem.current.currentSelectedGameObject.transform.Find("GradeFrame").transform.Find("ItemIcon").GetComponent<Image>().sprite;
                    if (GameObject.Find("SquareButton_Focus").gameObject.activeSelf)
                    { GameObject.Find("SquareButton_Focus").SetActive(false); }
                    statplus_Attack_Sword = EventSystem.current.currentSelectedGameObject.GetComponent<ItemData>().AttackPlus;
                    statplus_MagicAttack_Sword = EventSystem.current.currentSelectedGameObject.GetComponent<ItemData>().MagicAttackPlus;
                    statplus_Defense_Sword = EventSystem.current.currentSelectedGameObject.GetComponent<ItemData>().DefensePlus;
                    statplus_MagicDefense_Sword = EventSystem.current.currentSelectedGameObject.GetComponent<ItemData>().MagicDefensePlus;

                    Equipment_N = -1;
                }
                break;
            case 2:
                if (EventSystem.current.currentSelectedGameObject.CompareTag("Equipment_Helmet")) //눌려진 버튼의 태그가 같으면
                {
                    // 갖다 놓기
                    GameObject.Find("EquipFrameHelmet").transform.Find("Icon").GetComponent<Image>().sprite = EventSystem.current.currentSelectedGameObject.transform.Find("GradeFrame").transform.Find("ItemIcon").GetComponent<Image>().sprite;
                    if (GameObject.Find("SquareButton_Focus").gameObject.activeSelf)
                    { GameObject.Find("SquareButton_Focus").SetActive(false); }
                    statplus_Attack_Helmet = EventSystem.current.currentSelectedGameObject.GetComponent<ItemData>().AttackPlus;
                    statplus_MagicAttack_Helmet = EventSystem.current.currentSelectedGameObject.GetComponent<ItemData>().MagicAttackPlus;
                    statplus_Defense_Helmet = EventSystem.current.currentSelectedGameObject.GetComponent<ItemData>().DefensePlus;
                    statplus_MagicDefense_Helmet = EventSystem.current.currentSelectedGameObject.GetComponent<ItemData>().MagicDefensePlus;

                    Equipment_N = -1;
                }
                break;
            case 3:
                if (EventSystem.current.currentSelectedGameObject.CompareTag("Equipment_Amor")) //눌려진 버튼의 태그가 같으면
                {
                    // 갖다 놓기
                    GameObject.Find("EquipFrameAmor").transform.Find("Icon").GetComponent<Image>().sprite = EventSystem.current.currentSelectedGameObject.transform.Find("GradeFrame").transform.Find("ItemIcon").GetComponent<Image>().sprite;
                    if (GameObject.Find("SquareButton_Focus").gameObject.activeSelf)
                    { GameObject.Find("SquareButton_Focus").SetActive(false); }
                    statplus_Attack_Amor = EventSystem.current.currentSelectedGameObject.GetComponent<ItemData>().AttackPlus;
                    statplus_MagicAttack_Amor = EventSystem.current.currentSelectedGameObject.GetComponent<ItemData>().MagicAttackPlus;
                    statplus_Defense_Amor = EventSystem.current.currentSelectedGameObject.GetComponent<ItemData>().DefensePlus;
                    statplus_MagicDefense_Amor = EventSystem.current.currentSelectedGameObject.GetComponent<ItemData>().MagicDefensePlus;

                    Equipment_N = -1;
                }

                break;
            case 4:
                if (EventSystem.current.currentSelectedGameObject.CompareTag("Equipment_Shield")) //눌려진 버튼의 태그가 같으면
                {
                    // 갖다 놓기
                    GameObject.Find("EquipFrameShield").transform.Find("Icon").GetComponent<Image>().sprite = EventSystem.current.currentSelectedGameObject.transform.Find("GradeFrame").transform.Find("ItemIcon").GetComponent<Image>().sprite;
                    if (GameObject.Find("SquareButton_Focus").gameObject.activeSelf)
                    { GameObject.Find("SquareButton_Focus").SetActive(false); }
                    statplus_Attack_Shield = EventSystem.current.currentSelectedGameObject.GetComponent<ItemData>().AttackPlus;
                    statplus_MagicAttack_Shield = EventSystem.current.currentSelectedGameObject.GetComponent<ItemData>().MagicAttackPlus;
                    statplus_Defense_Shield = EventSystem.current.currentSelectedGameObject.GetComponent<ItemData>().DefensePlus;
                    statplus_MagicDefense_Shield = EventSystem.current.currentSelectedGameObject.GetComponent<ItemData>().MagicDefensePlus;

                    Equipment_N = -1;
                }

                break;
            case 5:
                if (EventSystem.current.currentSelectedGameObject.CompareTag("Equipment_Gloves")) //눌려진 버튼의 태그가 같으면
                {
                    // 갖다 놓기
                    GameObject.Find("EquipFrameGloves").transform.Find("Icon").GetComponent<Image>().sprite = EventSystem.current.currentSelectedGameObject.transform.Find("GradeFrame").transform.Find("ItemIcon").GetComponent<Image>().sprite;
                    if (GameObject.Find("SquareButton_Focus").gameObject.activeSelf)
                    { GameObject.Find("SquareButton_Focus").SetActive(false); }
                    statplus_Attack_Gloves = EventSystem.current.currentSelectedGameObject.GetComponent<ItemData>().AttackPlus;
                    statplus_MagicAttack_Gloves = EventSystem.current.currentSelectedGameObject.GetComponent<ItemData>().MagicAttackPlus;
                    statplus_Defense_Gloves = EventSystem.current.currentSelectedGameObject.GetComponent<ItemData>().DefensePlus;
                    statplus_MagicDefense_Gloves = EventSystem.current.currentSelectedGameObject.GetComponent<ItemData>().MagicDefensePlus;

                    Equipment_N = -1;
                }

                break;
            case 6:
                if (EventSystem.current.currentSelectedGameObject.CompareTag("Equipment_Shoes")) //눌려진 버튼의 태그가 같으면
                {
                    // 갖다 놓기
                    GameObject.Find("EquipFrameShoes").transform.Find("Icon").GetComponent<Image>().sprite = EventSystem.current.currentSelectedGameObject.transform.Find("GradeFrame").transform.Find("ItemIcon").GetComponent<Image>().sprite;
                    if (GameObject.Find("SquareButton_Focus").gameObject.activeSelf)
                    { GameObject.Find("SquareButton_Focus").SetActive(false); }
                    statplus_Attack_Shoes = EventSystem.current.currentSelectedGameObject.GetComponent<ItemData>().AttackPlus;
                    statplus_MagicAttack_Shoes = EventSystem.current.currentSelectedGameObject.GetComponent<ItemData>().MagicAttackPlus;
                    statplus_Defense_Shoes = EventSystem.current.currentSelectedGameObject.GetComponent<ItemData>().DefensePlus;
                    statplus_MagicDefense_Shoes = EventSystem.current.currentSelectedGameObject.GetComponent<ItemData>().MagicDefensePlus;

                    Equipment_N = -1;
                }

                break;


            case -1:
                break;
        }
    }
}
