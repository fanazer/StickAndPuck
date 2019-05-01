import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './components/nav-menu/nav-menu.component';
import { HomeComponent } from './pages/home/home.component';
import { PlayersComponent } from './pages/players/players.component';
import { PlayerService } from './shared/services/people/players.service';
import { TeamsComponent } from './pages/teams/teams.component';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    PlayersComponent,
    TeamsComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full'},
      { path: 'players', component: PlayersComponent },
      { path: 'teams', component: TeamsComponent }
    ])
  ],
  providers: [PlayerService],
  bootstrap: [AppComponent]
})
export class AppModule { }
