using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBack : MonoBehaviour
{

    //��� ������.
    public GameObject OptionsMenu;

    //������������� ���������� ������������ ��������� �����������.
    public int SB;

    //����� ������� ����� ���������� �� ������� ����� ������.
    public void OnButtonDown()
    {
        //������ ����� ���������� ������������� �������� 1 ��� 2.
        SB = -2000;
        //���������� ��� ������ �� S ���������� �� ��� x.
        OptionsMenu.transform.Translate(SB, 0, 0);
    }
}