import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { LibraryListComponentComponent } from './library-list-component.component';

describe('LibraryListComponentComponent', () => {
  let component: LibraryListComponentComponent;
  let fixture: ComponentFixture<LibraryListComponentComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ LibraryListComponentComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(LibraryListComponentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
