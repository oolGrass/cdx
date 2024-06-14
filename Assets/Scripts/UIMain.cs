using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Text;

public class UIMain : MonoBehaviour
{
    public Text text;
    string path;
    public GameObject Texts;
    public Text Place_name;
    public Sprite[] sprites = new Sprite[3];
    public Image image;
    // Start is called before the first frame update
    void Start()
    {
        path = Application.dataPath + @"\IO\username.txt";
        text.text = File.ReadAllText(path);
        int index = Random.Range(0, 3);
        image.GetComponent<Image>().sprite = sprites[index];        
    }
    public void ShowText(string name)
    {
        Place_name.gameObject.SetActive(true);
        Place_name.text = name;
        Place_name.GetComponent<Animation>().Play("Show_text");
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
