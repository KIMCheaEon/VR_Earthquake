using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class BuildingMove: MonoBehaviour
{
    public GameObject light;
    public GameObject tv;
    // Start is called before the first frame update
    void Start()
    {
        Builing();

        /*for (int i = 0; i < 5; i++)
        {
            transform.DOMove(new Vector3(0, 0, 1), 0.3f);
            transform.DOMove(new Vector3(0, 0, 1.53f), 0.3f);
        }*/
        //rt.DOAnchorPosY(0, 1);
        //������������ ���ڸ� �Ű���.

    }
    public void Builing()
    {
        StartCoroutine(MoveSequence());
    }
    IEnumerator MoveSequence()
    {
        for (int i = 0; i < 5; i++)
        {
            yield return new WaitForSeconds(0.1f);
            transform.DOShakePosition(2,0.3f);
           /* transform.DOMove(new Vector3(0, 0, 0.5f), 1f);  
            yield return new WaitForSeconds(0.1f);
            transform.DOMove(new Vector3(0, 0, 1.53f), 1f);*/
        }
        light.GetComponent<Rigidbody>().useGravity = true;
        tv.GetComponent<Rigidbody>().useGravity = true;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
