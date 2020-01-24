using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Controller : MonoBehaviour
{
    [Header("Paneles")]
    public GameObject P_bienvenido;
    public GameObject P_mapa;
    public GameObject P_1888;
    public GameObject P_1921;
    public GameObject P_1940;
    public GameObject P_1990;
    private int fecha;
    public GameObject P_galeria;
    public Image galeria_img;
    public Transform galeria_content;
    public GameObject prefabBotton;
    public GameObject P_galeriaGrande;
    public Image galeriaG_img;
    public GameObject P_audio;
    public AudioSource audioSource;
    public GameObject P_AR;

    [Header("UI")]
    public GameObject barra_arriba;
    public GameObject barra_abajo4B;
    public TextMeshProUGUI barra_titulo;
    [Space]
    public Button Btn_audio;
    public Button Btn_personaje;
    public Button Btn_AR;
    public Button Btn_foto;
    [Space]
    public Button Btn_saltar;
    public Button Btn_noVolverMostrar;

    [Header("partes 1888")]
    public bool TieneAudio_1888;
    public AudioClip audio_1888;
    public bool TienePersonajes_1888;
    public Sprite[] Personajes_1888;
    public bool TieneAR_1888;
    public GameObject AR_prefab_1888;
    public bool TieneFotos_1888;
    public Sprite[] Fotos_1888;

    [Header("partes 1921")]
    public bool TieneAudio_1921;
    public AudioClip audio_1921;
    public bool TienePersonajes_1921;
    public Sprite[] Personajes_1921;
    public bool TieneAR_1921;
    public GameObject AR_prefab_1921;
    public bool TieneFotos_1921;
    public Sprite[] Fotos_1921;

    [Header("partes 1940")]
    public bool TieneAudio_1940;
    public AudioClip audio_1940;
    public bool TienePersonajes_1940;
    public Sprite[] Personajes_1940;
    public bool TieneAR_1940;
    public GameObject AR_prefab_1940;
    public bool TieneFotos_1940;
    public Sprite[] Fotos_1940;

    [Header("partes 1990")]
    public bool TieneAudio_1990;
    public AudioClip audio_1990;
    public bool TienePersonajes_1990;
    public Sprite[] Personajes_1990;
    public bool TieneAR_1990;
    public GameObject AR_prefab_1990;
    public bool TieneFotos_1990;
    public Sprite[] Fotos_1990;

    private enum posicion {
        bienvenido,
        mapa,
        p1888,
        p1921,
        p1940,
        p1990,
        galeria,
        galeriaGrande,
        audio,
        AR}
    private posicion posicionOn;

    private void Awake()
    {
        Bienvenido();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Back();
        }
    }

    public void Back()
    {
        switch (posicionOn)
        {
            case posicion.bienvenido:
                //Application.Quit();
                break;
            case posicion.mapa:
                Bienvenido();
                break;
            case posicion.p1888:
                Mapa();
                break;
            case posicion.p1921:
                Mapa();
                break;
            case posicion.p1940:
                Mapa();
                break;
            case posicion.p1990:
                Mapa();
                break;
            case posicion.galeria:
                switch (fecha)
                {
                    case 1888:
                        Mapa1888();
                        break;
                    case 1921:
                        Mapa1921();
                        break;
                    case 1940:
                        Mapa1940();
                        break;
                    case 1990:
                        Mapa1990();
                        break;
                }
                break;
            case posicion.galeriaGrande:
                switch (fecha)
                {
                    case 1888:
                        Mapa1888();
                        break;
                    case 1921:
                        Mapa1921();
                        break;
                    case 1940:
                        Mapa1940();
                        break;
                    case 1990:
                        Mapa1990();
                        break;
                }
                break;
            case posicion.audio:
                switch (fecha)
                {
                    case 1888:
                        Mapa1888();
                        break;
                    case 1921:
                        Mapa1921();
                        break;
                    case 1940:
                        Mapa1940();
                        break;
                    case 1990:
                        Mapa1990();
                        break;
                }
                break;
            case posicion.AR:
                switch (fecha)
                {
                    case 1888:
                        Mapa1888();
                        break;
                    case 1921:
                        Mapa1921();
                        break;
                    case 1940:
                        Mapa1940();
                        break;
                    case 1990:
                        Mapa1990();
                        break;
                }
                break;
        }
    }

    private void BarraArriba(bool on, string titulo)
    {
        barra_arriba.SetActive(on);
        barra_titulo.text = titulo;
    }
    private void BarraAbajo(bool on, int fecha)
    {
        barra_abajo4B.SetActive(on);
        switch (fecha)
        {
            case 1888:
                if (TieneAudio_1888)
                {
                    Btn_audio.interactable = true;
                    Btn_audio.onClick.RemoveAllListeners();
                    Btn_audio.onClick.AddListener(() => Radio(audio_1888, 1888));
                }
                else
                {
                    Btn_audio.interactable = false;
                    Btn_audio.onClick.RemoveAllListeners();
                }
                if (TienePersonajes_1888)
                {
                    Btn_personaje.interactable = true;
                    Btn_personaje.onClick.RemoveAllListeners();
                    Btn_personaje.onClick.AddListener(() => Galeria(Personajes_1888[0], Personajes_1888));
                }
                else
                {
                    Btn_personaje.interactable = false;
                    Btn_personaje.onClick.RemoveAllListeners();
                }
                if (TieneAR_1888)
                {
                    Btn_AR.interactable = true;
                    Btn_AR.onClick.RemoveAllListeners();
                    Btn_AR.onClick.AddListener(() => AR(AR_prefab_1888));
                }
                else
                {
                    Btn_AR.interactable = false;
                    Btn_AR.onClick.RemoveAllListeners();
                }
                if (TieneFotos_1888)
                {
                    Btn_foto.interactable = true;
                    Btn_foto.onClick.RemoveAllListeners();
                    Btn_foto.onClick.AddListener(() => Galeria(Fotos_1888[0], Fotos_1888));
                }
                else
                {
                    Btn_foto.interactable = false;
                    Btn_foto.onClick.RemoveAllListeners();
                }
                break;
            case 1921:
                if (TieneAudio_1921)
                {
                    Btn_audio.interactable = true;
                    Btn_audio.onClick.RemoveAllListeners();
                    Btn_audio.onClick.AddListener(() => Radio(audio_1921, 1921));
                }
                else
                {
                    Btn_audio.interactable = false;
                    Btn_audio.onClick.RemoveAllListeners();
                }
                if (TienePersonajes_1921)
                {
                    Btn_personaje.interactable = true;
                    Btn_personaje.onClick.RemoveAllListeners();
                    Btn_personaje.onClick.AddListener(() => Galeria(Personajes_1921[0], Personajes_1921));
                }
                else
                {
                    Btn_personaje.interactable = false;
                    Btn_personaje.onClick.RemoveAllListeners();
                }
                if (TieneAR_1921)
                {
                    Btn_AR.interactable = true;
                    Btn_AR.onClick.RemoveAllListeners();
                    Btn_AR.onClick.AddListener(() => AR(AR_prefab_1921));
                }
                else
                {
                    Btn_AR.interactable = false;
                    Btn_AR.onClick.RemoveAllListeners();
                }
                if (TieneFotos_1921)
                {
                    Btn_foto.interactable = true;
                    Btn_foto.onClick.RemoveAllListeners();
                    Btn_foto.onClick.AddListener(() => Galeria(Fotos_1921[0], Fotos_1921));
                }
                else
                {
                    Btn_foto.interactable = false;
                    Btn_foto.onClick.RemoveAllListeners();
                }
                break;
            case 1940:
                if (TieneAudio_1940)
                {
                    Btn_audio.interactable = true;
                    Btn_audio.onClick.RemoveAllListeners();
                    Btn_audio.onClick.AddListener(() => Radio(audio_1940, 1940));
                }
                else
                {
                    Btn_audio.interactable = false;
                    Btn_audio.onClick.RemoveAllListeners();
                }
                if (TienePersonajes_1940)
                {
                    Btn_personaje.interactable = true;
                    Btn_personaje.onClick.RemoveAllListeners();
                    Btn_personaje.onClick.AddListener(() => Galeria(Personajes_1940[0], Personajes_1940));
                }
                else
                {
                    Btn_personaje.interactable = false;
                    Btn_personaje.onClick.RemoveAllListeners();
                }
                if (TieneAR_1940)
                {
                    Btn_AR.interactable = true;
                    Btn_AR.onClick.RemoveAllListeners();
                    Btn_AR.onClick.AddListener(() => AR(AR_prefab_1940));
                }
                else
                {
                    Btn_AR.interactable = false;
                    Btn_AR.onClick.RemoveAllListeners();
                }
                if (TieneFotos_1940)
                {
                    Btn_foto.interactable = true;
                    Btn_foto.onClick.RemoveAllListeners();
                    Btn_foto.onClick.AddListener(() => Galeria(Fotos_1940[0], Fotos_1940));
                }
                else
                {
                    Btn_foto.interactable = false;
                    Btn_foto.onClick.RemoveAllListeners();
                }
                break;
            case 1990:
                if (TieneAudio_1990)
                {
                    Btn_audio.interactable = true;
                    Btn_audio.onClick.RemoveAllListeners();
                    Btn_audio.onClick.AddListener(() => Radio(audio_1990, 1990));
                }
                else
                {
                    Btn_audio.interactable = false;
                    Btn_audio.onClick.RemoveAllListeners();
                }
                if (TienePersonajes_1990)
                {
                    Btn_personaje.interactable = true;
                    Btn_personaje.onClick.RemoveAllListeners();
                    Btn_personaje.onClick.AddListener(() => Galeria(Personajes_1990[0], Personajes_1990));
                }
                else
                {
                    Btn_personaje.interactable = false;
                    Btn_personaje.onClick.RemoveAllListeners();
                }
                if (TieneAR_1990)
                {
                    Btn_AR.interactable = true;
                    Btn_AR.onClick.RemoveAllListeners();
                    Btn_AR.onClick.AddListener(() => AR(AR_prefab_1990));
                }
                else
                {
                    Btn_AR.interactable = false;
                    Btn_AR.onClick.RemoveAllListeners();
                }
                if (TieneFotos_1990)
                {
                    Btn_foto.interactable = true;
                    Btn_foto.onClick.RemoveAllListeners();
                    Btn_foto.onClick.AddListener(() => Galeria(Fotos_1990[0], Fotos_1990));
                }
                else
                {
                    Btn_foto.interactable = false;
                    Btn_foto.onClick.RemoveAllListeners();
                }
                break;
        }
    }

    private void Bienvenido()
    {
        P_bienvenido.SetActive(true);
        posicionOn = posicion.bienvenido;
        P_mapa.SetActive(false);
        P_1888.SetActive(false);
        P_1921.SetActive(false);
        P_1940.SetActive(false);
        P_1990.SetActive(false);
        P_galeria.SetActive(false);
        P_galeriaGrande.SetActive(false);
        P_audio.SetActive(false);

        BarraArriba(false, null);
    }

    public void Mapa()
    {
        P_bienvenido.SetActive(false);
        P_mapa.SetActive(true);
        posicionOn = posicion.mapa;
        P_1888.SetActive(false);
        P_1921.SetActive(false);
        P_1940.SetActive(false);
        P_1990.SetActive(false);
        P_galeria.SetActive(false);
        P_galeriaGrande.SetActive(false);
        P_audio.SetActive(false);

        BarraArriba(true, "Mapa");
        BarraAbajo(false, 0);
    }

    public void Mapa1990()
    {
        fecha = 1990;
        P_bienvenido.SetActive(false);
        P_mapa.SetActive(false);
        P_1888.SetActive(false);
        P_1921.SetActive(false);
        P_1940.SetActive(false);
        P_1990.SetActive(true);
        posicionOn = posicion.p1990;
        P_galeria.SetActive(false);
        P_galeriaGrande.SetActive(false);
        P_audio.SetActive(false);

        BarraArriba(true, "Segunda Epoca");
        BarraAbajo(true, 1990);
    }
    public void Mapa1940()
    {
        fecha = 1940;
        P_bienvenido.SetActive(false);
        P_mapa.SetActive(false);
        P_1888.SetActive(false);
        P_1921.SetActive(false);
        P_1940.SetActive(true);
        posicionOn = posicion.p1940;
        P_1990.SetActive(false);
        P_galeria.SetActive(false);
        P_galeriaGrande.SetActive(false);
        P_audio.SetActive(false);

        BarraArriba(true, "Segunda Epoca");
        BarraAbajo(true, 1940);
    }
    public void Mapa1921()
    {
        fecha = 1921;
        P_bienvenido.SetActive(false);
        P_mapa.SetActive(false);
        P_1888.SetActive(false);
        P_1921.SetActive(true);
        posicionOn = posicion.p1921;
        P_1940.SetActive(false);
        P_1990.SetActive(false);
        P_galeria.SetActive(false);
        P_galeriaGrande.SetActive(false);
        P_audio.SetActive(false);

        BarraArriba(true, "Segunda Epoca");
        BarraAbajo(true, 1921);
    }
    public void Mapa1888()
    {
        fecha = 1888;
        P_bienvenido.SetActive(false);
        P_mapa.SetActive(false);
        P_1888.SetActive(true);
        posicionOn = posicion.p1888;
        P_1921.SetActive(false);
        P_1940.SetActive(false);
        P_1990.SetActive(false);
        P_galeria.SetActive(false);
        P_galeriaGrande.SetActive(false);
        P_audio.SetActive(false);

        BarraArriba(true, "Segunda Epoca");
        BarraAbajo(true, 1888);
    }

    private void Galeria(Sprite imgPrimera, Sprite[] imagenes)
    {
        P_bienvenido.SetActive(false);
        P_mapa.SetActive(false);
        P_1888.SetActive(false);
        P_1921.SetActive(false);
        P_1940.SetActive(false);
        P_1990.SetActive(false);
        P_galeria.SetActive(true);
        P_galeriaGrande.SetActive(false);
        P_audio.SetActive(false);
        posicionOn = posicion.galeria;
        galeria_img.sprite = imgPrimera;

        Toggle[] basura = galeria_content.GetComponentsInChildren<Toggle>();
        for (int i = 0; i < basura.Length; i++)
        {
            Destroy(basura[i].gameObject);
        }

        GameObject[] imgBtns = new GameObject[imagenes.Length];
        for (int i = 0; i < imagenes.Length; i++)
        {
            imgBtns[i] = Instantiate(prefabBotton, galeria_content);
            imgBtns[i].GetComponent<Image>().sprite = imagenes[i];
            Toggle tgl = imgBtns[i].GetComponent<Toggle>();
            Sprite spr = imagenes[i];
            tgl.onValueChanged.AddListener((Sprite) => ElegirImagen(spr));
        }

        BarraArriba(true, "Galeria");
        BarraAbajo(false, 0);
    }

    private void ElegirImagen(Sprite img)
    {
        galeriaG_img.sprite = img;
        galeria_img.sprite = img;
    }

    public void GaleriaGrande()
    {
        P_bienvenido.SetActive(false);
        P_mapa.SetActive(false);
        P_1888.SetActive(false);
        P_1921.SetActive(false);
        P_1940.SetActive(false);
        P_1990.SetActive(false);
        P_galeria.SetActive(false);
        P_galeriaGrande.SetActive(true);
        P_audio.SetActive(false);
        posicionOn = posicion.galeriaGrande;

        BarraArriba(true, "Galeria");
        BarraAbajo(false, 0);
    }

    private void Radio(AudioClip audio, int fecha)
    {
        P_bienvenido.SetActive(false);
        P_mapa.SetActive(false);
        P_1888.SetActive(false);
        P_1921.SetActive(false);
        P_1940.SetActive(false);
        P_1990.SetActive(false);
        P_galeria.SetActive(false);
        P_galeriaGrande.SetActive(false);
        P_audio.SetActive(true);
        posicionOn = posicion.audio;
        audioSource.clip = audio;
        audioSource.Play();

        BarraArriba(true, "Noticia de " +  fecha);
        BarraAbajo(false, 0);
    }

    public void AR(GameObject prefabAR)
    {
        P_bienvenido.SetActive(false);
        P_mapa.SetActive(false);
        P_1888.SetActive(false);
        P_1921.SetActive(false);
        P_1940.SetActive(false);
        P_1990.SetActive(false);
        P_galeria.SetActive(false);
        P_galeriaGrande.SetActive(false);
        P_audio.SetActive(false);
        //ar

        posicionOn = posicion.AR;

        BarraArriba(true, "Realidad Aumentada");
        BarraAbajo(false, 0);
    }
}