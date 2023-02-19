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
    //몬스터 종, 속성
    // 종(속성) : 드래곤(불,얼음,더스트), 웨어울프(노말,불), 피터래빗(노말), 스네이크(불)
    // 속성 : Fire, Ice, Dust, Fighter
    // 종 관련 질문 5개 (3개)
    /* 1. 전방 싸움과 후방 싸움 : 후방 -> 드래곤, 스네이크 ( species +0 ) / 전방 -> 웨어울프, 피터래빗 ( species +10 )
       2. 스타일리시한 전투와 스케일이 큰 전투 : 스타일리시 -> 스네이크, 웨어울프 (species +5) / 스케일 -> 드래곤, 피터래빗 (species +0)
       3. 더스트 드래곤(유니크)를 얻을 수 있는 함정 질문 +20// 드래곤이 나온 상태에서 인성 질문으로 유도하기
    */
    // 속성 관련 질문 3개 (1개) //: 노말은 얼음도 가능
    // 1. 강력한 한 방(불), 상대 억제(얼음), 빠른 공격 속도(파이터) (스네이크는 패스)
    public int[] Species = new int[4] { 0 , 0 , 0 , 0 };// 0 : 드래곤 , 1 : 울프 , 2 : 스네이크, 3 : 해바라기
    public int[] Attribute = new int[3] { 0 , 0 , 0}; // 0 : 불, 1 : 얼음 , 2 : 파이터
    public bool[] Attack_type = new bool[2] { false, false }; // 0 : 근거리, 1 : 원거리
    
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
        //텍스트 바꾸기
        GameObject.Find("FirstText").SetActive(false);
        GameObject.Find("Image").transform.Find("Survey").gameObject.SetActive(true);

    }

    public void FirstAnswer_FirstQuestion()
    {
        GameObject.Find("Survey").SetActive(false);
        GameObject.Find("Image").transform.Find("Survey_2").gameObject.SetActive(true);

        // 누구보다 앞에서 싸운다. -> 근거리
        Attack_type[0] = true;
        
    }

    public void SecondAnswer_FirstQuestion()
    {
        GameObject.Find("Survey").SetActive(false);
        GameObject.Find("Image").transform.Find("Survey_2").gameObject.SetActive(true);
        // 동료를 지킬 방법을 궁리한다. -> 원거리
        Attack_type[1] = true;
    }

    public void FirstAnswer_SecondQuestion()
    {
        GameObject.Find("Survey_2").SetActive(false);
        GameObject.Find("Image").transform.Find("Survey_3").gameObject.SetActive(true);
        // 액션영화 -> Fire , Fighter +2
        Attribute[0] += 2;
        Attribute[2] += 2;
    }

    public void SecondAnswer_SecondQuestion()
    {
        GameObject.Find("Survey_2").SetActive(false);
        GameObject.Find("Image").transform.Find("Survey_3").gameObject.SetActive(true);
        // SF영화 -> Ice +2
        Attribute[1] += 2;
    }

    public void FirstAnswer_ThirdQuestion()
    {
        GameObject.Find("Survey_3").SetActive(false);
        GameObject.Find("Image").transform.Find("Survey_4").gameObject.SetActive(true);
        // 아이언맨 -> Fire
        Attribute[0]++;
    }

    public void SecondAnswer_ThirdQuestion()
    {
        GameObject.Find("Survey_3").SetActive(false);
        GameObject.Find("Image").transform.Find("Survey_4").gameObject.SetActive(true);
        // 캡틴아메리카 -> Fighter
        Attribute[2]++;
    }

    public void FirstAnswer_FourthQuestion()
    {
        GameObject.Find("Survey_4").SetActive(false);
        GameObject.Find("Image").transform.Find("Survey_5").gameObject.SetActive(true);
        // 화끈한 사랑 -> Dragon, Wolf
        Species[0]++;
        Species[1]++;
    }

    public void SecondAnswer_FourthQuestion()
    {
        GameObject.Find("Survey_4").SetActive(false);
        GameObject.Find("Image").transform.Find("Survey_5").gameObject.SetActive(true);
        // 애절한 사랑 -> Snake, Flower
        Species[2]++;
        Species[3]++;
    }

    public void FirstAnswer_FifthQuestion()
    {
        GameObject.Find("Survey_5").SetActive(false);
        GameObject.Find("Image").transform.Find("FinalPanel").gameObject.SetActive(true);
        // 산 -> Dragon, Snake
        Species[0]++;
        Species[2]++;

    }

    public void SecondAnswer_FifthQuestion()
    {
        GameObject.Find("Survey_5").SetActive(false);
        GameObject.Find("Image").transform.Find("FinalPanel").gameObject.SetActive(true);
        // 바다 -> Wolf, Flower
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
                        txt_beastintro.text = "드래곤    불    근거리";
                        break;
                    case 1://AD
                        txt_beastintro.text = "드래곤    불    원거리";
                        break;
                }
                break;
            case 1://wolf
                switch (Attribute_n)
                {
                    case 0: // fire
                        txt_beastintro.text = "울프    불    원거리";
                        break;
                    case 1: //ice
                        txt_beastintro.text = "울프    얼음    원거리";
                        break; 
                    case 2: //fighter
                        txt_beastintro.text = "울프    파이터    근거리";
                        break;
                }
                break;
            case 2://snake_fire
                switch (Attack_type_n)
                {
                    case 0: //ad
                        txt_beastintro.text = "스네이크    불    근거리";
                        break;
                    case 1: //ap
                        txt_beastintro.text = "스네이크    불    원거리";
                        break;
                }
                break;
            case 3://flower
                txt_beastintro.text = "선플라워    파이터    근거리";
                break;
        }
    }

    public void Beast_Select()
    {
        
        // 1. 종 알아보기
        // 0 : 드래곤 , 1 : 울프 , 2 : 스네이크, 3 : 해바라기
        for (int i = 0; i < 4; i++)
        {
            if (Max < Species[i])
            {
                Max = Species[i];
                Species_n = i;
            }
            
        }

        //2. 속성 검사
        for (int i = 0; i < 3; i++)
        {
            if (Attribute_n < Attribute[i])
            {
                Attribute_n = i;
            }

        }
        // 3. 공격 타입 검사
        for (int i = 0; i < 2; i++)
        {
            if (Attack_type[i])
            {
                Attack_type_n = i;
            }
        }
        // 2-1. 속성 적용
        // 0 : 불, 1 : 얼음 , 2 : 파이터
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
