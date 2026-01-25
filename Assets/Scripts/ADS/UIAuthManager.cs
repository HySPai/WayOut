using Firebase.Auth;
using UnityEngine;

public class UIAuthManager : MonoBehaviour
{
    public static UIAuthManager instance;

    public GameObject loginUI;
    public GameObject registerUI;
    public GameObject userDataUI;
    public GameObject scoreboardUI;
    public GameObject mainMenu;

    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);
    }

    private bool IsLoggedIn()
    {
        return FirebaseAuth.DefaultInstance.CurrentUser != null;
    }

    public void ClearScreen()
    {
        loginUI.SetActive(false);
        registerUI.SetActive(false);
        userDataUI.SetActive(false);
        scoreboardUI.SetActive(false);
        mainMenu.SetActive(false);
    }

    public void LoginScreen()
    {
        ClearScreen();
        loginUI.SetActive(true);
    }

    public void RegisterScreen()
    {
        ClearScreen();
        registerUI.SetActive(true);
    }

    public void UserDataScreen()
    {
        if (IsLoggedIn())
        {
            ClearScreen();
            userDataUI.SetActive(true);
        }
        else
        {
            LoginScreen();
        }
    }

    public void ScoreboardScreen()
    {
        if (IsLoggedIn())
        {
            ClearScreen();
            scoreboardUI.SetActive(true);
        }
        else
        {
            LoginScreen();
        }
    }

    public void MainMenuScreen()
    {
        ClearScreen();
        mainMenu.SetActive(true);
    }

    public void OnUserLogin()
    {
        MainMenuScreen();
    }

    public void OnUserSignOut()
    {
        LoginScreen();
    }
}
