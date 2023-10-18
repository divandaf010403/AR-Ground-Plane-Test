using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{

    public GameObject gelasUkur;

    public GameObject termometer;

    public GameObject bunsenBurner;

    public GameObject beaker;

    public GameObject tabungReaksi;

    public GameObject pipet;

    public GameObject praktikum1Desc;
    public GameObject praktikum2Desc;

    // Start is called before the first frame update
    void Start()
    {
        beaker.SetActive(false);
        termometer.SetActive(false);
        bunsenBurner.SetActive(false);
        gelasUkur.SetActive(false);
        tabungReaksi.SetActive(false);
        pipet.SetActive(false);

        praktikum1Desc.SetActive(false);
        praktikum2Desc.SetActive(false);
    }

    public void praktikum1()
    {
        beaker.SetActive(true);
        termometer.SetActive(true);
        bunsenBurner.SetActive(true);
        gelasUkur.SetActive(true);

        tabungReaksi.SetActive(false);
        pipet.SetActive(false);

        praktikum1Desc.SetActive(true);
        praktikum1Desc.transform.localPosition = new Vector3(0, 0, 0);
        praktikum2Desc.SetActive(false);
    }

    public void praktikum2()
    {
        tabungReaksi.SetActive(true);
        pipet.SetActive(true);
        beaker.SetActive(true);
        bunsenBurner.SetActive(true);

        termometer.SetActive(false);
        gelasUkur.SetActive(false);

        praktikum1Desc.SetActive(false);
        praktikum2Desc.SetActive(true);
        praktikum2Desc.transform.localPosition = new Vector3(0, 0, 0);
    }
}
