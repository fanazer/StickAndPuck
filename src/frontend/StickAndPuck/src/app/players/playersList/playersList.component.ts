import { Component, Injectable } from "@angular/core";
import { HttpClient } from 'selenium-webdriver/http';
// import { Player } from 'src/app/shared/models/player.model';
// import { PlayerService } from 'src/app/services/player.service';

@Component({
    selector: 'players-list',
    templateUrl: './playersList.component.html'
    // styleUrls: ['./playersList.component.css']
})

export class PlayersList {

    public players:Player[];

    constructor(htpp: HttpClient) {        
        
        this.players = this.service.getPlayers();
    }
}

interface Player{
    id:number,
    firstName:string,
    lastName: string,
    age: number
}

