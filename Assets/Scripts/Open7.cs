using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Open7 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    bool isOpen = false;
    UIMain uimain;
    int index = 0;
    void Start()
    {
        uimain = FindObjectOfType<UIMain>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, player.transform.position) < 2 && !isOpen)
        {
            transform.GetComponent<Animator>().SetBool("Open", true);
            transform.GetComponent<Animator>().SetBool("Close", false);
            if (index % 2 == 0)
            {
                uimain.ShowText("ÔË¶¯Æ÷²Ä·¿");
            }
            index++;
            isOpen = true;
        }
        if (Vector3.Distance(transform.position, player.transform.position) > 2 && isOpen)
        {
            transform.GetComponent<Animator>().SetBool("Close", true);
            transform.GetComponent<Animator>().SetBool("Open", false);
            isOpen = false;
        }
    }
}
