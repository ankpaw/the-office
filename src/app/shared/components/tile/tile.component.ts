import { Component, OnInit, Input } from '@angular/core';
import { ITile } from "./ITile";
@Component({
  selector: 'app-tile',
  templateUrl: './tile.component.html',
  styleUrls: ['./tile.component.scss']
})
export class TileComponent implements OnInit {
  @Input() tile: ITile;
  constructor() { }

  ngOnInit(): void {
  }

}
