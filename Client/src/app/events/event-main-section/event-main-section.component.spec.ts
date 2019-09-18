import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { EventMainSectionComponent } from './event-main-section.component';

describe('EventMainSectionComponent', () => {
  let component: EventMainSectionComponent;
  let fixture: ComponentFixture<EventMainSectionComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ EventMainSectionComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(EventMainSectionComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
