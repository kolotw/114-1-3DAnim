using UnityEngine;

public class walkAnim : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //走路
        this.transform.Translate(Vector3.forward * Time.deltaTime * 1);
        //攝影機
        //this.transform.Translate(Vector3.right * Time.deltaTime * 1);
    }
}
