using UnityEngine;
using System.Collections.Generic;

public class ModelManager : MonoBehaviour
{
    [SerializeField]
    List<GameObject> m_ModelList = new List<GameObject>();

    int m_CurrentModel = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        foreach (GameObject model in m_ModelList)
        {
            model.SetActive(false);
        }
        m_ModelList[m_CurrentModel].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void DecCycleModel()
    {
        m_ModelList[m_CurrentModel].SetActive(false);
        m_CurrentModel--;
        if (m_CurrentModel < 0) m_CurrentModel *= -1;
        m_CurrentModel %= m_ModelList.Count;
        m_ModelList[m_CurrentModel].SetActive(true);
    }


    public void IncCycleModel()
    {
        m_ModelList[m_CurrentModel].SetActive(false);
        m_CurrentModel++;
        m_CurrentModel %= m_ModelList.Count;
        m_ModelList[m_CurrentModel].SetActive(true);
    }
}
