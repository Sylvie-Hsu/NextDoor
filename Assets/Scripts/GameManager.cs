using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    bool gameHasEnded = false;

    int room1 = 0;

    public float restartDelay = 1f;

    public GameObject MirrorHintUI;
    bool Mirrorb = false;
    public GameObject ChipsHintUI;
    bool Chipsb = false;

    public GameObject PizzaHintUI;
    bool Pizzab = false;
    public GameObject Door1UI;

    public GameObject BookstoreUI;
    bool Bookstoreb = false;
    public GameObject ClassroomUI;
    bool Classroomb = false;
    public GameObject ClockUI;
    bool Clockb = false;
    public GameObject HallwayUI;
    bool Hallwayb = false;
    public GameObject PaperUI;
    bool Paperb = false;
    public GameObject PencilUI;
    bool Pencilb = false;

    public GameObject TshirtUI;
    bool Tshirtb = false;

    public GameObject SwordUI;
    bool Swordb = false;
    public GameObject AcceptUI;
    bool Acceptb = false;

    public GameObject RadioUI;
    bool Radiob = false;
    public GameObject OrderUI;
    bool Orderb = false;
    public GameObject LoliUI;
    bool Lolib = false;
    public GameObject NoodleTongUI;
    bool NoodleTongb = false;
    public GameObject ByyUI;
    bool Byyb = false;
    public GameObject BycicleUI;
    bool Bycicleb = false;

    public GameObject RoadUI;
    bool Roadb = false;
    public GameObject GraveUI;
    bool Graveb = false;
    public GameObject NoodleUI;
    bool Noodleb = false;
    public GameObject BoxUI;
    bool Boxb = false;
    public GameObject ScissorsUI;
    bool Scissorsb = false;

    public GameObject LaunchUI;
    bool Launchb = false;
    public GameObject Paper2UI;
    bool Paper2b = false;

    public GameObject Door1;
    public GameObject Door4;
    public GameObject Door5;
    public GameObject Door6;
    public GameObject Door7;
    public GameObject Door8;
    public GameObject Door9;
    public GameObject Door10;
    public GameObject Music;

    public void Door1Open()
    {
        if (Mirrorb == true && Chipsb == true && Pizzab == true)
        {
            Door1.SetActive(false);
        }
    }

    public void Door4Open()
    {
        if (Classroomb == true && Tshirtb == true && Pencilb == true && Paperb == true && Paper2b == true && Clockb == true)
        {
            Door4.SetActive(false);
        }
    }

    public void Door5Open()
    {
        if (Scissorsb == true && Bycicleb == true)
        {
            Door5.SetActive(false);
        }
    }
    public void Door6Open()
    {
        if (Swordb == true && Noodleb == true && Boxb == true)
        {
            Door6.SetActive(false);
        }
    }
    public void Door7Open()
    {
        if (Graveb == true)
        {
            Door7.SetActive(false);
        }
    }

    public void Door8Open()
    {
        if (Roadb == true)
        {
            Door8.SetActive(false);
        }
    }

    public void Door9Open()
    {
        if (Launchb == true && Byyb == true)
        {
            Door9.SetActive(false);
        }
    }

    public void Door10Open()
    {
        if (NoodleTongb == true && Lolib == true)
        {
            Door10.SetActive(false);
        }
    }



    public void CompleteLevel()
    {
        Debug.Log("COMPLETE LEVEL");
        //CompleteLevelUI.SetActive(true);
    }

    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("GAME OVER");
            Invoke("Restart", restartDelay);
        }
    }

    public void MirrorHint()
    {
        Debug.Log("GAME OVER");
        MirrorHintUI.SetActive(true);
        Mirrorb = true;
        Door1Open();
    }

    public void ChipsHint()
    {
        Debug.Log("GAME OVER");
        ChipsHintUI.SetActive(true);
        Chipsb = true;
        Door1Open();
    }

    public void PizzaHint()
    {
        Debug.Log("GAME OVER");
        PizzaHintUI.SetActive(true);
        Pizzab = true;
        Door1Open();
    }

    public void Bookstr()
    {
        Debug.Log("GAME OVER");
        BookstoreUI.SetActive(true);
        Bookstoreb = true;
    }

    public void Hallway()
    {
        Debug.Log("GAME OVER");
        HallwayUI.SetActive(true);
        Hallwayb = true;
    }

    public void Classroom()
    {
        Debug.Log("GAME OVER");
        ClassroomUI.SetActive(true);
        Classroomb = true;
        Door4Open();
    }

    public void Clock()
    {
        Debug.Log("GAME OVER");
        ClockUI.SetActive(true);
        Clockb = true;
        Door4Open();
    }

    public void PaperHint()
    {
        Debug.Log("GAME OVER");
        PaperUI.SetActive(true);
        Paperb = true;
        Door4Open();
    }

    public void PencilHint()
    {
        Debug.Log("GAME OVER");
        PencilUI.SetActive(true);
        Pencilb = true;
        Door4Open();
    }

    public void Tshirt()
    {
        Debug.Log("GAME OVER");
        TshirtUI.SetActive(true);
        Tshirtb = true;
        Door4Open();
    }

    public void Sword()
    {
        Debug.Log("GAME OVER");
        SwordUI.SetActive(true);
        Swordb = true;
        Door6Open();
    }

    public void Accept()
    {
        Debug.Log("GAME OVER");
        AcceptUI.SetActive(true);
        Acceptb = true;
    }
    public void Radio()
    {
        Debug.Log("GAME OVER");
        RadioUI.SetActive(true);
        Radiob = true;

    }
    public void Order()
    {
        Debug.Log("GAME OVER");
        OrderUI.SetActive(true);
        Orderb = true;
    }
    public void Loli()
    {
        Debug.Log("GAME OVER");
        LoliUI.SetActive(true);
        Lolib = true;
        Door10Open();
    }
    public void NoodleTong()
    {
        Debug.Log("GAME OVER");
        NoodleTongUI.SetActive(true);
        NoodleTongb = true;
        Door10Open();
    }
    public void Byy()
    {
        Debug.Log("GAME OVER");
        ByyUI.SetActive(true);
        Byyb = true;
        Door9Open();
    }
    public void Bycicle()
    {
        Debug.Log("GAME OVER");
        BycicleUI.SetActive(true);
        Bycicleb = true;
        Door5Open();
    }

    public void Launch()
    {
        Debug.Log("GAME OVER");
        LaunchUI.SetActive(true);
        Launchb = true;
        Door9Open();
    }

    public void Road()
    {
        Debug.Log("GAME OVER");
        RoadUI.SetActive(true);
        Roadb = true;
        Door8Open();
    }
    public void Grave()
    {
        Debug.Log("GAME OVER");
        GraveUI.SetActive(true);
        Music.SetActive(true);
        Graveb = true;
        Door7Open();
    }
    public void Noodle()
    {
        Debug.Log("GAME OVER");
        NoodleUI.SetActive(true);
        Noodleb = true;
        Door6Open();
    }
    public void Box()
    {
        Debug.Log("GAME OVER");
        BoxUI.SetActive(true);
        Boxb = true;
        Door6Open();
    }

    public void Scissors()
    {
        Debug.Log("GAME OVER");
        ScissorsUI.SetActive(true);
        Scissorsb = true;
        Door5Open();
    }

    public void Paper2()
    {
        Debug.Log("GAME OVER");
        Paper2UI.SetActive(true);
        Paper2b = true;
        Door4Open();
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
