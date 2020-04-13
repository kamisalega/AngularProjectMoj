import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { LibraryBanerComponent } from './library-baner.component';

describe('LibraryBanerComponent', () => {
  let component: LibraryBanerComponent;
  let fixture: ComponentFixture<LibraryBanerComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ LibraryBanerComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(LibraryBanerComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
