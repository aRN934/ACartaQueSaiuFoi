using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// O meu entusiasmo por ter conseguido fazer isto foi mesmo grande, perdoe a maluqueira :)

public class ACartaQueSaiuFoi : MonoBehaviour
{
    string TextoNaipe;
    string TextoChacha;
    int VariavelNaipe;
    int VariavelFigura;
    int VariavelChacha;
        
    void Start()
    {
        Debug.Log("Sou a Madame Sabetout e vou ler a tua sina!");
        Debug.Log("Carrega no ESPAÇO quando os astros se alinharem...");

    }

    void Update()
    {
       
        VariavelFigura = Random.Range(1, 14);
        VariavelNaipe = Random.Range(1, 5);
        VariavelChacha = Random.Range(1, 10);

        if (VariavelNaipe == 1) TextoNaipe = "Espadas";
        else if (VariavelNaipe == 2) TextoNaipe = "Paus";
        else if (VariavelNaipe == 3) TextoNaipe = "Ouros";
        else if (VariavelNaipe == 4) TextoNaipe = "Copas";

        if (VariavelChacha == 1) TextoChacha = ". Vejo que tudo vai correr bem na tua vida. Agora desanda.";
        else if (VariavelChacha == 2) TextoChacha = ". Tudo nuvens côr-de-rosa às bolinhas azuis. Vai à tua vida, criança.";
        else if (VariavelChacha == 3) TextoChacha = ". Sejemos todos felizes com a sorte que te sai na rifa. Chô.";
        else if (VariavelChacha == 4) TextoChacha = ". Já viste que lindo futuro?, já nem sei o que diga...";
        else if (VariavelChacha == 5) TextoChacha = ". Só coisas boas que te esperam, nada a recear nos próximos 209 anos.";
        else if (VariavelChacha == 6) TextoChacha = ". Futuro risonho, cuidado com as rugas.";
        else if (VariavelChacha == 7) TextoChacha = ". Isto é tanta possibilidade linda, credo. Seve-me mais uma taça de chá.";
        else if (VariavelChacha == 8) TextoChacha = ". Champanhe!, vais ter o que celebrar daqui a pouco.";
        else if (VariavelChacha == 9) TextoChacha = ". Vais dar-me gorjeta extra com as notícias boas que te vão chegar.";


        if (Input.GetKeyDown(KeyCode.Space))
        {

            if (VariavelFigura == 1) Debug.Log("A tua carta é o Ás de " + TextoNaipe + " - serás triunfante nesse assunto que te preocupa.");
            else if (VariavelFigura == 11) Debug.Log("A tua carta é o Valete de " + TextoNaipe + " - vais ter notícias importantes em breve.");
            else if (VariavelFigura == 12) Debug.Log("A tua carta é a Dama de " + TextoNaipe + " - uuuh estamos a falor de paixonetas, não é?");
            else if (VariavelFigura == 13) Debug.Log("A tua carta é o Rei de " + TextoNaipe + " - esta carta dá-te segurança, avança em confiança.");

            else Debug.Log("A tua carta é o " + VariavelFigura + " de " + TextoNaipe + TextoChacha);
           
        }
    }
}
