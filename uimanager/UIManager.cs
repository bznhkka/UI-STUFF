using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class UIManager : MonoBehaviour

  
{
    public Vector3 finalPos;
    public Vector3 initialPos;
    public float animDuration;
    public GameObject button;
    public Ease ease;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void MoveButton()
    {
        Debug.Log("Button Clicked.");
        button.transform.DOLocalMove(finalPos, animDuration).SetEase(ease).OnComplete( ()=> RotateButton());
        
    }
   // public void MoveButtonRight()
    //{
    //    Debug.Log("Button Clicked.");
     //   button.transform.DOLocalMove(initialPos, animDuration).SetEase(ease).OnComplete(() => MoveButton());
    //}

    public void ResizeButton()
    {
        button.transform.DOScale(Vector3.zero, animDuration);
    }

    public void RotateButton()
    {
        Debug.Log("Button clicked. Rotating...");
        button.transform.DOLocalRotate(new Vector3(0,0,360), 4f, RotateMode.FastBeyond360).SetLoops(5, LoopType.Yoyo);
    }

}