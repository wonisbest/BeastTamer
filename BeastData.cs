using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*namespace data { 
    public struct BeastData
    {
        public string BeastPref;
        public string species; //종
        public string attribute; // 속성 (추후 추가 가능)
        public string attack_type; // 공격 타입 (근거리, 원거리)
    
        public int level;
        // 0 : 근력(str) , 1 : 민첩성(dex) , 2 : 지력(int) , 3 : 체력 (health) , 4 : 마력 (Mana)
        public int stats_str;
        public int stats_dex;
        public int stats_int;
        public int stats_HP;
        public int stats_MP;

        public int statPoint; // 스탯을 올릴 수 있는 포인트 1레벨업당 3 추가

        public int pyshical_attack_power;
        public int magical_attack_power;
        public int pyshical_defence_power;
        public int magical_defence_power;
    }
}*/

public class BeastData : MonoBehaviour
{
    //static reference -> 정적으로 선언
    public static BeastData beastdata;

    // 이하 저장할 데이터들
    public Object BeastPrefab;
    public string BeastPref;
    public string species = " "; //종
    public string attribute = " "; // 속성 (추후 추가 가능)
    public string attack_type = " "; // 공격 타입 (근거리, 원거리)

    public int level = 0;
    public int needExp = 0;
    
    public int Stat_Health = 0;
    public int Stat_Attack = 0;
    public int Stat_Defense = 0;
    public int Stat_Friendship = 0;

    public int AttackPlus = 0;
    public int MagicAttackPlus = 0;
    public int DefensePlus = 0;
    public int MagicDefensePlus = 0;

    public int statPoint = 3; // 스탯을 올릴 수 있는 포인트 1레벨업당 3 추가

    /*public int pyshical_attack_power;
    public int magical_attack_power;
    public int pyshical_defence_power;
    public int magical_defence_power;*/

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);

        if(beastdata == null)
        {
            beastdata = this;
            //beastdata가 null 이면 이 오브젝트를 싱글톤으로 설정
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        beastdata.Stat_Health = 1;
        beastdata.Stat_Attack = 1;
        beastdata.Stat_Defense = 1;
        beastdata.Stat_Friendship = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
