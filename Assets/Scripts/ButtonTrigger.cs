using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonTrigger : MonoBehaviour
{
    Button button;
    private readonly HashSet<string> authorisedTag = new HashSet<string>()
    {
        "Hand"
    };

    // Start is called before the first frame update
    void Start()
    {
        button = gameObject.GetComponent<Button>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(authorisedTag.Contains(other.tag))
        {
            button.onClick.Invoke();
        }
    }
}
