
public class Player
{
    public int vita;
    public int punteggio;
    
    public Player(){
        vita = 3;
        punteggio = 0;

    }

    public void togliVita(){
        vita--;
    }

    public void addPunteggio(){
        punteggio += 125;

    }

    public void togliPunteggio(){
        if(punteggio>=200)
            punteggio -= 200;
        else
            punteggio=0;
    }


            
}


