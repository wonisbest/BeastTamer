 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
//using static UnityEditor.PlayerSettings;
using UnityEngine.SceneManagement;


public class StartScene_UI : MonoBehaviour
{
    public TextMeshProUGUI txt_beastintro;
    public string BeastPrefab = "Beast_";
    public int Max = -1;
    public int Species_n = -1;
    public int Attribute_n = -1;
    public int Attack_type_n = -1;
    //���� ��, �Ӽ�
    // ��(�Ӽ�) : �巡��(��,����,����Ʈ), �������(�븻,��), ���ͷ���(�븻), ������ũ(��)
    // �Ӽ� : Fire, Ice, Dust, Fighter
    // �� ���� ���� 5�� (3��)
    /* 1. ���� �ο�� �Ĺ� �ο� : �Ĺ� -> �巡��, ������ũ ( species +0 ) / ���� -> �������, ���ͷ��� ( species +10 )
       2. ��Ÿ�ϸ����� ������ �������� ū ���� : ��Ÿ�ϸ��� -> ������ũ, ������� (species +5) / ������ -> �巡��, ���ͷ��� (species +0)
       3. ����Ʈ �巡��(����ũ)�� ���� �� �ִ� ���� ���� +20// �巡���� ���� ���¿��� �μ� �������� �����ϱ�
    */
    // �Ӽ� ���� ���� 3�� (1��) //: �븻�� ������ ����
    // 1. ������ �� ��(��), ��� ����(����), ���� ���� �ӵ�(������) (������ũ�� �н�)
    public int[] Species = new int[4] { 0 , 0 , 0 , 0 };// 0 : �巡�� , 1 : ���� , 2 : ������ũ, 3 : �عٶ��
    public int[] Attribute = new int[3] { 0 , 0 , 0}; // 0 : ��, 1 : ���� , 2 : ������
    public bool[] Attack_type = new bool[2] { false, false }; // 0 : �ٰŸ�, 1 : ���Ÿ�
    
    /* 
     * Dragon -> Fighter_AD / Fire_AP
     * Wolf   -> Fighter_AD / Fire_AP / Ice_AP
     * Snake  -> Fighter_AD / Fire_AD / Fire_AP
     * SunFlower -> Fighter_AD
     */
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void nextButton()
    {
        //�ؽ�Ʈ �ٲٱ�
        GameObject.Find("FirstText").SetActive(false);
        GameObject.Find("Image").transform.Find("Survey").gameObject.SetActive(true);

    }

    public void FirstAnswer_FirstQuestion()
    {
        GameObject.Find("Survey").SetActive(false);
        GameObject.Find("Image").transform.Find("Survey_2").gameObject.SetActive(true);

        // �������� �տ��� �ο��. -> �ٰŸ�
        Attack_type[0] = true;
        
    }

    public void SecondAnswer_FirstQuestion()
    {
        GameObject.Find("Survey").SetActive(false);
        GameObject.Find("Image").transform.Find("Survey_2").gameObject.SetActive(true);
        // ���Ḧ ��ų ����� �ø��Ѵ�. -> ���Ÿ�
        Attack_type[1] = true;
    }

    public void FirstAnswer_SecondQuestion()
    {
        GameObject.Find("Survey_2").SetActive(false);
        GameObject.Find("Image").transform.Find("Survey_3").gameObject.SetActive(true);
        // �׼ǿ�ȭ -> Fire , Fighter +2
        Attribute[0] += 2;
        Attribute[2] += 2;
    }

    public void SecondAnswer_SecondQuestion()
    {
        GameObject.Find("Survey_2").SetActive(false);
        GameObject.Find("Image").transform.Find("Survey_3").gameObject.SetActive(true);
        // SF��ȭ -> Ice +2
        Attribute[1] += 2;
    }

    public void FirstAnswer_ThirdQuestion()
    {
        GameObject.Find("Survey_3").SetActive(false);
        GameObject.Find("Image").transform.Find("Survey_4").gameObject.SetActive(true);
        // ���̾�� -> Fire
        Attribute[0]++;
    }

    public void SecondAnswer_ThirdQuestion()
    {
        GameObject.Find("Survey_3").SetActive(false);
        GameObject.Find("Image").transform.Find("Survey_4").gameObject.SetActive(true);
        // ĸƾ�Ƹ޸�ī -> Fighter
        Attribute[2]++;
    }

    public void FirstAnswer_FourthQuestion()
    {
        GameObject.Find("Survey_4").SetActive(false);
        GameObject.Find("Image").transform.Find("Survey_5").gameObject.SetActive(true);
        // ȭ���� ��� -> Dragon, Wolf
        Species[0]++;
        Species[1]++;
    }

