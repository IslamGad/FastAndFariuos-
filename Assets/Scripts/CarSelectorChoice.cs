using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSelectorChoice : MonoBehaviour
{
    public GameObject c1;
    public GameObject c2;
    public GameObject c3;
    public GameObject c4;
    public int carSelectedNO;
    void Start()
    {
        c1.SetActive(true);
        c2.SetActive(false);
        c3.SetActive(false);
        c4.SetActive(false);
        carSelectedNO = 1;

    }

    public void Loadc1()
    {
        c1.SetActive(true);
        c2.SetActive(false);
        c3.SetActive(false);
        c4.SetActive(false);
        carSelectedNO = 1;

    }
    public void Loadc2()
    {
        c1.SetActive(false);
        c2.SetActive(true);
        c3.SetActive(false);
        c4.SetActive(false);
        carSelectedNO = 2;
    }
    public void Loadc3()
    {
        c1.SetActive(false);
        c2.SetActive(false);
        c3.SetActive(true);
        c4.SetActive(false);
        carSelectedNO = 3;
    }
    public void Loadc4()
    {
        c1.SetActive(false);
        c2.SetActive(false);
        c3.SetActive(false);
        c4.SetActive(true);
        carSelectedNO = 4;
    }
}
