import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { PlayersList } from './players/playersList/playersList.component';
import { PlayerService } from './services/player.service';
import { Player } from './shared/models/player.model';

@NgModule({
  declarations: [
    AppComponent, 
    PlayersList
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [PlayerService
  ,Player],
  bootstrap: [AppComponent]
})
export class AppModule { }