    public void SecondAnswer_FourthQuestion()
    {
        GameObject.Find("Survey_4").SetActive(false);
        GameObject.Find("Image").transform.Find("Survey_5").gameObject.SetActive(true);
        // ������ ��� -> Snake, Flower
        Species[2]++;
        Species[3]++;
    }

    public void FirstAnswer_FifthQuestion()
    {
        GameObject.Find("Survey_5").SetActive(false);
        GameObject.Find("Image").transform.Find("FinalPanel").gameObject.SetActive(true);
        // �� -> Dragon, Snake
        Species[0]++;
        Species[2]++;

    }

    public void SecondAnswer_FifthQuestion()
    {
        GameObject.Find("Survey_5").SetActive(false);
        GameObject.Find("Image").transform.Find("FinalPanel").gameObject.SetActive(true);
        // �ٴ� -> Wolf, Flower
        Species[1]++;
        Species[3]++;
    }

    public void NextButton_FinalPanel()
    {
        GameObject.Find("Image").SetActive(false);
        GameObject.Find("Panel").transform.Find("Beast_Panel").gameObject.SetActive(true);
        Beast_Select();
        Beast_Text();
    }

    public void Beast_Text()
    {
        switch(Species_n)
        {
            case 0: // dragon
                switch (Attack_type_n)
                {
                    case 0: //AP
                        txt_beastintro.text = "�巡��    ��    �ٰŸ�";
                        break;
                    case 1://AD
                        txt_beastintro.text = "�巡��    ��    ���Ÿ�";
                        break;
                }
                break;
            case 1://wolf
                switch (Attribute_n)
                {
                    case 0: // fire
                        txt_beastintro.text = "����    ��    ���Ÿ�";
                        break;
                    case 1: //ice
                        txt_beastintro.text = "����    ����    ���Ÿ�";
                        break; 
                    case 2: //fighter
                        txt_beastintro.text = "����    ������    �ٰŸ�";
                        break;
                }
                break;
            case 2://snake_fire
                switch (Attack_type_n)
                {
                    case 0: //ad
                        txt_beastintro.text = "������ũ    ��    �ٰŸ�";
                        break;
                    case 1: //ap
                        txt_beastintro.text = "������ũ    ��    ���Ÿ�";
                        break;
                }
                break;
            case 3://flower
                txt_beastintro.text = "���ö��    ������    �ٰŸ�";
                break;
        }
    }

    public void Beast_Select()
    {
        
        // 1. �� �˾ƺ���
        // 0 : �巡�� , 1 : ���� , 2 : ������ũ, 3 : �عٶ��
        for (int i = 0; i < 4; i++)
        {
            if (Max < Species[i])
            {
                Max = Species[i];
                Species_n = i;
            }
            
        }

        //2. �Ӽ� �˻�
        for (int i = 0; i < 3; i++)
        {
            if (Attribute_n < Attribute[i])
            {
                Attribute_n = i;
            }

        }
        // 3. ���� Ÿ�� �˻�
        for (int i = 0; i < 2; i++)
        {
            if (Attack_type[i])
            {
                Attack_type_n = i;
            }
        }
        // 2-1. �Ӽ� ����
        // 0 : ��, 1 : ���� , 2 : ������
        switch (Species_n)
        {
            case 0:
                BeastPrefab += "Dragon_Fire_";
                switch (Attack_type_n)
                {
                    case 0:
                        BeastPrefab += "AD";
                        break;
                    case 1:
                        BeastPrefab += "AP";
                        break;
                }
                break;
            case 1:
                BeastPrefab += "Wolf_";
                switch (Attribute_n)
                {
                    case 0:
                        BeastPrefab += "Fire_AP";
                        break;
                    case 1:
                        BeastPrefab += "Ice_AP";
                        break;
                    case 2:
                        BeastPrefab += "Fighter_AD";
                        break;
                }
                break;
            case 2:
                BeastPrefab += "Snake_";
                BeastPrefab += "Fire_";
                switch (Attack_type_n)
                {
                    case 0:
                        BeastPrefab += "AD";
                        break;
                    case 1:
                        BeastPrefab += "AP";
                        break;
                }
                break;
            case 3:
                BeastPrefab += "Flower_Fighter_AP";
                break;
        }

        Instantiate(Resources.Load(BeastPrefab), new Vector3 (0f,0.5f,-7f), Quaternion.Euler(0, 180, 0));
        

    }

    public void MainLobbyScene() {
        BeastDataFirstSetting();
        SceneManager.LoadScene("MainLobby");
    }

    public void BeastDataFirstSetting()
    {
        BeastData.beastdata.BeastPref = BeastPrefab;
        BeastData.beastdata.BeastPrefab = Resources.Load(BeastPrefab);
    }

    public void taptostart()
    {
        GameObject.Find("TitleScene_TapToStart").SetActive(false);
    }
}
