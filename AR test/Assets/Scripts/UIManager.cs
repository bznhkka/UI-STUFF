using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    [Tooltip("The main menu itself.")]
    GameObject m_MainMenuModal;

    [SerializeField]
    [Tooltip("The Transform menu itself.")]
    GameObject m_TransformModal;

    [SerializeField]
    [Tooltip("The Colour Change menu itself.")]
    GameObject m_ChangeColourModal;

    [SerializeField]
    [Tooltip("The Animate menu itself.")]
    GameObject m_AnimateModal;

    [SerializeField]
    [Tooltip("The Change Model menu itself.")]
    GameObject m_ChangeModelModal;

    enum UIStates
    {
        /// <summary>
        /// Don't show any menu
        /// </summary>
        NoFocus,

        /// <summary>
        /// Show main menu
        /// </summary>
        MainMenu,

        /// <summary>
        /// Show the Transform menu
        /// </summary>
        TransformMenu,

        /// <summary>
        /// Show the Customize menu
        /// </summary>
        CustomizeMenu,

        /// <summary>
        /// Show the Animate menu
        /// </summary>
        AnimateMenu,

        /// <summary>
        /// Show the Change Model menu
        /// </summary>
        ChangeModelMenu,
    }

    UIStates m_CurrentState;

    /// <summary>
    /// See <see cref="MonoBehaviour"/>.
    /// </summary>
    void Awake()
    {
        m_CurrentState = UIStates.NoFocus;
    }

    /// <summary>
    /// See <see cref="MonoBehaviour"/>.
    /// </summary>
    void Start()
    {
        // The below lines are not necessary if the scene is configured accordingly.
        m_MainMenuModal.SetActive(false);
        m_TransformModal.SetActive(false);
        m_ChangeColourModal.SetActive(false);
        m_AnimateModal.SetActive(false);
        m_ChangeModelModal.SetActive(false);
    }

    /// <summary>
    /// See <see cref="MonoBehaviour"/>.
    /// </summary>
    void Update()
    {
        // NOTE: below is too inefficient, but very safe, use for debugging only
        // switch (m_CurrentState)
        // {
        //     case UIStates.NoFocus:
        //         m_MainMenuModal.SetActive(false);
        //         break;
        //     case UIStates.MainMenu:
        //         m_MainMenuModal.SetActive(true);
        //         break;
        //     case UIStates.TransformMenu:
        //         break;
        //     case UIStates.CustomizeMenu:
        //         break;
        //     case UIStates.AnimateMenu:
        //         break;
        //     case UIStates.ChangeModelMenu:
        //         break;
        // }
    }

    public void ShowHideMenu()
    {
        if (m_CurrentState == UIStates.NoFocus)
        {
            m_CurrentState = UIStates.MainMenu;
            m_MainMenuModal.SetActive(true);
        }
        else if (m_CurrentState == UIStates.MainMenu)
        {
            m_CurrentState = UIStates.NoFocus;
            m_MainMenuModal.SetActive(false);
        }
        else
        {
            m_CurrentState = UIStates.MainMenu;
            m_MainMenuModal.SetActive(true);
            m_TransformModal.SetActive(false);
            m_ChangeColourModal.SetActive(false);
            m_AnimateModal.SetActive(false);
            m_ChangeModelModal.SetActive(false);
        }
    }

    public void ShowTransformMenu()
    {
        m_CurrentState = UIStates.TransformMenu;
        m_MainMenuModal.SetActive(false);
        m_TransformModal.SetActive(true);
    }

    public void ShowColourChangeMenu()
    {
        m_CurrentState = UIStates.CustomizeMenu;
        m_MainMenuModal.SetActive(false);
        m_ChangeColourModal.SetActive(true);
    }

    public void ShowAnimateMenu()
    {
        m_CurrentState = UIStates.AnimateMenu;
        m_MainMenuModal.SetActive(false);
        m_AnimateModal.SetActive(true);
    }

    public void ShowChangeModelMenu()
    {
        m_CurrentState = UIStates.ChangeModelMenu;
        m_MainMenuModal.SetActive(false);
        m_ChangeModelModal.SetActive(true);
    }

    public void Debug()
    {
        print("AAA");
    }
}
