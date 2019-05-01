import { Component } from "@angular/core";
import { PlayerService } from "src/app/shared/services/people/players.service";

@Component({
    selector: 'app-players',
    templateUrl: './players.component.html'
  })

  export class PlayersComponent {
    
    private playerService: PlayerService;

    constructor(playerService: PlayerService) {
        
        this.playerService = playerService;

    }

    public getPlayersByTop(topCount: number){

    }

    public searchPlayerByName(name: string){

    }

  }