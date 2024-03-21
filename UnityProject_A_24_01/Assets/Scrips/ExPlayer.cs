using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExPlayer : MonoBehaviour
{
    public int Hp = 100;
    public Text TextUI = null;
    
    void Update()
    {
        TextUI.text = Hp.ToString();    //UI�� ü�� ǥ��

        if (Input.GetMouseButtonDown(0))    //���콺 ���� �Է��� �Ǿ��� �� ����
        {
            Hp -= 10;                    //Hp = hp - 10
            if(Hp <= 0)                  //ü���� 0���ϰ� �Ǹ� �ı��Ѵ�
            {
                TextUI.text = Hp.ToString();    //UI�� ü�� ǥ��
                Destroy(gameObject);           //gameObject�� ��ũ��Ʈ�� �پ��ִ� ������Ʈ�� ��Ī
            }
        }
    }
}
