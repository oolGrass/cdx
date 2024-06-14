using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Text;
using System.IO;

public class LoadingToSchool : MonoBehaviour
{
    public InputField Name;
    public InputField Id;
    public Button Startt;
    string path;
    // Start is called before the first frame update
    void Start()
    {
        path = Application.dataPath + @"\IO\username.txt";
    }
    public void ConfirmButton()
    {
        if (Id.text != "" && Name.text != "")
        {
            File.WriteAllText(path, Name.text);
            SceneManager.LoadScene(1);
        }
        else return;
    }
    // Update is called once per frame
    void Update()
    {
    }
}
