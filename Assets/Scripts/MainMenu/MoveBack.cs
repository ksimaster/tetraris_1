using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBack : MonoBehaviour
{

    //Наш объект.
    public GameObject OptionsMenu;

    //Целочисленная переменная определяющая дистанцию перемещения.
    public int SB;

    //Метод который будет выполнятся по нажатию нашей кнопки.
    public void OnButtonDown()
    {
        //Задаем нашей переменной целочисленное значение 1 или 2.
        SB = -2000;
        //Перемещаем наш объект на S расстояние по оси x.
        OptionsMenu.transform.Translate(SB, 0, 0);
    }
}