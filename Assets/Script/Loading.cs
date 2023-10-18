using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Loading : MonoBehaviour
{
    public Transform masukanLoadingBar;
    
    [SerializeField]
    private float nilaiSekarang;
    [SerializeField]
    private float nilaiKecepatan;

    // Update is called once per frame
    void Update()
    {
        if (nilaiSekarang < 100)
        {
            nilaiSekarang += nilaiKecepatan * Time.deltaTime;
            Debug.Log((int)nilaiSekarang);
        } else
        {
            SceneManager.LoadScene("MainMenu");
        }
        masukanLoadingBar.GetComponent<Image> ().fillAmount = nilaiSekarang / 100;
    }
}
