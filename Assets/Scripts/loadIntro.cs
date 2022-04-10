using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class loadIntro : MonoBehaviour
{
    public Transform masukLoadingBar;

    public string SceneName;

    //menampilkan angka di log
    [SerializeField]
    private float nilaiSekarang;
    [SerializeField]
    private float nilaiKecepatan;

    void Update()
    {
        //loading
        if (nilaiSekarang < 100)
        {
            nilaiSekarang += nilaiKecepatan * Time.deltaTime;
            Debug.Log((int)nilaiSekarang);
        }
        else
        {
            Application.LoadLevel(SceneName);
        }
        masukLoadingBar.GetComponent<Image>().fillAmount = nilaiSekarang / 100;
    }
}
