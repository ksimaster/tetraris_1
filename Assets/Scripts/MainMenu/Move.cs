using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    //��� ������.
    public GameObject OptionsMenu;

    //������������� ���������� ������������ ��������� �����������.
    public int S;

    //����� ������� ����� ���������� �� ������� ����� ������.
    public void OnButtonDown()
    {
        //������ ����� ���������� ������������� �������� 1 ��� 2.
        S = 2000;
        //���������� ��� ������ �� S ���������� �� ��� x.
        OptionsMenu.transform.Translate(S, 0, 0);
    }
}

