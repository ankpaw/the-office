import { Component, OnInit, Input } from '@angular/core';
import { ICatalogItem } from "./ICatalogItem";

@Component({
  selector: 'app-catalog',
  templateUrl: './catalog.component.html',
  styleUrls: ['./catalog.component.scss']
})
export class CatalogComponent implements OnInit {
  @Input() catalogItem: ICatalogItem;
  constructor() { }

  ngOnInit(): void {
  }

}
