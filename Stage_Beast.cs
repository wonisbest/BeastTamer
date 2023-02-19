using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Stage_Beast : MonoBehaviour
{
    SkillData.Skill_ Skill_1;
    SkillData.Skill_ Skill_2;
    SkillData.Skill_ Skill_3;
    SkillData.Skill_ Skill_4;
    public bool Attacking = false;
    public bool cooltime_skill_1 = false;
    public bool cooltime_skill_2 = false;
    public bool cooltime_skill_3 = false;
    public bool cooltime_skill_4 = false;
    GameObject SkillofResource;
    GameObject skillstartposition;
    GameObject Player;
    Vector3 dir;
    Quaternion dir_rot;

    public float hAxis;
    public float vAxis;
    public float ex_Hinput = 0, ex_Vinput = 0;
    // Start is called before the first frame update

    void Start()
    {
        Scene scene = SceneManager.GetActiveScene(); //함수 안에 선언하여 사용한다.
        
        if (scene.name != "MainLobby" && scene.name != "Start") { 
        Skill_1 = GameObject.Find("SkillData").GetComponent<SkillData>().skill_1;
        Skill_2 = GameObject.Find("SkillData").GetComponent<SkillData>().skill_2;
        Skill_3 = GameObject.Find("SkillData").GetComponent<SkillData>().skill_3;
        Skill_4 = GameObject.Find("SkillData").GetComponent<SkillData>().skill_4;
        }
        Player = GameObject.Find("Player");
        skillstartposition = GameObject.Find("SkillStartPosition");
    }

    // Update is called once per frame
    void Update()
    {
 
        //dir = Player.GetComponent<Player>().moveVec;
        if (Input.GetKey(KeyCode.Alpha1) && !cooltime_skill_1)
        {
            UseSkill_1();
        }
        if (Input.GetKey(KeyCode.Alpha2) && !cooltime_skill_2)
        {
            UseSkill_2();
        }
        if (Input.GetKey(KeyCode.Alpha3) && !cooltime_skill_3)
        {
            UseSkill_3();
        }
        if (Input.GetKey(KeyCode.Alpha4) && !cooltime_skill_4)
        {
            UseSkill_4();
        }

        hAxis = 0;
        vAxis = 0;
    }
  

    //스킬마다 필요한 로테이션 구조가 다 다름 -> 어떡하지
    public void UseSkill_1() 
    {
        Attacking = true;
        cooltime_skill_1 = true;
        gameObject.GetComponent<Animator>().Play(Skill_1.AnimationofSkill);
        gameObject.transform.parent.transform.GetChild(2).GetComponent<Animator>().Play("Skill_1");
        /*SkillofResource = (GameObject)Instantiate(Skill_1.SkillObject,
            GameObject.Find("Beast").gameObject.transform.position,
            Quaternion.Euler(0, 0, 0), GameObject.Find("Beast").gameObject.transform);*/
        Instantiate(Resources.Load(Skill_1.SkillName), skillstartposition.transform.position, gameObject.transform.parent.transform.rotation /* Player.transform.rotation */ );
        // 포지션 x -10 y +10 하기
        Invoke("Attack", 1f);
        Invoke("cooldown_skill_1", Skill_1.cooltime);

    }
    public void UseSkill_2()
    {
        Attacking = true;
        cooltime_skill_2 = true;
        gameObject.GetComponent<Animator>().Play(Skill_2.AnimationofSkill);
        gameObject.transform.parent.transform.GetChild(2).GetComponent<Animator>().Play("Skill_2");
        /*SkillofResource = (GameObject)Instantiate(Skill_2.SkillObject,
            GameObject.Find("Beast").gameObject.transform.position,
            Quaternion.Euler(0, 0, 0), GameObject.Find("Beast").gameObject.transform);*/

        Instantiate(Resources.Load(Skill_2.SkillName), skillstartposition.transform.position, gameObject.transform.parent.transform.rotation);
        Invoke("Attack", 1f);
        Invoke("cooldown_skill_2", Skill_2.cooltime);
    }
    public void UseSkill_3()
    {
        Attacking = true;
        cooltime_skill_3 = true;
        gameObject.GetComponent<Animator>().Play(Skill_3.AnimationofSkill);
        gameObject.transform.parent.transform.GetChild(2).GetComponent<Animator>().Play("Skill_3");
        Instantiate(Resources.Load(Skill_3.SkillName), skillstartposition.transform.position, gameObject.transform.parent.transform.rotation);
        Invoke("Attack", 1f);
        Invoke("cooldown_skill_3", Skill_3.cooltime);
    }
    public void UseSkill_4()
    {
        Attacking = true;
        cooltime_skill_4 = true;
        gameObject.GetComponent<Animator>().Play(Skill_4.AnimationofSkill);
        gameObject.transform.parent.transform.GetChild(2).GetComponent<Animator>().Play("Skill_4");
        Instantiate(Resources.Load(Skill_4.SkillName), skillstartposition.transform.position, gameObject.transform.parent.transform.rotation);
        Invoke("Attack", 1f);
        Invoke("cooldown_skill_4", Skill_4.cooltime);
    }
    
    public void cooldown_skill_1()
    {
        cooltime_skill_1 = false;
    }
    public void cooldown_skill_2()
    {
        cooltime_skill_2 = false;
    }
    public void cooldown_skill_3()
    {
        cooltime_skill_3 = false;
    }
    public void cooldown_skill_4()
    {
        cooltime_skill_4 = false;
    }

    public void Attack()
    {
        Attacking = false;
    }

}
