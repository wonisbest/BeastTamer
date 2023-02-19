using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainLobbyUI : MonoBehaviour
{
    GameObject beast;
    public Sprite UpgradeSprite;
    private Animator animator;
    private Rigidbody rigidbody;
    public string statplus;
    public int statpoint;
    public int level = 0;
    public int FriendshipCount = 0;
    public int allstat = 0;
    public TextMeshProUGUI stat_Health;
    public TextMeshProUGUI stat_Attack;
    public TextMeshProUGUI stat_Defense;
    public TextMeshProUGUI stat_Friendship;
    public TextMeshProUGUI stat_All;

    public TextMeshProUGUI LevelText_home;
    public TextMeshProUGUI LevelText_beast;
    public TextMeshProUGUI LevelText_equipment;

    public bool SecondEvolution = false;
    public bool ThirdEvolution = false;
    // Start is called before the first frame update
    private void Awake()
    {
        if (!GameObject.Find("Main Camera").transform.Find("Beast").gameObject.activeSelf) { 
            GameObject.Find("Main Camera").transform.Find("Beast").gameObject.SetActive(true);
        }

        beast = (GameObject)Instantiate(BeastData.beastdata.BeastPrefab,
            GameObject.Find("Main Camera").transform.Find("Beast").gameObject.transform.position, 
            Quaternion.Euler(0,180f,0), GameObject.Find("Main Camera").transform.Find("Beast").gameObject.transform);

        beast.transform.localScale = new Vector3(1, 1, 1);

        animator = beast.GetComponent<Animator>();

        rigidbody = beast.GetComponent<Rigidbody>();
        Destroy(rigidbody);
    }
    void Start()
    {
        //stat_Health = GameObject.Find("MainCanvas").transform.Find("Panel_Beasts").transform.Find("Right_Panel").transform.Find("Stats").transform.Find("Stat_Health").transform.Find("HealthValue").GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("MainCanvas").transform.Find("Panel_Beasts").gameObject.activeSelf) { 
        StatText();
        }
        LevelUpCheck();
        if (statpoint > 0)
        {
            GameObject.Find("MainCanvas").transform.Find("Panel_Beasts").transform.Find("Right_Panel").transform.Find("Stats").transform.Find("Stat_Health").transform.Find("StatPlusButton").gameObject.SetActive(true);
            GameObject.Find("MainCanvas").transform.Find("Panel_Beasts").transform.Find("Right_Panel").transform.Find("Stats").transform.Find("Stat_Attack").transform.Find("StatPlusButton").gameObject.SetActive(true);
            GameObject.Find("MainCanvas").transform.Find("Panel_Beasts").transform.Find("Right_Panel").transform.Find("Stats").transform.Find("Stat_Defense").transform.Find("StatPlusButton").gameObject.SetActive(true);
        }
        else
        {
            if(GameObject.Find("MainCanvas").transform.Find("Panel_Beasts").transform.Find("Right_Panel").transform.Find("Stats").transform.Find("Stat_Health").transform.Find("StatPlusButton").gameObject.activeSelf &&
            GameObject.Find("MainCanvas").transform.Find("Panel_Beasts").transform.Find("Right_Panel").transform.Find("Stats").transform.Find("Stat_Attack").transform.Find("StatPlusButton").gameObject.activeSelf &&
            GameObject.Find("MainCanvas").transform.Find("Panel_Beasts").transform.Find("Right_Panel").transform.Find("Stats").transform.Find("Stat_Defense").transform.Find("StatPlusButton").gameObject.activeSelf)
            { 
                GameObject.Find("MainCanvas").transform.Find("Panel_Beasts").transform.Find("Right_Panel").transform.Find("Stats").transform.Find("Stat_Health").transform.Find("StatPlusButton").gameObject.SetActive(false);
                GameObject.Find("MainCanvas").transform.Find("Panel_Beasts").transform.Find("Right_Panel").transform.Find("Stats").transform.Find("Stat_Attack").transform.Find("StatPlusButton").gameObject.SetActive(false);
                GameObject.Find("MainCanvas").transform.Find("Panel_Beasts").transform.Find("Right_Panel").transform.Find("Stats").transform.Find("Stat_Defense").transform.Find("StatPlusButton").gameObject.SetActive(false);
            }
        }

        if(BeastData.beastdata.level > 10 && !SecondEvolution)
        {
            if (!GameObject.Find("MainCanvas").transform.Find("Panel_Beasts").transform.Find("ChracterInfo").transform.Find("EvolutionButton").gameObject.activeSelf ) { 
            GameObject.Find("MainCanvas").transform.Find("Panel_Beasts").transform.Find("ChracterInfo").transform.Find("EvolutionButton").gameObject.SetActive(true);
            }
        }

        if (BeastData.beastdata.level > 30 && !ThirdEvolution)
        {
            if (!GameObject.Find("MainCanvas").transform.Find("Panel_Beasts").transform.Find("ChracterInfo").transform.Find("EvolutionButton").gameObject.activeSelf) { 
                GameObject.Find("MainCanvas").transform.Find("Panel_Beasts").transform.Find("ChracterInfo").transform.Find("EvolutionButton").gameObject.SetActive(true);
            }
        }
    }

    public void StatText()
    {
        stat_Health.text = BeastData.beastdata.Stat_Health.ToString();
        stat_Attack.text = BeastData.beastdata.Stat_Attack.ToString();
        stat_Defense.text = BeastData.beastdata.Stat_Defense.ToString();
        stat_Friendship.text = BeastData.beastdata.Stat_Friendship.ToString();

        allstat = BeastData.beastdata.Stat_Health + BeastData.beastdata.Stat_Attack + BeastData.beastdata.Stat_Defense + BeastData.beastdata.Stat_Friendship;
        stat_All.text = allstat.ToString();
        statpoint = BeastData.beastdata.statPoint;
    }

    public void LevelUpCheck()
    {
        if(level < BeastData.beastdata.level)
        {
            level = BeastData.beastdata.level;
            BeastData.beastdata.statPoint += 3;
        }

        if (GameObject.Find("MainCanvas").transform.Find("Panel_Beasts").gameObject.activeSelf)
        {
            LevelText_beast.text = level.ToString();
        }
        if (GameObject.Find("MainCanvas").transform.Find("Panel_Equipment").gameObject.activeSelf)
        {
            LevelText_equipment.text = level.ToString();
        }
        LevelText_home.text = level.ToString();
    }

    public void HomeMenu_Shop()
    {
        GameObject.Find("Beast").SetActive(false);
        GameObject.Find("MainCanvas").transform.Find("Panel_Shop_Chest").gameObject.SetActive(true);
    }
    public void HomeMenu_Beasts()
    {
        beast.transform.localPosition += new Vector3(-0.6f, 0, 0);
        GameObject.Find("MainCanvas").transform.Find("Panel_Beasts").gameObject.SetActive(true);

    }
    public void HomeMenu_Inventory()
    {
        beast.transform.localPosition += new Vector3(-1.9f,0.98f, 0); //(-1.9,0.25,-931.55)
        GameObject.Find("MainCanvas").transform.Find("Panel_Equipment").gameObject.SetActive(true);
    }
    public void HomeMenu_Upgrade()
    {
        GameObject.Find("Beast").SetActive(false);
        GameObject.Find("MainCanvas").transform.Find("Panel_Upgrade").gameObject.SetActive(true);
        GameObject.Find("MainCanvas").transform.Find("Panel_Upgrade").transform.Find("Upgrade").transform.Find("Left_Panel").transform.Find("Upgrade").transform.Find("background_upgrade").transform.Find("ItemIcon").GetComponent<Image>().sprite = UpgradeSprite;
    }

    public void SubMenu_Feeding()
    {
        animator.Play("Feeding");
        FriendshipCount++;
        if(FriendshipCount > 10)
        {
            FriendshipCount = 0;
            BeastData.beastdata.Stat_Friendship++;
        }
    }
    public void SubMenu_Touching()
    {
        animator.Play("Touching");
        FriendshipCount++;
        if (FriendshipCount > 10)
        {
            FriendshipCount = 0;
            BeastData.beastdata.Stat_Friendship++;
        }
    }
    public void SubMenu_Mission()
    {
        
    }

    public void Stage_Play()
    {
        GameObject.Find("Beast").SetActive(false);
        GameObject.Find("MainCanvas").transform.Find("Panel_Stage").gameObject.SetActive(true);
    }

    public void BackButton()
    {
        if (GameObject.Find("MainCanvas").transform.Find("Panel_Shop_Chest").gameObject.activeSelf)
        {
            GameObject.Find("Panel_Shop_Chest").SetActive(false);
        }
        else if (GameObject.Find("MainCanvas").transform.Find("Panel_Shop_Gold").gameObject.activeSelf)
        {
            GameObject.Find("Panel_Shop_Gold").SetActive(false);
        }
        else if (GameObject.Find("MainCanvas").transform.Find("Panel_Shop_Gem").gameObject.activeSelf)
        {
            GameObject.Find("Panel_Shop_Gem").SetActive(false);
        }
        else if (GameObject.Find("MainCanvas").transform.Find("Panel_Beasts").gameObject.activeSelf)
        {
            GameObject.Find("Panel_Beasts").SetActive(false);
            beast.transform.localPosition += new Vector3(0.6f, 0, 0);
        }
        else if (GameObject.Find("MainCanvas").transform.Find("Panel_Stage").gameObject.activeSelf)
        {
            GameObject.Find("Panel_Stage").SetActive(false);
        }
        else if (GameObject.Find("MainCanvas").transform.Find("Panel_Equipment").gameObject.activeSelf)
        {
            beast.transform.localPosition += new Vector3(1.9f, -0.98f, 0);
            GameObject.Find("Panel_Equipment").SetActive(false);
        }
        else if (GameObject.Find("MainCanvas").transform.Find("Panel_Upgrade").gameObject.activeSelf)
        {
            GameObject.Find("Panel_Upgrade").SetActive(false);
        }
        else if (GameObject.Find("MainCanvas").transform.Find("Panel_Settings").gameObject.activeSelf)
        {
            GameObject.Find("Panel_Settings").SetActive(false);
        }

        if (!GameObject.Find("Main Camera").transform.Find("Beast").gameObject.activeSelf)
        {
            GameObject.Find("Main Camera").transform.Find("Beast").gameObject.SetActive(true);
        }
    }

    public void EvolutionButton()
    {
        if(BeastData.beastdata.level > 10 && !SecondEvolution) {
            BeastData.beastdata.BeastPref += "_Second";
            SecondEvolution = true;
            Destroy(beast);
            BeastData.beastdata.BeastPrefab = Resources.Load(BeastData.beastdata.BeastPref);

            beast = (GameObject)Instantiate(BeastData.beastdata.BeastPrefab,
            GameObject.Find("Main Camera").transform.Find("Beast").transform.GetChild(0).transform.position  + new Vector3(0,0,0.1f),
            Quaternion.Euler(0, 180f, 0), GameObject.Find("Main Camera").transform.Find("Beast").gameObject.transform);

            GameObject.Find("MainCanvas").transform.Find("Panel_Beasts").transform.Find("ChracterInfo").transform.Find("EvolutionButton").gameObject.SetActive(false);
            rigidbody = beast.GetComponent<Rigidbody>();
            Destroy(rigidbody);

        }
        else if (BeastData.beastdata.level > 30 && !ThirdEvolution )
        {
            BeastData.beastdata.BeastPref += "_Third";
            ThirdEvolution = true;

            Destroy(beast);
            BeastData.beastdata.BeastPrefab = Resources.Load(BeastData.beastdata.BeastPref);

            beast = (GameObject)Instantiate(BeastData.beastdata.BeastPrefab,
            GameObject.Find("Main Camera").transform.Find("Beast").transform.GetChild(0).transform.position,
            Quaternion.Euler(0, 180f, 0), GameObject.Find("Main Camera").transform.Find("Beast").gameObject.transform);

            GameObject.Find("MainCanvas").transform.Find("Panel_Beasts").transform.Find("ChracterInfo").transform.Find("EvolutionButton").gameObject.SetActive(false);
            rigidbody = beast.GetComponent<Rigidbody>();
            Destroy(rigidbody);
        }

    }
    public void Stat_Plus_Button()
    {
        statplus = EventSystem.current.currentSelectedGameObject.transform.parent.GetComponent<Object>().name;
        switch (statplus)
        {
            case "Stat_Health":
                BeastData.beastdata.Stat_Health += 1;
                break;
            case "Stat_Attack":
                BeastData.beastdata.Stat_Attack += 1;
                break;
            case "Stat_Defense":
                BeastData.beastdata.Stat_Defense += 1;
                break;
        }
        BeastData.beastdata.statPoint--;
    }

    public void stage_1()
    {
        //스테이지 씬 불러오기
        
        SceneManager.LoadScene("Stage_1");
    }

    public void stage_2()
    {
        //스테이지 씬 불러오기

        SceneManager.LoadScene("Stage_2");
    }

    public void stage_3()
    {
        //스테이지 씬 불러오기

        SceneManager.LoadScene("Stage_3");
    }

    public void levelUp()
    {
        BeastData.beastdata.level++;
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
