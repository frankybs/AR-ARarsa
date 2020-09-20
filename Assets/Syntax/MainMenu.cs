using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public GameObject MenuPanel;
    public GameObject HelpPanel;
    public GameObject CreditPanel;

    // Start is called before the first frame update
    void Start()
    {
        MenuPanel.SetActive(true);
        HelpPanel.SetActive(false);
        CreditPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) { Application.Quit(); }
    }

    public void PlayButtonClicked()
    {
        Application.LoadLevel("ARScene");
    }

    public void HelpButtonClicked()
    {
        HelpPanel.SetActive(true);
        CreditPanel.SetActive(false);
    }

    public void CreditButtonClicked()
    {
        HelpPanel.SetActive(false);
        CreditPanel.SetActive(true);
    }

    public void CloseButtonClicked()
    {
        MenuPanel.SetActive(true);
        HelpPanel.SetActive(false);
        CreditPanel.SetActive(false);
    }

}
