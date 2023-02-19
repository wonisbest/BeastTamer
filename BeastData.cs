using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*namespace data { 
    public struct BeastData
    {
        public string BeastPref;
        public string species; //��
        public string attribute; // �Ӽ� (���� �߰� ����)
        public string attack_type; // ���� Ÿ�� (�ٰŸ�, ���Ÿ�)
    
        public int level;
        // 0 : �ٷ�(str) , 1 : ��ø��(dex) , 2 : ����(int) , 3 : ü�� (health) , 4 : ���� (Mana)
        public int stats_str;
        public int stats_dex;
        public int stats_int;
        public int stats_HP;
        public int stats_MP;

        public int statPoint; // ������ �ø� �� �ִ� ����Ʈ 1�������� 3 �߰�

        public int pyshical_attack_power;
        public int magical_attack_power;
        public int pyshical_defence_power;
        public int magical_defence_power;
    }
}*/

public class BeastData : MonoBehaviour
{
    //static reference -> �������� ����
    public static BeastData beastdata;

    // ���� ������ �����͵�
    public Object BeastPrefab;
    public string BeastPref;
    public string species = " "; //��
    public string attribute = " "; // �Ӽ� (���� �߰� ����)
    public string attack_type = " "; // ���� Ÿ�� (�ٰŸ�, ���Ÿ�)

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

    public int statPoint = 3; // ������ �ø� �� �ִ� ����Ʈ 1�������� 3 �߰�

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
            //beastdata�� null �̸� �� ������Ʈ�� �̱������� ����
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
