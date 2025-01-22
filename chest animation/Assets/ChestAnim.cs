using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class ChestAnim : MonoBehaviour
{
    public GameObject chestObject;
    public Vector3 sizeMultipler;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (chestObject != null)
        {
            chestObject.transform.DOScale(sizeMultipler, 0.25f);
        }
       
    }

    public void ReturntoOG(GameObject obj)
    {
        obj.transform.DOScale(Vector3.one, .25f);
    }

    public void OpenChestAnim(GameObject obj, GameObject lid)
    {
        Sequence chestSequence = DOTween.Sequence();
        // 1st anim
        // move chest 5 units up
        // rotate while moving up
        chestSequence.Append(obj.transform.DOMoveY(2f, 0.25f).SetEase(Ease.Linear));
        chestSequence.Join(obj.transform.DORotate(Vector3.up * 180, 0.25f));
        // 2nd anim
        // revert to original pos and rotation
        chestSequence.Append(obj.transform.DOMoveY(0, 0.45f).SetEase(Ease.Linear));
        chestSequence.Join(obj.transform.DORotate(Vector3.up * 360, 0.45f));
        // 3rd anim
        // shake and scale up
        // shake -> float duration, float strength
        chestSequence.Append(obj.transform.DOShakeRotation(0.55f, 20f, 25, 10f));
        chestSequence.Join(obj.transform.DOScaleY(transform.localScale.y * 1.25f, 0.55f));
        // 4th anim
        // open chest
        // scale down by 25%
        chestSequence.Append(lid.transform.DORotate(Vector3.left * 125, 1.5f));
        chestSequence.Join(obj.transform.DOScaleY(transform.localScale.y * 1.0f, 0.55f));
    }
}
