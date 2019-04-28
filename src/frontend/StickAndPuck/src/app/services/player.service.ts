import { Player } from '../shared/models/player.model';
import { Injectable } from '@angular/core';

@Injectable()
export class PlayerService{
    
    getPlayers(): Player[]{
        
        let players = new Player[3];
       
        players[0] = new Player(1,"lol","kol",3);
        players[1] = new Player(1,"den","val",4);
        players[2] = new Player(1,"kol","red",5);

        return players;
    }     
}