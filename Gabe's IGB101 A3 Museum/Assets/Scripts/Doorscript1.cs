using UnityEngine;

public class Doorscript1 : MonoBehaviour
{
    Animation anim;
    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animation>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("f"))
            anim.Play();
    }

}
