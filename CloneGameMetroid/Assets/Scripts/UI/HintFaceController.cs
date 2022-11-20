using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HintFaceController : MonoBehaviour
{
    public Animator anim;

    public string unlockMessage;
    public TMP_Text unlockText;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            anim.SetTrigger("faceShowUp");

            unlockText.transform.parent.SetParent(null);
            unlockText.transform.parent.position = transform.position;

            unlockText.text = unlockMessage;
            unlockText.gameObject.SetActive(true);

        }
    }
}
