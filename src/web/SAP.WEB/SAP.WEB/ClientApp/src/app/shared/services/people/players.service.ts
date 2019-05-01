import { Inject, Injectable } from "@angular/core";
import { HttpClient } from '@angular/common/http';
import { Player } from "../../models/people/player.model";

@Injectable()
export class PlayerService
{
    private httpClient: HttpClient;
    private baseUrl: string;

    constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string){
        this.httpClient = http;
        this.baseUrl = baseUrl; 
    }
  
    getPlayerById(id: number) {
      return this.httpClient.get<Player>(this.baseUrl + 'api/players/' + id);
    }

    // read about return type observable
    public getPlayers(){
        return this.httpClient.get<Player[]>(this.baseUrl + 'api/players');
    }
}

