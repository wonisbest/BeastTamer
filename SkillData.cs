using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SkillData : MonoBehaviour
{
    public struct Skill_
    {

        public string SkillName;
        public int SkillLevel;
        public Object SkillObject;
        public float SkillDamage;
        public float cooltime;
        public int TypeofSkill; //0: 물리 1:마법
        public int propertiesOfSkills; //0:파이터 1:파이어 2:얼음
        public Sprite ImageofSkill;
        public string AnimationofSkill;
    }

    public Skill_ skill_1;
    public Skill_ skill_2;
    public Skill_ skill_3;
    public Skill_ skill_4;

    Skill_ FireBall;
    Skill_ FirePunch;
    Skill_ Scratch;
    Skill_ DragonBite;
    public int skill_selected_ = -1;

    public int test_skill_level;
    public string test_skill_Animation;
    public string test_skill_name;
    void Start()
    {
        DontDestroyOnLoad(gameObject);

        FireBallSet();
        FirePunchSet();
        ScratchSet();
        DragonBiteSet();
    }

    // Update is called once per frame
    void Update()
    {
        
        //비스트 패널의 스킬셋 차일드 0번의 스킬 셋에서 skillName을 따와서 BeastData에서 스킬 정보 가져오기
    }
    void skill_test()
    {
        test_skill_Animation = skill_1.AnimationofSkill;
        test_skill_level = skill_1.SkillLevel;
        test_skill_name = skill_1.SkillName;

        Debug.Log(test_skill_Animation + " " +test_skill_level + " " + test_skill_name);
    }
    public void SkillSet_1()
    {
        if(skill_selected_ != -1)
        {
            if (GameObject.Find("SkillButton_Focus").gameObject.activeSelf)
            { GameObject.Find("SkillButton_Focus").SetActive(false); }
            
        }
        else if (skill_selected_ == 1)
        {
            if (GameObject.Find("SkillButton_Focus").gameObject.activeSelf)
            { GameObject.Find("SkillButton_Focus").SetActive(false); }
            skill_selected_ = -1;
            return;
        }

        GameObject.Find("Skill_Set_1").transform.Find("SkillButton").transform.Find("SkillButton_Focus").gameObject.SetActive(true);
        GameObject.Find("Skill_Set_1").transform.Find("SkillButton").transform.Find("SkillButton_Focus").transform.Find("Icon").GetComponent<Image>().sprite = GameObject.Find("Skill_Set_1").transform.Find("SkillButton").transform.Find("Icon").GetComponent<Image>().sprite;
        GameObject.Find("Skill_Set_1").transform.Find("SkillButton").transform.Find("SkillButton_Focus").transform.Find("Text").GetComponent<TextMeshProUGUI>().text = GameObject.Find("Skill_Set_1").transform.Find("SkillButton").transform.Find("Text").GetComponent<TextMeshProUGUI>().text;
        skill_selected_ = 1;
    }
    public void SkillSet_2()
    {
        if (skill_selected_ != -1)
        {
            if (GameObject.Find("SkillButton_Focus").gameObject.activeSelf)
            { GameObject.Find("SkillButton_Focus").SetActive(false); }
            
        }
        else if(skill_selected_ == 2)
        {
            if (GameObject.Find("SkillButton_Focus").gameObject.activeSelf)
            { GameObject.Find("SkillButton_Focus").SetActive(false); }
            skill_selected_ = -1;
            return;
        }
        GameObject.Find("Skill_Set_2").transform.Find("SkillButton").transform.Find("SkillButton_Focus").gameObject.SetActive(true);
        GameObject.Find("Skill_Set_2").transform.Find("SkillButton").transform.Find("SkillButton_Focus").transform.Find("Icon").GetComponent<Image>().sprite = GameObject.Find("Skill_Set_2").transform.Find("SkillButton").transform.Find("Icon").GetComponent<Image>().sprite;
        GameObject.Find("Skill_Set_2").transform.Find("SkillButton").transform.Find("SkillButton_Focus").transform.Find("Text").GetComponent<TextMeshProUGUI>().text = GameObject.Find("Skill_Set_2").transform.Find("SkillButton").transform.Find("Text").GetComponent<TextMeshProUGUI>().text;
        skill_selected_ = 2;
    }
    public void SkillSet_3()
    {
        if (skill_selected_ != -1)
        {
            if (GameObject.Find("SkillButton_Focus").gameObject.activeSelf)
            { GameObject.Find("SkillButton_Focus").SetActive(false); }
            
        }
        else if (skill_selected_ == 3)
        {
            if (GameObject.Find("SkillButton_Focus").gameObject.activeSelf)
            { GameObject.Find("SkillButton_Focus").SetActive(false); }
            skill_selected_ = -1;
            return;
        }

        GameObject.Find("Skill_Set_3").transform.Find("SkillButton").transform.Find("SkillButton_Focus").gameObject.SetActive(true);
        GameObject.Find("Skill_Set_3").transform.Find("SkillButton").transform.Find("SkillButton_Focus").transform.Find("Icon").GetComponent<Image>().sprite = GameObject.Find("Skill_Set_3").transform.Find("SkillButton").transform.Find("Icon").GetComponent<Image>().sprite;
        GameObject.Find("Skill_Set_3").transform.Find("SkillButton").transform.Find("SkillButton_Focus").transform.Find("Text").GetComponent<TextMeshProUGUI>().text = GameObject.Find("Skill_Set_3").transform.Find("SkillButton").transform.Find("Text").GetComponent<TextMeshProUGUI>().text;
        skill_selected_ = 3;
    }
    public void SkillSet_4()
    {
        if (skill_selected_ != -1)
        {
            if (GameObject.Find("SkillButton_Focus").gameObject.activeSelf)
            { GameObject.Find("SkillButton_Focus").SetActive(false); }
            

        }
        else if (skill_selected_ == 4)
        {
            if (GameObject.Find("SkillButton_Focus").gameObject.activeSelf)
            { GameObject.Find("SkillButton_Focus").SetActive(false); }
            skill_selected_ = -1;
            return;
        }

        GameObject.Find("Skill_Set_4").transform.Find("SkillButton").transform.Find("SkillButton_Focus").gameObject.SetActive(true);
        GameObject.Find("Skill_Set_4").transform.Find("SkillButton").transform.Find("SkillButton_Focus").transform.Find("Icon").GetComponent<Image>().sprite = GameObject.Find("Skill_Set_4").transform.Find("SkillButton").transform.Find("Icon").GetComponent<Image>().sprite;
        GameObject.Find("Skill_Set_4").transform.Find("SkillButton").transform.Find("SkillButton_Focus").transform.Find("Text").GetComponent<TextMeshProUGUI>().text = GameObject.Find("Skill_Set_4").transform.Find("SkillButton").transform.Find("Text").GetComponent<TextMeshProUGUI>().text;
        skill_selected_ = 4;
    }

    public void SkillSelect()
    {
        if (GameObject.Find("SkillButton_Focus").gameObject.activeSelf) 
        { GameObject.Find("SkillButton_Focus").gameObject.SetActive(false); } // 다른 포커스 지우기

        switch (skill_selected_) {
            case 1:
                skill_1.SkillName = EventSystem.current.currentSelectedGameObject.transform.Find("Text").GetComponent<TextMeshProUGUI>().text.ToString();
                // skillset 버튼에 고른 스킬의 icon, name 가져와서 대입해주기
                GameObject.Find("Skill_Set_1").transform.Find("SkillButton").transform.Find("Icon").GetComponent<Image>().sprite = EventSystem.current.currentSelectedGameObject.transform.Find("Icon").GetComponent<Image>().sprite;
                GameObject.Find("Skill_Set_1").transform.Find("SkillButton").transform.Find("Text").GetComponent<TextMeshProUGUI>().text = skill_1.SkillName;
                GameObject.Find("Skill_Set_1").transform.Find("SkillButton").transform.Find("SkillLevel").GetComponent<TextMeshProUGUI>().text = EventSystem.current.currentSelectedGameObject.transform.Find("SkillLevel").GetComponent<TextMeshProUGUI>().text; //Skill Level 가져오기
                GameObject.Find("Skill_Set_1").transform.Find("SkillButton").transform.Find("SkillDamage").GetComponent<TextMeshProUGUI>().text = EventSystem.current.currentSelectedGameObject.transform.Find("SkillDamage").GetComponent<TextMeshProUGUI>().text;
                GameObject.Find("Skill_Set_1").transform.Find("SkillButton").transform.Find("cooltime").GetComponent<TextMeshProUGUI>().text = EventSystem.current.currentSelectedGameObject.transform.Find("cooltime").GetComponent<TextMeshProUGUI>().text;
                GameObject.Find("Skill_Set_1").transform.Find("SkillButton").transform.Find("AnimationofSkill").GetComponent<TextMeshProUGUI>().text = EventSystem.current.currentSelectedGameObject.transform.Find("AnimationofSkill").GetComponent<TextMeshProUGUI>().text;

                Debug.Log(skill_1.SkillName);
                skill_1.ImageofSkill = GameObject.Find("Skill_Set_1").transform.Find("SkillButton").transform.Find("Icon").GetComponent<Image>().sprite;
                skill_1.SkillObject = Resources.Load(skill_1.SkillName);

                skill_1.SkillLevel = int.Parse(GameObject.Find("Skill_Set_1").transform.Find("SkillButton").transform.Find("SkillLevel").GetComponent<TextMeshProUGUI>().text);
                skill_1.SkillDamage = float.Parse(GameObject.Find("Skill_Set_1").transform.Find("SkillButton").transform.Find("SkillDamage").GetComponent<TextMeshProUGUI>().text);
                skill_1.cooltime = float.Parse(GameObject.Find("Skill_Set_1").transform.Find("SkillButton").transform.Find("cooltime").GetComponent<TextMeshProUGUI>().text);
                skill_1.AnimationofSkill = GameObject.Find("Skill_Set_1").transform.Find("SkillButton").transform.Find("AnimationofSkill").GetComponent<TextMeshProUGUI>().text;
                break;

            case 2:
                skill_2.SkillName = EventSystem.current.currentSelectedGameObject.transform.Find("Text").GetComponent<TextMeshProUGUI>().text.ToString();
                GameObject.Find("Skill_Set_2").transform.Find("SkillButton").transform.Find("Icon").GetComponent<Image>().sprite = EventSystem.current.currentSelectedGameObject.transform.Find("Icon").GetComponent<Image>().sprite;
                GameObject.Find("Skill_Set_2").transform.Find("SkillButton").transform.Find("Text").GetComponent<TextMeshProUGUI>().text = skill_2.SkillName;
                GameObject.Find("Skill_Set_2").transform.Find("SkillButton").transform.Find("SkillLevel").GetComponent<TextMeshProUGUI>().text = EventSystem.current.currentSelectedGameObject.transform.Find("SkillLevel").GetComponent<TextMeshProUGUI>().text; //Skill Level 가져오기
                GameObject.Find("Skill_Set_2").transform.Find("SkillButton").transform.Find("SkillDamage").GetComponent<TextMeshProUGUI>().text = EventSystem.current.currentSelectedGameObject.transform.Find("SkillDamage").GetComponent<TextMeshProUGUI>().text;
                GameObject.Find("Skill_Set_2").transform.Find("SkillButton").transform.Find("cooltime").GetComponent<TextMeshProUGUI>().text = EventSystem.current.currentSelectedGameObject.transform.Find("cooltime").GetComponent<TextMeshProUGUI>().text;
                GameObject.Find("Skill_Set_2").transform.Find("SkillButton").transform.Find("AnimationofSkill").GetComponent<TextMeshProUGUI>().text = EventSystem.current.currentSelectedGameObject.transform.Find("AnimationofSkill").GetComponent<TextMeshProUGUI>().text;

                skill_2.ImageofSkill = GameObject.Find("Skill_Set_2").transform.Find("SkillButton").transform.Find("Icon").GetComponent<Image>().sprite;
                skill_2.SkillObject = Resources.Load(skill_2.SkillName);

                skill_2.SkillLevel = int.Parse(GameObject.Find("Skill_Set_2").transform.Find("SkillButton").transform.Find("SkillLevel").GetComponent<TextMeshProUGUI>().text);
                skill_2.SkillDamage = float.Parse(GameObject.Find("Skill_Set_2").transform.Find("SkillButton").transform.Find("SkillDamage").GetComponent<TextMeshProUGUI>().text);
                skill_2.cooltime = float.Parse(GameObject.Find("Skill_Set_2").transform.Find("SkillButton").transform.Find("cooltime").GetComponent<TextMeshProUGUI>().text);
                skill_2.AnimationofSkill = GameObject.Find("Skill_Set_2").transform.Find("SkillButton").transform.Find("AnimationofSkill").GetComponent<TextMeshProUGUI>().text;
                break;

            case 3:
                skill_3.SkillName = EventSystem.current.currentSelectedGameObject.transform.Find("Text").GetComponent<TextMeshProUGUI>().text.ToString();
                GameObject.Find("Skill_Set_3").transform.Find("SkillButton").transform.Find("Icon").GetComponent<Image>().sprite = EventSystem.current.currentSelectedGameObject.transform.Find("Icon").GetComponent<Image>().sprite;
                GameObject.Find("Skill_Set_3").transform.Find("SkillButton").transform.Find("Text").GetComponent<TextMeshProUGUI>().text = skill_3.SkillName;
                GameObject.Find("Skill_Set_3").transform.Find("SkillButton").transform.Find("Text").GetComponent<TextMeshProUGUI>().text = skill_3.SkillName;
                GameObject.Find("Skill_Set_3").transform.Find("SkillButton").transform.Find("SkillLevel").GetComponent<TextMeshProUGUI>().text = EventSystem.current.currentSelectedGameObject.transform.Find("SkillLevel").GetComponent<TextMeshProUGUI>().text; //Skill Level 가져오기
                GameObject.Find("Skill_Set_3").transform.Find("SkillButton").transform.Find("SkillDamage").GetComponent<TextMeshProUGUI>().text = EventSystem.current.currentSelectedGameObject.transform.Find("SkillDamage").GetComponent<TextMeshProUGUI>().text;
                GameObject.Find("Skill_Set_3").transform.Find("SkillButton").transform.Find("cooltime").GetComponent<TextMeshProUGUI>().text = EventSystem.current.currentSelectedGameObject.transform.Find("cooltime").GetComponent<TextMeshProUGUI>().text;
                GameObject.Find("Skill_Set_3").transform.Find("SkillButton").transform.Find("AnimationofSkill").GetComponent<TextMeshProUGUI>().text = EventSystem.current.currentSelectedGameObject.transform.Find("AnimationofSkill").GetComponent<TextMeshProUGUI>().text;

                skill_3.ImageofSkill = GameObject.Find("Skill_Set_3").transform.Find("SkillButton").transform.Find("Icon").GetComponent<Image>().sprite;
                skill_3.SkillObject = Resources.Load(skill_3.SkillName);

                skill_3.SkillLevel = int.Parse(GameObject.Find("Skill_Set_2").transform.Find("SkillButton").transform.Find("SkillLevel").GetComponent<TextMeshProUGUI>().text);
                skill_3.SkillDamage = float.Parse(GameObject.Find("Skill_Set_2").transform.Find("SkillButton").transform.Find("SkillDamage").GetComponent<TextMeshProUGUI>().text);
                skill_3.cooltime = float.Parse(GameObject.Find("Skill_Set_2").transform.Find("SkillButton").transform.Find("cooltime").GetComponent<TextMeshProUGUI>().text);
                skill_3.AnimationofSkill = GameObject.Find("Skill_Set_2").transform.Find("SkillButton").transform.Find("AnimationofSkill").GetComponent<TextMeshProUGUI>().text;
                break;

            case 4:
                skill_4.SkillName = EventSystem.current.currentSelectedGameObject.transform.Find("Text").GetComponent<TextMeshProUGUI>().text.ToString();
                GameObject.Find("Skill_Set_4").transform.Find("SkillButton").transform.Find("Icon").GetComponent<Image>().sprite = EventSystem.current.currentSelectedGameObject.transform.Find("Icon").GetComponent<Image>().sprite;
                GameObject.Find("Skill_Set_4").transform.Find("SkillButton").transform.Find("Text").GetComponent<TextMeshProUGUI>().text = skill_4.SkillName;
                GameObject.Find("Skill_Set_4").transform.Find("SkillButton").transform.Find("Text").GetComponent<TextMeshProUGUI>().text = skill_4.SkillName;
                GameObject.Find("Skill_Set_4").transform.Find("SkillButton").transform.Find("SkillLevel").GetComponent<TextMeshProUGUI>().text = EventSystem.current.currentSelectedGameObject.transform.Find("SkillLevel").GetComponent<TextMeshProUGUI>().text; //Skill Level 가져오기
                GameObject.Find("Skill_Set_4").transform.Find("SkillButton").transform.Find("SkillDamage").GetComponent<TextMeshProUGUI>().text = EventSystem.current.currentSelectedGameObject.transform.Find("SkillDamage").GetComponent<TextMeshProUGUI>().text;
                GameObject.Find("Skill_Set_4").transform.Find("SkillButton").transform.Find("cooltime").GetComponent<TextMeshProUGUI>().text = EventSystem.current.currentSelectedGameObject.transform.Find("cooltime").GetComponent<TextMeshProUGUI>().text;
                GameObject.Find("Skill_Set_4").transform.Find("SkillButton").transform.Find("AnimationofSkill").GetComponent<TextMeshProUGUI>().text = EventSystem.current.currentSelectedGameObject.transform.Find("AnimationofSkill").GetComponent<TextMeshProUGUI>().text;

                skill_4.ImageofSkill = GameObject.Find("Skill_Set_4").transform.Find("SkillButton").transform.Find("Icon").GetComponent<Image>().sprite;
                skill_4.SkillObject = Resources.Load(skill_4.SkillName);

                skill_4.SkillLevel = int.Parse(GameObject.Find("Skill_Set_4").transform.Find("SkillButton").transform.Find("SkillLevel").GetComponent<TextMeshProUGUI>().text);
                skill_4.SkillDamage = float.Parse(GameObject.Find("Skill_Set_4").transform.Find("SkillButton").transform.Find("SkillDamage").GetComponent<TextMeshProUGUI>().text);
                skill_4.cooltime = float.Parse(GameObject.Find("Skill_Set_4").transform.Find("SkillButton").transform.Find("cooltime").GetComponent<TextMeshProUGUI>().text);
                skill_4.AnimationofSkill = GameObject.Find("Skill_Set_4").transform.Find("SkillButton").transform.Find("AnimationofSkill").GetComponent<TextMeshProUGUI>().text;
                break;
            
        }

        skill_selected_ = -1;
    }

    void SkillSetting(string skillname, int i)
    {
        if(skillname == "FireBall" && i == 1)
        {
            FireBall = skill_1;
        }
    }


    void FireBallSet()
    {
        FireBall.SkillName = "FireBall";
        FireBall.SkillLevel = 1;

        FireBall.TypeofSkill = 1; //0: 물리 1:마법
        FireBall.propertiesOfSkills = 1; ; //0:파이터 1:파이어 2:얼음

        FireBall.AnimationofSkill = "Projectile Attack";
    }
    void FirePunchSet()
    {
        FirePunch.SkillName = "FirePunch";
        FirePunch.SkillLevel = 1;

        FirePunch.TypeofSkill = 0; //0: 물리 1:마법
        FirePunch.propertiesOfSkills = 1; ; //0:파이터 1:파이어 2:얼음

        FirePunch.AnimationofSkill = "Projectile Attack";
    }
    void ScratchSet()
    {
        Scratch.SkillName = "DragonBite";
        Scratch.SkillLevel = 1;

        Scratch.TypeofSkill = 0; //0: 물리 1:마법
        Scratch.propertiesOfSkills = 0; ; //0:파이터 1:파이어 2:얼음

        Scratch.AnimationofSkill = "Bite Attack";
    }
    void DragonBiteSet()
    {
        DragonBite.SkillName = "DragonBite";
        DragonBite.SkillLevel = 1;

        DragonBite.TypeofSkill = 0; //0: 물리 1:마법
        DragonBite.propertiesOfSkills = 0; ; //0:파이터 1:파이어 2:얼음

        DragonBite.AnimationofSkill = "Bite Attack";
    }
}
