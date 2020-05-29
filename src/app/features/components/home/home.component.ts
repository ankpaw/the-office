import { Component, OnInit } from '@angular/core';
import { ICatalogItem } from '@shared/components/catalog/ICatalogItem';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss'],
})
export class HomeComponent implements OnInit {
  public catalogItems: ICatalogItem[] = [
    {
      Heading: 'Power BI Experts',
      Tiles: [
        {
          Title: 'Custom visuals',
          Highlights: [
            'Created over 20 percent of custom visuals available on Microsoft AppSource',
            '400,000+ downloads of our custom visuals',
          ],
          CallToActionText: 'Learn More',
          CallToActionLink: '#',
          ImageSource: "../../../../assets/img/TileImage1.png"
        },
        {
          Title: 'Power BI Expertise',
          Highlights: [
            'Microsoft Preferred Supplier for Power BI',
            '200+ Power BI Certified engineers',
            'Comprehensive Power BI Best Practices Guide',
          ],
          CallToActionText: 'Learn More',
          CallToActionLink: '#',
          ImageSource: "../../../../assets/img/TileImage2.png"
        },
        {
          Title: 'Consulting',
          Highlights: [
            'Power BI consulting service provider at AppSource',
            'Increasing Power BI adoption through development seminars',
          ],
          CallToActionText: 'Learn More',
          CallToActionLink: '#',
          ImageSource: "../../../../assets/img/TileImage3.png"
        },
      ],
    }, {
      Heading: 'Case Studies',
      Tiles: [
        {
          Title: 'ALM Toolkit Simplifies Deployment ',
          Highlights: [
            'ALM Toolkit allows Power BI developers to track changes in development and control what code is deployed.',
          ],
          CallToActionText: 'Learn More',
          CallToActionLink: '#',
          ImageSource: "../../../../assets/img/TileImage4.png"
        },
        {
          Title: 'Consolidate Data on the Cloud',
          Highlights: [
            'MAQ Software delivers state-of-the-art solution to facilitate revenue growth for a software company.',
          ],
          CallToActionText: 'Learn More',
          CallToActionLink: '#',
          ImageSource: "../../../../assets/img/TileImage5.png"
        },
        {
          Title: 'Boosting Black Friday Sales with AI',
          Highlights: [
            'MAQ Software implements a state-of-the-art Azure and Power BI solution to report sales',
          ],
          CallToActionText: 'Learn More',
          CallToActionLink: '#',
          ImageSource: "../../../../assets/img/TileImage6.png"
        },
      ],
    }
  ];

  constructor() {}

  ngOnInit(): void {}
}
